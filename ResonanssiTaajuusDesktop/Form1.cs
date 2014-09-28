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
            trackBar1.ValueChanged += 
			new System.EventHandler(TrackBar1_ValueChanged);
		    this.Controls.Add(this.trackBar1);
            chart1.Series["Series1"].ChartType = 
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            int i = trackBar1.Minimum;
            int tick = trackBar1.TickFrequency;
            while(i <= trackBar1.Maximum)
            {
                chart1.Series["Series1"].Points.AddXY(i, 0);
                i = i + tick;
            }
        }


        // Handle the TrackBar.ValueChanged event by calculating a value for 
        // TextBox1 based on the TrackBar value.   
        private void TrackBar1_ValueChanged(object sender, System.EventArgs e)
        {
            Int16 freqVal = (Int16)trackBar1.Value;
            double currentI = calculate_current((double)freqVal);
            //TextBox1.Text = (System.Math.Round(TrackBar1.Value / 10.0)).ToString();
            chart1.Series["Series1"].Points.AddXY(freqVal, currentI);
            textBox1.Text = "" + freqVal;
            textBox2.Text = "" + currentI;
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
                (
                (omega * indL) -
                (1 / (double)((decimal)omega * capC)))
                , 2));
            return currentI;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void draw_graph(Int16 selectedValue)
        {
            chart1.Series["Series1"].Points.AddXY("test", selectedValue);
        }
    }
}
