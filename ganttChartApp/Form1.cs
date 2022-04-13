using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using Vector3D = System.Windows.Media.Media3D.Vector3D;

namespace ganttChartApp
{
    public partial class Form1 : Form
    {
        WorkStationClass work = new WorkStationClass();

        public ChartSeries series;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
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
            work.ModifiedCOMSOAL();
            sfDataGrid1.DataSource = work.MakeNextTaskCollection();
        }
        private void btnClearDT_Click_1(object sender, EventArgs e)
        {
            //TaskCollection Tasks = new TaskCollection();
            //Tasks.Tasks.Clear();
            //Tasks.Tasks.Add(new TaskClass("", 0, 0, "", "", 0, "", false));
            //sfDataGrid1.DataSource = Tasks.Tasks;
        }

        private void newTasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //code to open form for adding new task
        }
        private void importFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    work.ImportFileInfo(openFileDialog1.FileName);
                    //MessageBox.Show(openFileDialog1.FileName + " imported");
                    ObservableCollection<Object> t = work.MakeObservableCollection();
                    sfDataGrid1.DataSource = t;

                    //ObservableCollection<Object> prevT = work.MakePrevTaskCollection();
                    //sfDataGrid1.DataSource = prevT;
                    sfDataGrid1.Refresh();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Aborted");
            }
        }
    }
}
