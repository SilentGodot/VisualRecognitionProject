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
    public partial class Form1 : Form
    {
        private FaceDetector m_faceDetector;
        private string m_facePath;
        public Form1()
        {
            InitializeComponent();

            m_faceDetector = new FaceDetector();
            m_facePath = @"..\..\DataSet\Color_age_30-49_Neutral_bmp\male\TSFWmale47neutral(2).bmp";
            pictureBox1.ImageLocation = m_facePath;
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ImgToCrop = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, Byte>(m_facePath);
            var faceImg = m_faceDetector.CropGrayFace(ImgToCrop);
            Bitmap bmFace = faceImg.ToBitmap();
            pictureBox1.Image = bmFace;
        }
    }
}
