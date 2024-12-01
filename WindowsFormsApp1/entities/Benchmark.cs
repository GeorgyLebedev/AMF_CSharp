using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsFormsApp1.entities
{
    public class Benchmark
    {
        Stopwatch stopwatch;
        Label elapsedLabel;
        public Benchmark(Label label) { 
            elapsedLabel = label;
            stopwatch = new Stopwatch();
        }

        public void begin()
        {
            elapsedLabel.Text = "";
            stopwatch.Start();
        }

        public void end()
        {
            stopwatch.Stop();
            elapsedLabel.Text = stopwatch.Elapsed.TotalSeconds.ToString("F5") + "s";
        }
    }
}
