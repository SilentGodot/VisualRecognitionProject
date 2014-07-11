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
        public AgeEstimator()
        {
            InitializeComponent();

            m_dtManager = new DataSetManager(@"..\..\DataSet");
            m_dtManager.ImageFileProccessedEvent += ProgressMadeEventHandler;

            ResetEigenFaces();
        }

        private void ResetEigenFaces()
        {
            m_eigenFace = new EigenFaceRecognizer(100, double.PositiveInfinity);
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

            progressBar.Maximum = m_dtManager.TotalFileCount;
            progressBar.Step = 1;
            progressBar.Value = 0;
            statusLabel.Text = "Loading Data Set...";
            await Task.Run(() =>
            {
                m_dtManager.LoadFromDataDir();
            });

            statusLabel.Text = "Detected and loaded " + m_dtManager.TrainingImages.Count + " faces to database";

            //foreach (var currImg in m_dtManager.TrainingImages)
            //{
            //    var currCopy = currImg.Resize(50, 50, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR);
            //    var pb = new PictureBox();
            //    pb.Size = currCopy.Size;
            //    pb.Image = currCopy.Bitmap;
            //    flowPanel.Controls.Add(pb);
            //}
        }

        private async void singleSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double errorRate = await AutoTestSlice();
            statusLabel.Text = "Testing Concluded with " + errorRate.ToString("F2") + "% Error Rate.";
        }

        private Task<double> AutoTestSlice()
        {
            ResetEigenFaces();
            m_dtManager.RandomizeTestSlice();
            int numOfTestImg = m_dtManager.TestImageList.Count;
            progressBar.Maximum = numOfTestImg;
            progressBar.Value = 0;
            statusLabel.Text = "Running Automatic Test Slice...";

            return Task.Run(() =>
            {
                m_eigenFace.Train(m_dtManager.TrainingImages.ToArray(), m_dtManager.TrainingLabels.ToArray());

                int numOfFails = 0;

                foreach (var testDat in m_dtManager.TestImageList)
                {
                    ProgressMadeEventHandler();
                    var res = m_eigenFace.Predict(testDat.Item1);
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
            int numOfIterations = 3;
            double avgError = 0.0;

            for (int i = 0; i < numOfIterations; i++)
            {
                avgError += await AutoTestSlice();
            }

            avgError /= (double)numOfIterations;

            statusLabel.Text = "Testing Concluded with " + avgError.ToString("F2") + "% Avrage Error Rate.";
        }

        private async void manualTestingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await PrepareForManualTesting();
            flowPanel.Visible = testPanel.Visible = true;
        }

        private async Task PrepareForManualTesting()
        {
            statusLabel.Text = "Setting Up Manual Test environment...";
            ResetEigenFaces();
            m_dtManager.RandomizeTestSlice();

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
    }
}
