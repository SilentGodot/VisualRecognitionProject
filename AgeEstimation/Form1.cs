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
    public partial class Form1 : Form
    {
        DataSetManager m_dtManager;
        EigenFaceRecognizer m_eigenFace;
        public Form1()
        {
            InitializeComponent();

            m_dtManager = new DataSetManager(@"..\..\DataSet");
            m_dtManager.ImageFileProccessedEvent += ProgressMadeEventHandler;

            m_eigenFace = new EigenFaceRecognizer(0, double.PositiveInfinity);
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

            if (progressBar.Value == progressBar.Maximum)
                if (statusLabel.InvokeRequired)
                    statusLabel.Invoke(new ThreadStart(() =>
                    {
                        statusLabel.Text = "Done!";
                    }));
                else
                    statusLabel.Text = "Done!";
        }

        private void loadDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            progressBar.Maximum = m_dtManager.TotalFileCount;
            progressBar.Step = 1;
            statusLabel.Text = "Loading Data Set...";
            new Thread(new ThreadStart(() =>
            {
                m_dtManager.LoadFromDataDir();
            })).Start();
        }

        private void singleSliceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double errorRate = AutoTestSlice();
            statusLabel.Text = "Testing Concluded with " + errorRate.ToString("F2") + "% Error Rate.";
        }

        private double AutoTestSlice()
        {
            m_dtManager.RandomizeTestSlice();
            m_eigenFace.Train(m_dtManager.TrainingImages.ToArray(), m_dtManager.TrainingLabels.ToArray());

            int numOfFails = 0;
            int numOfTestImg = m_dtManager.TestImageList.Count;

            progressBar.Maximum = numOfTestImg;
            statusLabel.Text = "Testing...";

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
        }
    }
}
