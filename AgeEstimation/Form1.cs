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

namespace AgeEstimation
{
    public partial class Form1 : Form
    {
        DataSetManager m_dtManager;
        public Form1()
        {
            InitializeComponent();

            m_dtManager = new DataSetManager(@"..\..\DataSet");
            m_dtManager.ImageFileProccessedEvent += ImageFileProccessedEventHandler;
            progressBar.Maximum = m_dtManager.TotalFiles;
            progressBar.Step = 1;
        }

        void ImageFileProccessedEventHandler()
        {
            if (progressBar.InvokeRequired)
                progressBar.Invoke(new ThreadStart(() =>
                {
                    progressBar.PerformStep();
                }));
            else
                progressBar.PerformStep();

            if (progressBar.Value == progressBar.Maximum)
                if (progressLabel.InvokeRequired)
                    progressLabel.Invoke(new ThreadStart(() =>
                    {
                        progressLabel.Text = "Done!";
                    }));
                else
                    progressLabel.Text = "Done!";
        }

        private void loadDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            progressLabel.Text = "Loading Data Set...";
            new Thread(new ThreadStart(() =>
            {
                m_dtManager.LoadFromDataDir();
            })).Start();
        }
    }
}
