using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Drawing;
using System.Windows.Forms;

namespace Shy_Panda
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Camera();
            imagepicture.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public void Camera()
        {
            Capture capture = new Capture();
            capture.Start();
            var step = "0s";
            HaarCascade haareyes = new HaarCascade("haarcascade_eye.xml");
            capture.ImageGrabbed += (x, y) =>
            {
                var image = capture.RetrieveBgrFrame();
                if (image != null)
                {
                    var grayimage = image.Convert<Gray, byte>();

                    MCvAvgComp[][] eyes = grayimage.DetectHaarCascade(haareyes, 1.2, 10, HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(15, 15));
                    foreach (MCvAvgComp hEye in eyes[0])
                    {
                        image.Draw(hEye.rect, new Bgr(Color.Blue), 1);
                        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_COMPLEX, 0.3, 0.3);
                        image.Draw("Goz", ref font, new Point(hEye.rect.X, hEye.rect.Y), new Bgr(Color.Yellow));
                        imagepicture.LoadAsync("C:\\Users\\EysanGuc\\source\\repos\\ShyPanda\\ShyPanda\\Images\\pandautanan.png");
                        step = "1";
                    }
                }
                if (step != "1")
                {
                    imagepicture.LoadAsync("C:\\Users\\EysanGuc\\source\\repos\\ShyPanda\\ShyPanda\\Images\\panda.gif");
                }
                FaceImagepicture.Image = image.ToBitmap();
                step = "";
            };
        }
    }
}
