using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using WindowsFormsApp1.entities;

namespace WindowsFormsApp1
{
    internal class Dialogs
    {
        public readonly OpenFileDialog open;
        public readonly SaveFileDialog save;
        public Dialogs(OpenFileDialog openDialog, SaveFileDialog saveDialog)
        {
            open = openDialog;
            save = saveDialog;
        }
    }

 
    public class ImageManager
    {
        private Dialogs dialogs;
        private Picture input;
        private Picture output;
        private bool imageRotated = false;
        private bool imageLoaded = false;

        public ImageManager(OpenFileDialog openDialog, SaveFileDialog saveDialog, PictureBox inputPictureBox, PictureBox outputPictureBox)
        {
            dialogs = new Dialogs(openDialog, saveDialog);
            input = new Picture(inputPictureBox);
            output = new Picture(outputPictureBox);
        }

        public bool isLoaded()
        {
            return imageLoaded;
        }

        public void setOutputImage(Bitmap outputImage)
        {
            output.setImg(outputImage);
        }

        public void rotateImages()
        {
            bool shouldRotate = input.isVertical || imageRotated;
            if (!shouldRotate)
            {
                return;
            }
            bool rotateClockwise = !imageRotated;

            input.RotateByOrientation(rotateClockwise);
            output.RotateByOrientation(rotateClockwise);
            imageRotated = !imageRotated;
        }

        public void rotateInputImg()
        {
            input.rotate90();
        }

        public void rotateOutputImg()
        {
            output.rotate90();
        }

        public bool openImage()
        {
            imageLoaded = false;
            try
            {
                if (dialogs.open.ShowDialog() == DialogResult.OK)
                {
                    input.setImg(new Bitmap(dialogs.open.FileName), true);
                    imageLoaded = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия файла:\n\n {ex.Message}\n\n");
            }
            return imageLoaded;
        }

        public void saveOutputImage()
        {
            ImageFormat imageFormat = getImageFormat(dialogs.open);
            output.save(dialogs.open.FileName, imageFormat);
        }

        public void dialogSaveOutputImage()
        {
            if (dialogs.save.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            try
            {
                ImageFormat imageFormat = getImageFormat(dialogs.save);
                output.save(dialogs.save.FileName, imageFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения файла:\n\n {ex.Message}\n\n");
            }
        }

        private ImageFormat getImageFormat(FileDialog dialog)
        {
            string fileExtension = System.IO.Path.GetExtension(dialog.FileName).ToLower();
            ImageFormat imageFormat;
            if (fileExtension == ".png")
            {
                imageFormat = ImageFormat.Png;
            }
            else if (fileExtension == ".jpg")
            {
                imageFormat = ImageFormat.Jpeg;
            }
            else
            {
                imageFormat = ImageFormat.Bmp;
            }
            return imageFormat;
        }
    }
}
