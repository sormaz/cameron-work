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
        string resourceName = null;
        int resourceLevel = 0;

        //Grab current static data for Datagridview
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                productCollectionModel productCollectionModel = new productCollectionModel();
                sfDataGrid1.DataSource = productCollectionModel.Products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void SendingTaskSelection(int taskNumber, string resource, double currentCompletionTime, double processingTime)
        {
            //reset chart level
            resourceLevel = 0;
            //update if new
            if (resourceName == null)
            {
                resourceName = resource;
                ////Create new series
                series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);
                ////plot points translated from modified COMSOAL procedure
                series.Points.Add(resourceLevel, currentCompletionTime, processingTime);
            }
            //add to exisiting level
            else if (resourceName == resource)
            {
                series.Points.Add(resourceLevel, currentCompletionTime, processingTime);
            }
            //Create new series and add to level
            else if (resourceName != resource)
            {
                series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);
                resourceLevel = resourceLevel + 1;
                series.Points.Add(resourceLevel, currentCompletionTime, processingTime);
            }


            ////Add the point to chart
            this.chartControl1.Series.Add(series);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            con.GenerateNewSchedule();
        }
        //// Create chart series and add data points into it.
        //ChartSeries series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);

        ///// 0 = y axis , 1= starting point 3=ending point
        ////series.Points.Add(0, 1, 3);

        //series.Points.Add(0, 6, 7);

        //series.Points.Add(1, 4, 8);

        //// Add the series to the chart series collection.

        //this.chartControl1.Series.Add(series);
    }
}
