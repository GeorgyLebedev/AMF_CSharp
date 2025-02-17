using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities
{
    public class Benchmark
    {
        private Stopwatch stopwatch;
        private Label elapsedLabel;
        private Guna2Button blockedButton;
        public Benchmark(Label label, Guna2Button button) { 
            elapsedLabel = label;
            blockedButton = button;
            stopwatch = new Stopwatch();
        }

        public void begin()
        {
            elapsedLabel.Visible = false;
            elapsedLabel.Text = "";
            blockedButton.Enabled = false;
            stopwatch.Start();
        }

        public void end()
        {
            stopwatch.Stop();
            elapsedLabel.Visible = true;
            elapsedLabel.Text = stopwatch.Elapsed.TotalSeconds.ToString("F3") + "s";
            blockedButton.Enabled = true;   
        }
    }
}
