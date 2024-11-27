using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public byte width;
        public byte height;
        public Form2()
        {
            InitializeComponent();
        }

        private void validateInput(object sender, EventArgs e)
        {
            AcceptBtn.Enabled = true;
            try
            {
                height = Convert.ToByte(maskHeightInput.Text);
                width = Convert.ToByte(maskWidthInput.Text);
                if (height < 3 || height % 2 == 0 || width < 3 || width % 2 == 0)
                {
                    AcceptBtn.Enabled = false;
                }
            }
            catch {
                AcceptBtn.Enabled = false;
            }
            
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            width = Convert.ToByte(maskWidthInput.Text);
            height = Convert.ToByte(maskHeightInput.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
