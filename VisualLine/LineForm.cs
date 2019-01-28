using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VisualLine
{
    public partial class LineForm : Form
    {
        public LineForm()
        {
            InitializeComponent();
            ChartTypeList.Items.Clear();
            LineChart.Series.Clear();
            foreach (string typeName in Enum.GetNames(typeof(SeriesChartType)))
            {
                ChartTypeList.Items.Add(typeName);
            }
            ChartTypeList.SelectedItem = "Point";
        }

        public void SetData(double[,] array)
        {
            LineChart.Series.Add("debug");
            //LineChart.Series.Add("debug_approx");
            LineChart.Series["debug"].SetDefault(true);
            LineChart.Series["debug"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), ChartTypeList.SelectedItem.ToString());
            //LineChart.Series["debug_approx"].ChartType = SeriesChartType.Line;
            LineChart.Series["debug"].Color = Color.DarkMagenta;
            //LineChart.Series["debug_approx"].Color = Color.DarkMagenta;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                LineChart.Series["debug"].Points.AddXY(array[i, 0], array[i, 1]);
            //    LineChart.Series["debug_approx"].Points.AddXY(array[i, 0], array[i, 1]);
            }
        }

        private void ChartTypeList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (LineChart.Series.IndexOf("debug") != -1)
                LineChart.Series["debug"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), ChartTypeList.SelectedItem.ToString());
        }
    }
}
