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
        private ObservableCollection<productModel> _products;
        string resourceName = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            ///Link the product collection to the data grid view table
            productCollectionModel productCollectionModel = new productCollectionModel();
            sfDataGrid1.DataSource = productCollectionModel.Products;
           
            ReadingCollection();
        }

        public void ReadingCollection()
        {
            productCollectionModel con = new productCollectionModel();
            _products = con.Products;
            foreach (productModel product in _products)
            {

                if (resourceName == null)
                {
                    //update if new
                    resourceName = product.ProductName;
                    //Create new series
                    ChartSeries series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);
                    //plot points translated from modified COMSOAL procedure
                    series.Points.Add(0, 1, 3);
                    //Add the point to chart
                    this.chartControl1.Series.Add(series);
                }
                else if (resourceName == product.ProductName)
                {
                    //dont update
                }
                else
                {
                    //change if not the same name
                    resourceName = product.ProductName;
                    //Create new series
                    ChartSeries series = new ChartSeries($"{resourceName}", ChartSeriesType.Gantt);
                    //plot points translated from modified COMSOAL procedure
                    series.Points.Add(1, 5, 9);
                    //Add the point to chart
                    this.chartControl1.Series.Add(series);
                }

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
    }
}
