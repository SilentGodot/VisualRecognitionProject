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
        public Image<Gray, Byte> CropGrayFace(Image<Bgr, Byte> image)
        {
             Image<Gray, Byte> gray = image.Convert<Gray, Byte>(); //Convert it to Grayscale

             //normalizes brightness and increases contrast of the image
             gray._EqualizeHist();

             //Read the HaarCascade objects
             HaarCascade face = new HaarCascade(@"..\..\config\haarcascade_frontalface_alt_tree.xml");

             //Detect the faces  from the gray scale image and store the locations as rectangle
             //The first dimensional is the channel
             //The second dimension is the index of the rectangle in the specific channel
             MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face, 
                1.1, 
                10, 
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, 
                new Size(20, 20));


            MCvAvgComp f = facesDetected[0][0];
            //crop the first face found
            return gray.Copy(f.rect);
        }
    }
}
