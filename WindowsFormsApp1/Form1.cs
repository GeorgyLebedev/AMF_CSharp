using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1.entities.medianFilterEnitites;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ImageManager imageManager;
        MaskDisplay maskDisplay;
        MaskType maskType;
        public Form1()
        {
            InitializeComponent();
            maskSizeComboBox.SelectedIndex = 0;
            maskTypeComboBox.SelectedIndex = 0;
            imageManager = new ImageManager(openFileDialog, saveFileDialog, inputPictureBox, outputPictureBox);
            maskType = new MaskType(getMaskSize(), getMaskTypeEnum());
            maskDisplay = new MaskDisplay(maskPictureBox, maskType);
            maskDisplay.update(maskType);
            elapsedLabel.Visible = false;
        }

        private void openImageClick(object sender, EventArgs e)
        {
            if (imageManager.openImage())
            {
                filterBtn.Enabled = true;
                saveButton.Enabled = false;
                saveAsButton.Enabled = false;
            }
        }

        private async void filterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Benchmark benchmark = new Benchmark(elapsedLabel, filterBtn);
                benchmark.begin();

                displayProgress(true);
                imageManager.rotateBeforeProcessing();

                MedianFilter medianFilter = createFilter();
                imageManager.setOutputImage(await medianFilter.doFiltration());

                displayProgress(false);
                imageManager.rotateAfterProcessing();

                benchmark.end();

                saveAsButton.Enabled = true;
                saveButton.Enabled = true;
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
            MedianFilter filter = new MedianFilter(new Bitmap(inputPictureBox.Image), replaceLimit, maskType, minLineLength);
            filter.setProgressBar(progressBar);
            return filter;
        }

        private MaskTypeEnum getMaskTypeEnum()
        {
           return (MaskTypeEnum)maskTypeComboBox.SelectedIndex;
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

            maskDisplay.update(maskType);
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
                maskType = new MaskType(getMaskSize(), getMaskTypeEnum());
                maskDisplay.update(maskType);
            }
        }

        private void displayProgress(bool isProcessing)
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
             DialogResult result = MessageBox.Show(
                  "Вы уверены, что хотите перезаписать исходный файл?",
                  "Подтверждение",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question,
                  MessageBoxDefaultButton.Button2);
            if(result == DialogResult.Yes)
            {
                imageManager.saveOutputImage();

            }
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

        private void maskSizeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            
            if (maskDisplay != null && maskType != null)
            {
                maskType = new MaskType(getMaskSize(), getMaskTypeEnum());  
                maskDisplay.update(maskType);
            }
        }

        private void maskTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
          
            if (maskDisplay != null && maskType != null)
            {
                maskType = new MaskType(getMaskSize(), getMaskTypeEnum());
                maskDisplay.update(maskType);
            }
        }

    }
}
