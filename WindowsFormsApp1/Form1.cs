using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        MaskSize maskSize = new MaskSize(5, 5);
   
        Bitmap image;
        Bitmap processedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void openImageClick(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ImageLoader loader = new ImageLoader(openFileDialog.FileName);
                    image = loader.Load();
                    inputPictureBox.Image = image;
                    inputPictureBox.Invalidate();
                    outputPictureBox.Image = null;
                    filterBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка открытия файла:\n\n {ex.Message}\n\n");
                }
            }
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elapsedLabel.Text = "";
                filterBtn.Enabled = false;
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                /////////////////
                /////////////////
                bool isNeedRotate = image.Width < image.Height;
                if (isNeedRotate)
                {
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                byte replaceLimit = (byte)replaceLimitInput.Value;
                int minLineLength = (int)lineLengthInput.Value;
                MedianFilter filter = new MedianFilter(new Bitmap(inputPictureBox.Image), replaceLimit, maskSize, minLineLength);
                filter.doFiltration(progressBar);
                processedImage = filter.getResultImage();
                outputPictureBox.Image = processedImage;
                resetImgBtn.Visible = true;
                if (isNeedRotate)
                {
                    processedImage.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                inputPictureBox.Invalidate();
                outputPictureBox.Invalidate();
                /////////////////
                /////////////////
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                elapsedLabel.Text = ts.TotalSeconds.ToString("F5") + "s";

                filterBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                 MessageBox.Show($"Ошибка обработки изображения:\n\n {ex.Message}\n\n");
            }
        }

        private void resetButtonsStyle()
        {
            button5x5.Enabled = true;
            button7x7.Enabled = true;
            button9x9.Enabled = true;
            button11x11.Enabled = true;
            button13x13.Enabled = true;
            button5x5.FlatAppearance.BorderSize = 0;
            button7x7.FlatAppearance.BorderSize = 0;
            button9x9.FlatAppearance.BorderSize = 0;
            button11x11.FlatAppearance.BorderSize = 0;
            button13x13.FlatAppearance.BorderSize = 0;
        }

        private void setMaskSize(object sender, EventArgs e)
        {
            resetButtonsStyle();
            Button button = (Button)sender;
            string sizeStr = button.Name.Substring(button.Name.IndexOf("x") + 1);
            byte size = Convert.ToByte(sizeStr);
            maskSize =  new MaskSize(size, size);
            groupBox1.Text = "Тип маски:" + size + " X " + size;
            button.Enabled = false;
            button.FlatAppearance.BorderSize = 3;
        }

        private void resetImgBtn_Click(object sender, EventArgs e)
        {
            outputPictureBox.Image = null;
            processedImage = null;
            resetImgBtn.Visible = false;
        }
    }
}
