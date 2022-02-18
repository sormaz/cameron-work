using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

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
            try
            {
                //TaskCollection.GenerateProducts();
                //sfDataGrid1.DataSource = TaskCollection.Tasks;
                
                //string[] resources = new string[100];//Current Max number of resources is 100
                //int resourceCount = 0;
                ////Create new series for product 1 and 2
                //for (int i = 1; i < TaskCollection.Tasks.Count; i++)
                //{
                //    //if a resource is blank then throw error message
                //    if (TaskCollection.Tasks[i].Resource == "")
                //    {
                //        MessageBox.Show("A resource is needed for all tasks!");
                //        break;
                //    }
                //    else
                //    {
                //        bool found = false;
                //        foreach (string r in resources)
                //        {
                //            if (r == TaskCollection.Tasks[i].Resource)
                //            {
                //                found = true;
                //            }
                //        }
                //        if (found == false)
                //        {
                //            resources[resourceCount] = TaskCollection.Tasks[i].Resource;
                //            resourceCount++;
                //        }
                //    }
                //}
                //foreach (string r in resources)
                //{
                //    if (r=="" || r==null)
                //    {

                //    }
                //    else
                //    {
                //        series = new ChartSeries(r, ChartSeriesType.Gantt);
                //        this.chartControl1.Series.Add(series);
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }//Garbage
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
           
            work.GenerateProducts();
            //ComsoalClass.GenerateNewSchedule(TaskCollection);
            //string[] resource;
            //int resourceCount = 0;
            //resource = new string[1000];
            ////For each item in the ganttclass collection
            //foreach (var item in ComsoalClass.ChartInfo)
            //{
            //    //if no resources were found
            //    if (resource[0] == "" || resource[0] == null)
            //    {
            //        resource[resourceCount] = item.ResourceName;//add to list 
            //    }
            //    else
            //    {
            //        //check the resource array for resources that already are collected
            //        bool resourceFound = false;
            //        foreach (string reso in resource)
            //        {
            //            if (reso == item.ResourceName)
            //            {
            //                resourceFound = true;
            //            }
            //            else if (reso == null)
            //            {
            //                break;
            //            }
            //        }
            //        //if not found add to resource name list
            //        if (resourceFound == false)
            //        {
            //            resourceCount++;
            //            resource[resourceCount] = item.ResourceName;
            //        }
            //    }               
            //}
            //foreach (string reso in resource)
            //{
            //    if (reso == null)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        series = new ChartSeries(reso, ChartSeriesType.Gantt);

            //        foreach (var r in ComsoalClass.ChartInfo)
            //        {
            //            if (r.ResourceName == reso)
            //            {
            //                series.Points.Add(r.ResourceName, r.CurrentCompletionTime, r.ProcessingTime);
            //            }
            //        }
            //        this.chartControl1.Series.Add(series);
            //    }
            //}
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

        private void importFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    work.ImportProductInfo(openFileDialog1.FileName);
                    sfDataGrid1.DataSource = work.Products;
                    MessageBox.Show(openFileDialog1.FileName + " imported");

                }
                catch(Exception ex)
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
