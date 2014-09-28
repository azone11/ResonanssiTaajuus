using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ResonanssiTaajuusDesktop
{
    public partial class Form1 : Form
    {
        //private System.Windows.Forms.TrackBar trackBar1;

        public Form1()
        {
            InitializeComponent();
            trackBarFreq.ValueChanged += 
			new System.EventHandler(TrackBar1_ValueChanged);
		    this.Controls.Add(this.trackBarFreq);
            chart1.Series[0].ChartType = 
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            chart1.Series[0].Name = "I(f)";
            InitChart(trackBarFreq.Minimum, trackBarFreq.Maximum, trackBarFreq.TickFrequency);
        }

        private void InitChart(int min, int max, int tick)
        {
            int i = min;
            chart1.Series[0].Color = Color.Transparent;
            while (i <= max)
            {
                chart1.Series[0].Points.AddXY(i, 0);
                i = i + tick;
            }
        }

        // Handle the trackBarFreq.ValueChanged event   
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            Int16 freqVal = (Int16)trackBarFreq.Value;
            double currentI = calculate_current((double)freqVal);
            chart1.Series[0].Color = Color.Blue; // Restore chart color
            chart1.Series[0].Points.AddXY(freqVal, currentI);
            textBoxFreq.Text = "taajuus " + freqVal + " Hz";
            textBoxAmper.Text = "virta " + Math.Round(currentI, 3) + " A";
        }

        private double calculate_current(double freq)
        {
            double currentI = 0;
            double voltU = 20;
            double resR = 40;
            decimal capC = 5m / 1000000m;
            double indL = 0.002;
            double omega = 2 * Math.PI * freq;

            currentI = voltU / Math.Sqrt(
                Math.Pow(resR, 2) + 
                Math.Pow(
                ((omega * indL) -
                (1 / (double)((decimal)omega * capC))), 2));
            return currentI;
        }

        private void draw_graph(Int16 selectedValue)
        {
            chart1.Series[0].Points.AddXY("test", selectedValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            emptyGraph();
            trackBarFreq.Value = trackBarFreq.Minimum;
            //InitChart(trackBarFreq.Minimum, trackBarFreq.Maximum, trackBarFreq.TickFrequency);
        }

        private void emptyGraph()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
