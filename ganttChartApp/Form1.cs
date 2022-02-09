using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace ganttChartApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }
        comsoalCollection con = new comsoalCollection();

        public ChartSeries series;
        public ChartSeries series2;

        //Grab current static data for Datagridview
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                productCollectionModel productCollectionModel = new productCollectionModel();
                sfDataGrid1.DataSource = productCollectionModel.Products;
                ////Create new series for product 1 and 2
                series = new ChartSeries($"Worker", ChartSeriesType.Gantt);
                series2 = new ChartSeries($"Robot", ChartSeriesType.Gantt);
                ////Add chartdata for series 1 and 2
                this.chartControl1.Series.Add(series);
                this.chartControl1.Series.Add(series2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //// Create chart series and add data points into it.
        //ChartSeries series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);

        ///// 0 = y axis , 1= starting point 3=ending point
        ////series.Points.Add(0, 1, 3);

        //series.Points.Add(0, 6, 7);

        //series.Points.Add(1, 4, 8);

        //// Add the series to the chart series collection.

        //this.chartControl1.Series.Add(series);

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            con.GenerateNewSchedule();
            foreach (cordinatesModel cords in con.Cords)
            {
                //robot
                if (cords.X == 0)
                {
                    series2.Points.Add(cords.X,cords.Y,cords.Z);
                }
                //worker
                else if (cords.X == 1)
                {
                    series.Points.Add(cords.X, cords.Y, cords.Z);
                }
                ////Add chartdata for series 1 and 2
                this.chartControl1.Series.Add(series);
                this.chartControl1.Series.Add(series2);
            }
        }
    }
}
