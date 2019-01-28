using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualLine
{
    public partial class LineForm : Form
    {
        public LineForm()
        {
            InitializeComponent();
            //this.LineChart;
        }
        public void SetData(double[,] array)
        {
            LineChart.Series.Clear();
            LineChart.Series.Add("debug");
            LineChart.Series["debug"].SetDefault(true);
            LineChart.Series["debug"].Enabled = true;
            LineChart.Series["debug"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            LineChart.Series["debug"].Color = Color.DarkMagenta;
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                LineChart.Series["debug"].Points.AddXY(array[i, 0], array[i, 1]);
            }
        }
    }
}
