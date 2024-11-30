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
        private bool isNeedRotate;

        public ImageManager(OpenFileDialog openDialog, SaveFileDialog saveDialog, PictureBox inputPictureBox, PictureBox outputPictureBox)
        {
            dialogs = new Dialogs(openDialog, saveDialog);
            input = new Picture(inputPictureBox);
            output = new Picture(outputPictureBox);
        }

        public void setOutputImage(Bitmap outputImage)
        {
            output.setImg(outputImage);
        }

        public void rotateBeforeProcessing()
        {
            isNeedRotate = input.isVertical;
            if (isNeedRotate)
            {
                input.RotateByOrientation(false);
            }
        }

        public void rotateAfterProcessing()
        {
            if (isNeedRotate)
            {
                input.RotateByOrientation(true);
                output.RotateByOrientation(true);
            }
        }

        public void rotateInputImg()
        {
            input.rotate90();
        }

        public void rotateOutputImg()
        {
            output.rotate90();
        }

        public void openImage()
        {
            if (dialogs.open.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            try
            {
                input.firstSetImg(new Bitmap(dialogs.open.FileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка открытия файла:\n\n {ex.Message}\n\n");
            }
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
