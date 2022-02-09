using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class comsoalModel
    {
        //Implement SQL db Conneections later
        private string productName;
        private int taskNumber;
        private int numOfPrecedences;
        private bool robotTask;
        private bool workerTask;
        private double robotProcessingTime;
        private double workerProcessingTime;
        private string followingTask;
       

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public int TaskNumber
        {
            get { return taskNumber; }
            set { taskNumber = value; }
        }
        public int NumOfPrecedences
        {
            get { return numOfPrecedences; }
            set { numOfPrecedences = value; }
        }
        public bool RobotTask
        {
            get { return robotTask; }
            set { robotTask = value; }
        }
        public bool WorkerTask
        {
            get { return workerTask; }
            set { workerTask = value; }
        }
        public double RobotProcessingTime
        {
            get { return robotProcessingTime; }
            set { robotProcessingTime = value; }
        }
        public double WorkerProcessingTime
        {
            get { return workerProcessingTime; }
            set { workerProcessingTime = value; }
        }
        public string FollowingTask
        {
            get { return followingTask; }
            set { followingTask = value; }
        }
       
        public comsoalModel(string productName, int taskNumber, int numberofprecedences, bool robotTask, bool workerTask, double robotprocesingtime, double workerprocessingtime, string followingtask)
        {
            this.ProductName = productName;
            this.TaskNumber = taskNumber;
            this.NumOfPrecedences = numberofprecedences;
            this.WorkerTask = workerTask;
            this.RobotTask = robotTask;
            this.RobotProcessingTime = robotprocesingtime;
            this.WorkerProcessingTime = workerprocessingtime;
            this.FollowingTask = followingtask;            
        }
    }
}
