using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities
{
    public class Benchmark
    {
        Stopwatch stopwatch;
        Label elapsedLabel;
        Guna2Button blockedButton;
        public Benchmark(Label label, Guna2Button button) { 
            elapsedLabel = label;
            blockedButton = button;
            stopwatch = new Stopwatch();
        }

        public void begin()
        {
            elapsedLabel.Text = "";
            blockedButton.Enabled = false;
            stopwatch.Start();
        }

        public void end()
        {
            stopwatch.Stop();
            elapsedLabel.Text = stopwatch.Elapsed.TotalSeconds.ToString("F5") + "s";
            blockedButton.Enabled = true;   
        }
    }
}
