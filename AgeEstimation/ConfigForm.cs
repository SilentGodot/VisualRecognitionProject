using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeEstimation
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            txtFaceSize.Text = Properties.Settings.Default.EigenFaceSize.ToString();
            txtComponents.Text = Properties.Settings.Default.EigenfacesComponents.ToString();
            txtCutPrecent.Text = Properties.Settings.Default.TestingCutSize.ToString("F1");
            txtIterations.Text = Properties.Settings.Default.TestingIterations.ToString();
            cbGender.Checked = Properties.Settings.Default.EstimateGender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.EigenFaceSize = int.Parse(txtFaceSize.Text);
            Properties.Settings.Default.EigenfacesComponents = int.Parse(txtComponents.Text);
            Properties.Settings.Default.TestingCutSize = float.Parse(txtCutPrecent.Text);
            Properties.Settings.Default.TestingIterations = int.Parse(txtIterations.Text);
            Properties.Settings.Default.EstimateGender = cbGender.Checked;
            Properties.Settings.Default.Save();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
