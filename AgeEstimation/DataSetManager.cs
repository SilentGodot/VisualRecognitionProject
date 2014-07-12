using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Emgu.CV;
using Emgu.CV.Structure;

namespace AgeEstimation
{
    public static class Utilities
    {
        public static void Shuffle<T>(this IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }

    public delegate void ImageFileProccessed(); // event to report progress

    /// <summary>
    /// Class that manages the image data set.
    /// Loads the image files and runs a face detection using a HaarCascade to preprocess for EigenFaces.
    /// Fuctionality to randomize Test slicr from main data set
    /// </summary>
    class DataSetManager
    {
        private List<Tuple<Image<Gray, Byte>, int>> m_trainingImages;
        private List<Tuple<Image<Gray, Byte>, int>> m_testImages;
        private List<String> m_labels;

        public event ImageFileProccessed ImageFileProccessedEvent;
        public string DirectoryPath { get; private set; }
        public DataSetManager(string dataSetDir)
        {
            m_trainingImages = new List<Tuple<Image<Gray, byte>, int>>();
            m_testImages = new List<Tuple<Image<Gray, byte>, int>>();
            m_labels = new List<string>();
            DirectoryPath = dataSetDir;
        }

        public List<Image<Gray, Byte>> TrainingImages
        {
            get
            {
                var imgList = new List<Image<Gray, Byte>>(m_trainingImages.Count);
                foreach(var currTup in m_trainingImages)
                {
                    imgList.Add(currTup.Item1);
                }
                return imgList;
            }
        }

        public List<int> TrainingLabels
        {
            get
            {
                var lblList = new List<int>(m_trainingImages.Count);
                foreach (var currTup in m_trainingImages)
                {
                    lblList.Add(currTup.Item2);
                }
                return lblList;
            }
        }

        public List<Tuple<Image<Gray, Byte>, int>> TestImageList
        {
            get
            {
                return m_testImages;
            }
        }

        private int LabelToInt(String labelStr)
        {
            if (!m_labels.Contains(labelStr))
            {
                m_labels.Add(labelStr);
            }
            return m_labels.IndexOf(labelStr);
        }

        public String GetLabel(int index)
        {
            if (index == -1 || m_labels.Count <= index)
            {
                return "Unknown";
            }

            return m_labels[index];
        }

        public int TotalFileCount
        {
            get
            {

                DirectoryInfo dataDir = new DirectoryInfo(DirectoryPath);
                return dataDir.GetFiles("*.bmp", SearchOption.AllDirectories).Length;
            }
        }

        public void LoadFromDataDir()
        {
            m_trainingImages.Clear();
            
            DirectoryInfo dataDir = new DirectoryInfo(DirectoryPath);
            foreach (DirectoryInfo currDir in dataDir.GetDirectories())
            {
                LoadAgeDir(currDir);
            }
        }

        private void LoadAgeDir(DirectoryInfo dir)
        {
            string ageLabel = dir.Name.Replace('_', ' ');

            foreach (DirectoryInfo currGenderDir in dir.GetDirectories())
            {
                string genderLabel = currGenderDir.Name;

                foreach (FileInfo currImgFile in currGenderDir.GetFiles("*.bmp"))
                {
                    ImageFileProccessedEvent();
                    var rgbImg = new Image<Bgr, Byte>(currImgFile.FullName);
                    Image<Gray, Byte> grayFace;
                    
                    grayFace = FaceDetector.CropGrayFace(rgbImg);
                    if (grayFace == null)
                    {
                        continue; //Fix face dtection failing
                    }
                    String fullLabel = ageLabel + " " + genderLabel;

                    int labelIndex = LabelToInt(fullLabel);

                    var tup = new Tuple<Image<Gray, byte>, int>(grayFace, labelIndex);
                    m_trainingImages.Add(tup);
                }
            }
        }

        public void RandomizeTestSlice(float slicePrecent = 15.0f)
        {
            m_trainingImages.AddRange(m_testImages);
            m_testImages.Clear();

            int numOfTestImg = (int)Math.Round((double)(m_trainingImages.Count) * ((double)slicePrecent) / 100.0);

            // randomize orger and get the first few to testing lists
            m_trainingImages.Shuffle();
            m_testImages.AddRange(m_trainingImages.GetRange(0, numOfTestImg));
            m_trainingImages.RemoveRange(0, numOfTestImg);
        }


    }
}
