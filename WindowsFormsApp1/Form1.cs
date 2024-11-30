using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ImageManager imageManager;
        public Form1()
        {
            InitializeComponent();
            maskSizeComboBox.SelectedIndex = 0;
            imageManager = new ImageManager(openFileDialog, saveFileDialog, inputPictureBox, outputPictureBox);
        }

        private void openImageClick(object sender, EventArgs e)
        {
            imageManager.openImage();
            filterBtn.Enabled = true;
        }

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Benchmark benchmark = new Benchmark(elapsedLabel, filterBtn);
                benchmark.begin();

                swapPanel(true);
                imageManager.rotateBeforeProcessing();

                MedianFilter medianFilter = createFilter();
                imageManager.setOutputImage(await medianFilter.doFiltration());

                swapPanel(false);
                imageManager.rotateAfterProcessing();

                benchmark.end();
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

        private void swapPanel(bool isProcessing)
        {
            if (isProcessing)
            {
                tableLayoutPanel1.Controls.Remove(outputPictureBox);
                tableLayoutPanel1.Controls.Add(progressBar, 1, 0);
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(progressBar);
                tableLayoutPanel1.Controls.Add(outputPictureBox, 1, 0);
            }
        }

        private void saveAsButtonClick(object sender, EventArgs e)
        {
            imageManager.dialogSaveOutputImage();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            imageManager.saveOutputImage();
        }

        private void inputPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openImageClick(sender,e);
            }
            if (e.Button == MouseButtons.Right)
            {
                imageManager.rotateInputImg();
            }
        }

        private void outputPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                saveAsButtonClick(sender, e);
            }
            if (e.Button == MouseButtons.Right)
            {
                imageManager.rotateOutputImg();
            }
        }
    }
}
