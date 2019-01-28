namespace VisualLine
{
    partial class LineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartTypeList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LineChart
            // 
            chartArea1.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.LineChart.Legends.Add(legend1);
            this.LineChart.Location = new System.Drawing.Point(12, -1);
            this.LineChart.Name = "LineChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.LineChart.Series.Add(series1);
            this.LineChart.Size = new System.Drawing.Size(835, 547);
            this.LineChart.TabIndex = 0;
            this.LineChart.Text = "chart1";
            // 
            // ChartTypeList
            // 
            this.ChartTypeList.FormattingEnabled = true;
            this.ChartTypeList.Location = new System.Drawing.Point(853, 12);
            this.ChartTypeList.Name = "ChartTypeList";
            this.ChartTypeList.Size = new System.Drawing.Size(146, 524);
            this.ChartTypeList.TabIndex = 1;
            this.ChartTypeList.SelectedValueChanged += new System.EventHandler(this.ChartTypeList_SelectedValueChanged);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 558);
            this.Controls.Add(this.ChartTypeList);
            this.Controls.Add(this.LineChart);
            this.Name = "LineForm";
            this.Text = "LineForm";
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.ListBox ChartTypeList;
    }
}