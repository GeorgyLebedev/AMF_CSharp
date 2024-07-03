using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var loader = new ImageLoader(openFileDialog1.FileName, progressBar1);
                    pictureBox1.Image = loader.Load();
                    pictureBox1.Invalidate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка открытия файла:\n\n {ex.Message}\n\n");
                }
            }
        }
    }
}
