using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;
using WindowsFormsApp1.types;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
   
        Bitmap image;
        Bitmap processedImage;
        PictureBox outputPictureBox = null;
        public Form1()
        {
            InitializeComponent();
            maskSizeComboBox.SelectedIndex = 0;
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
                    filterBtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка открытия файла:\n\n {ex.Message}\n\n");
                }
            }
        }

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                elapsedLabel.Text = "";
                filterBtn.Enabled = false;
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();
                /////////////////
                /////////////////
                if (outputPictureBox != null)
                {
                    tableLayoutPanel1.Controls.Remove(outputPictureBox);
                    outputPictureBox = null;
                }
                tableLayoutPanel1.Controls.Add(progressBar, 1, 0);
                bool isNeedRotate = image.Width < image.Height;
                if (isNeedRotate)
                {
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                }
                MedianFilter medianFilter = createFilter();
                processedImage = await medianFilter.doFiltration();
                outputPictureBox = createOutputPictureBox();
                tableLayoutPanel1.Controls.Remove(progressBar);
                tableLayoutPanel1.Controls.Add(outputPictureBox, 1, 0);
                outputPictureBox.Image = processedImage;
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

        private MedianFilter createFilter()
        {
            byte replaceLimit = (byte)minBrightness.Value;
            int minLineLength = (int)lineLengthInput.Value;
            MedianFilter filter = new MedianFilter(new Bitmap(inputPictureBox.Image), replaceLimit, getMaskSize(), minLineLength);
            filter.setProgressBar(progressBar);
            return filter;
        }

        private PictureBox createOutputPictureBox()
        {
            PictureBox outputPictureBox = new PictureBox();
            outputPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            outputPictureBox.BackColor = SystemColors.ControlLight;
            outputPictureBox.Location = new Point(512, 6);
            outputPictureBox.Margin = new Padding(5, 5, 10, 5);
            outputPictureBox.Name = "outputPictureBox";
            outputPictureBox.Size = new Size(491, 458);
            outputPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            outputPictureBox.TabIndex = 1;
            outputPictureBox.TabStop = false;
            return outputPictureBox;
        }

        private MaskSize getMaskSize()
        {
            string value;
            if (preSizeRadio.Checked)
            {
                value = maskSizeComboBox.SelectedItem.ToString();
            }
            else
            {
                value = maskSizeTextBox.Text;
            }
            string[] sizeStr = value.Split('x');
            byte width = Convert.ToByte(sizeStr[0]);
            byte heigth = Convert.ToByte(sizeStr[1]);
            return  new MaskSize(width, heigth);
        }

        private void preSizeRadio_Click(object sender, EventArgs e)
        {
            preSizeRadio.Checked = true;
            ownSizeRadio.Checked = false;
            maskSizeComboBox.Enabled = true;
            maskSizeTextBox.Enabled = false;
        }

        private void ownSizeRadio_Click(object sender, EventArgs e)
        {
            var maskSizeForm = new Form2();
            if (maskSizeForm.ShowDialog() == DialogResult.OK)
            {
                byte maskWidth = maskSizeForm.width;
                byte maskHeight = maskSizeForm.height;
                maskSizeTextBox.Text = maskWidth + "x" + maskHeight;
                preSizeRadio.Checked = false;
                ownSizeRadio.Checked = true;
                maskSizeComboBox.Enabled = false;
                maskSizeTextBox.Enabled = true;
            }
        }
    }
}
