using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskSchedulerApp
{
    public partial class Dashboard : Form
    {
        
        public Dashboard()
        {
            InitializeComponent();
            
        }
        
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Create chart series and add data points into it.

            ChartSeries series = new ChartSeries("Series Name", ChartSeriesType.Gantt);

            series.Points.Add(0, 1, 5);

            series.Points.Add(1, 3, 7);

            series.Points.Add(2, 4, 8);

            // Add the series to the chart series collection.

            this.chartControl1.Series.Add(series);
            // chartControl1.Series
        }
    }
}
