using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;

namespace AgeEstimation
{
    class FaceDetector
    {
        static CascadeClassifier face = new CascadeClassifier(@"..\..\config\haarcascade_frontalface_default.xml");
        static public Image<Gray, Byte> CropGrayFace(Image<Bgr, Byte> image)
        {
            Image<Gray, Byte> gray = image.Convert<Gray, Byte>(); //Convert it to Grayscale

            //normalizes brightness and increases contrast of the image
            gray._EqualizeHist();

            Rectangle[] facesDetected = face.DetectMultiScale(gray, 1.2, 10, new Size(200, 200), new Size(320, 320));

            if (facesDetected.Length == 0)
                return null;

            Rectangle face_rect = facesDetected[0];
            //crop the first face found
            // resizing to 100x100 gives better performance
            int faceSize = Properties.Settings.Default.EigenFaceSize;
            return gray.Copy(face_rect).Resize(faceSize, faceSize, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
        }
    }
}
