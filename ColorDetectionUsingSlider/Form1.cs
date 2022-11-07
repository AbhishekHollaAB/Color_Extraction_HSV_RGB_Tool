using System;
using System.Drawing;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ColorDetectionUsingSlider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Mat imgInput = new Mat();
        Mat imgInputCopy = new Mat();
        Mat imgBrowse = new Mat();

        int bVal = 0, gVal = 0, rVal = 0;

        OpenCvSharp.Point pointerLocation;

        bool isPick = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            imgInput = new Mat(1000, 1000, MatType.CV_8UC1, new Scalar(0));
            Cv2.CvtColor(imgInput, imgInput, ColorConversionCodes.GRAY2BGR);
            pb_colorDisplay.Image = imgInput.ToBitmap();
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            imgBrowse = new Mat(openFileDialog1.FileName);
            pictureBox1.Image = imgBrowse.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_pickColor_Click(object sender, EventArgs e)
        {
            isPick = true;
        }

        private void testRange()
        {
            imgInputCopy = new Mat(openFileDialog1.FileName);
            Mat hsvImg = new Mat();
            Cv2.CvtColor(imgInputCopy, hsvImg, ColorConversionCodes.BGR2HSV);
            Scalar lowerValRange = new Scalar(tBar_HueLow.Value, tBar_saturationLow.Value, tBar_valueLow.Value);
            Scalar higherValRange = new Scalar(tBar_HueHigh.Value, tBar_saturationHigh.Value, tBar_valueHigh.Value);
            Mat mask = new Mat();
            Cv2.InRange(hsvImg, lowerValRange, higherValRange, mask);
            Mat result = new Mat();
            Cv2.BitwiseAnd(imgInputCopy, imgInputCopy, result, mask);
            pictureBox1.Image = result.ToBitmap();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPick)
            {
                isPick = false;
                double scaleX = (double)imgBrowse.Width / pictureBox1.Size.Width;
                double scaleY = (double)imgBrowse.Height / pictureBox1.Size.Height;
                int tx = (int)(e.X * scaleX);
                int ty = (int)(e.Y * scaleY);
                pointerLocation = new OpenCvSharp.Point(tx, ty);
                Bitmap imgToConvert = imgBrowse.ToBitmap();
                Color clrAtPoint = imgToConvert.GetPixel(pointerLocation.X, pointerLocation.Y);
                int bluePx = clrAtPoint.B;
                int greenPx = clrAtPoint.G;
                int redPx = clrAtPoint.R;
                lbl_bgrPicked.Text = "(" + bluePx.ToString() + ", " + greenPx.ToString() + ", " + redPx.ToString() + ")";
                tb_blue.Text = bluePx.ToString();
                tb_green.Text = greenPx.ToString();
                tb_red.Text = redPx.ToString();
            }
        }

        private void setColor()
        {
            bVal = tBar_Blue.Value;
            gVal = tBar_Green.Value;
            rVal = tBar_Red.Value;

            imgInput = new Mat(1000, 1000, MatType.CV_8UC3, new Scalar(bVal, gVal, rVal));
            pb_colorDisplay.Image = imgInput.ToBitmap();

            Color colorToConvert = Color.FromArgb(rVal, gVal, bVal);
            int max = Math.Max(colorToConvert.R, Math.Max(colorToConvert.G, colorToConvert.B));
            int min = Math.Min(colorToConvert.R, Math.Min(colorToConvert.G, colorToConvert.B));

            double hue = colorToConvert.GetHue();
            double saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            double value = max / 255.0;

            int finalHue = Convert.ToInt32(hue / 2);
            int finalSaturation = Convert.ToInt32(saturation * 255);
            int finalValue = Convert.ToInt32(value * 255);

            tb_cHue.Text = finalHue.ToString();
            tb_cSaturation.Text = finalSaturation.ToString();
            tb_cValue.Text = finalValue.ToString();
        }

        private void tBar_Blue_Scroll(object sender, EventArgs e)
        {
            tb_blue.Text = tBar_Blue.Value.ToString();
            setColor();
        }

        private void tBar_Green_Scroll(object sender, EventArgs e)
        {
            tb_green.Text = tBar_Green.Value.ToString();
            setColor();
        }

        private void tBar_Red_Scroll(object sender, EventArgs e)
        {
            tb_red.Text = tBar_Red.Value.ToString();
            setColor();
        }

        private void tb_blue_TextChanged(object sender, EventArgs e)
        {
            tBar_Blue.Value = int.Parse(tb_blue.Text);
            setColor();
        }

        private void tb_green_TextChanged(object sender, EventArgs e)
        {
            tBar_Green.Value = int.Parse(tb_green.Text);
            setColor();
        }

        private void tb_red_TextChanged(object sender, EventArgs e)
        {
            tBar_Red.Value = int.Parse(tb_red.Text);
            setColor();
        }

        private void tBar_HueLow_Scroll(object sender, EventArgs e)
        {
            tb_huelow.Text = tBar_HueLow.Value.ToString();
            testRange();
        }

        private void tBar_saturationLow_Scroll(object sender, EventArgs e)
        {
            tb_saturationlow.Text = tBar_saturationLow.Value.ToString();
            testRange();
        }

        private void tBar_valueLow_Scroll(object sender, EventArgs e)
        {
            tb_valuelow.Text = tBar_valueLow.Value.ToString();
            testRange();
        }

        private void tBar_HueHigh_Scroll(object sender, EventArgs e)
        {
            tb_huehigh.Text = tBar_HueHigh.Value.ToString();
            testRange();
        }

        private void tBar_saturationHigh_Scroll(object sender, EventArgs e)
        {
            tb_saturationhigh.Text = tBar_saturationHigh.Value.ToString();
            testRange();
        }

        private void tBar_valueHigh_Scroll(object sender, EventArgs e)
        {
            tb_valuehigh.Text = tBar_valueHigh.Value.ToString();
            testRange();
        }

        private void tb_huelow_TextChanged(object sender, EventArgs e)
        {
            tBar_HueLow.Value = int.Parse(tb_huelow.Text);
            testRange();
        }

        private void tb_saturationlow_TextChanged(object sender, EventArgs e)
        {
            tBar_saturationLow.Value = int.Parse(tb_saturationlow.Text);
            testRange();
        }

        private void tb_valuelow_TextChanged(object sender, EventArgs e)
        {
            tBar_valueLow.Value = int.Parse(tb_valuelow.Text);
            testRange();
        }

        private void tb_huehigh_TextChanged(object sender, EventArgs e)
        {
            tBar_HueHigh.Value = int.Parse(tb_huehigh.Text);
            testRange();
        }

        private void tb_saturationhigh_TextChanged(object sender, EventArgs e)
        {
            tBar_saturationHigh.Value = int.Parse(tb_saturationhigh.Text);
            testRange();
        }

        private void tb_valuehigh_TextChanged(object sender, EventArgs e)
        {
            tBar_valueHigh.Value = int.Parse(tb_valuehigh.Text);
            testRange();
        }
    }
}
