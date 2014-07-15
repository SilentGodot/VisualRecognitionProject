using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util;
using Emgu.CV.Structure;

namespace AgeEstimation
{
    public partial class AgeEstimator : Form
    {
        DataSetManager m_dtManager;
        EigenFaceRecognizer m_eigenFace;
        ConfigForm m_cfgForm;
        public AgeEstimator()
        {
            InitializeComponent();

            m_cfgForm = new ConfigForm();

            m_dtManager = new DataSetManager(@"..\..\DataSet");
            m_dtManager.ImageFileProccessedEvent += ProgressMadeEventHandler;

            ResetEigenFaces();
        }

        private void ResetEigenFaces()
        {
            m_eigenFace = new EigenFaceRecognizer(Properties.Settings.Default.EigenfacesComponents, double.PositiveInfinity);
        }

        void ProgressMadeEventHandler()
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(new ThreadStart(() =>
                {
                    progressBar.PerformStep();
                }));
            else
                progressBar.PerformStep();
        }

        private async void loadDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowPanel.Visible = testPanel.Visible = false;
            menuStrip1.Enabled = false;

            progressBar.Maximum = m_dtManager.TotalFileCount;
            progressBar.Step = 1;
            progressBar.Value = 0;
            statusLabel.Text = "Loading Data Set...";
            await Task.Run(() =>
            {
                m_dtManager.LoadFromDataDir();
            });

            statusLabel.Text = "Detected and loaded " + m_dtManager.TrainingImages.Count + " faces to database";

            menuStrip1.Enabled = true;
        }

        private async void singleSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            flowPanel.Visible = testPanel.Visible = false;

            double errorRate = await AutoTestSlice();
            statusLabel.Text = "Testing Concluded with " + errorRate.ToString("F2") + "% Error Rate.";
            menuStrip1.Enabled = true;
        }

        private Task<double> AutoTestSlice()
        {
            EigenFaceRecognizer eigenFaces = new EigenFaceRecognizer(Properties.Settings.Default.EigenfacesComponents, double.PositiveInfinity);
            m_dtManager.RandomizeTestSlice(Properties.Settings.Default.TestingCutSize);
            int numOfTestImg = m_dtManager.TestImageList.Count;
            progressBar.Maximum = numOfTestImg;
            progressBar.Value = 0;
            statusLabel.Text = "Running Automatic Test Slice...";

            return Task.Run(() =>
            {
                eigenFaces.Train(m_dtManager.TrainingImages.ToArray(), m_dtManager.TrainingLabels.ToArray());

                int numOfFails = 0;

                foreach (var testDat in m_dtManager.TestImageList)
                {
                    ProgressMadeEventHandler();
                    var res = eigenFaces.Predict(testDat.Item1);
                    if (res.Label != testDat.Item2)
                        ++numOfFails;
                }
                double errorRate = (double)numOfFails / (double)numOfTestImg;
                errorRate *= 100;

                return errorRate;
            });
        }

        private async void tripleSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            flowPanel.Visible = testPanel.Visible = false;

            int numOfIterations = Properties.Settings.Default.TestingIterations;
            double avgError = 0.0;

            for (int i = 0; i < numOfIterations; i++)
            {
                avgError += await AutoTestSlice();
            }

            avgError /= (double)numOfIterations;

            statusLabel.Text = "Testing Concluded with " + avgError.ToString("F2") + "% Avrage Error Rate.";
            menuStrip1.Enabled = true;
        }

        private async void manualTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            await PrepareForManualTesting();
            flowPanel.Visible = testPanel.Visible = true;
            menuStrip1.Enabled = true;
        }

        private async Task PrepareForManualTesting()
        {
            statusLabel.Text = "Setting Up Manual Test environment...";
            ResetEigenFaces();
            m_dtManager.RandomizeTestSlice(Properties.Settings.Default.TestingCutSize);

            await Task.Run(() =>
            {
                m_eigenFace.Train(m_dtManager.TrainingImages.ToArray(), m_dtManager.TrainingLabels.ToArray());
            });
            foreach (var currDat in m_dtManager.TestImageList)
            {
                var currCopy = currDat.Item1.Resize(50, 50, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
                var pb = new PictureBox();
                pb.Size = currCopy.Size;
                pb.Image = currCopy.Bitmap;
                pb.Tag = currDat;
                pb.DoubleClick += pb_DoubleClick;
                flowPanel.Controls.Add(pb);
            }
            statusLabel.Text = "Done!";
        }

        void pb_DoubleClick(object sender, EventArgs e)
        {
            PictureBox pb = ((PictureBox)sender);
            var testData = (Tuple<Image<Gray, Byte>, int>)pb.Tag;
            testPb.Image = testData.Item1.Bitmap;
            var testImg = testData.Item1;
            int testLabel = testData.Item2;

            var result = m_eigenFace.Predict(testImg);

            if (testLabel == result.Label)
                resLabel.ForeColor = Color.DarkGreen;
            else
                resLabel.ForeColor = Color.DarkRed;

            resLabel.Text = m_dtManager.GetLabel(result.Label);
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_cfgForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                statusLabel.Text = "Some Configuration changes may require the data set to be reloaded.";
        }
    }
}
