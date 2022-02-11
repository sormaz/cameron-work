using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class TaskModel
    {
        //Implement SQL db Conneections later
        private string productName;
        private int taskNumber;
        private int numOfPrecedences;
        private string resource;
        private double resourceProcessingTime;
        private string followingTask;
        private bool compelete;

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
        public string Resource
        {
            get { return resource; }
            set { resource = value; }
        }
        public double ResourceProcessingTime
        {
            get { return resourceProcessingTime; }
            set { resourceProcessingTime = value; }
        }
        public string FollowingTask
        {
            get { return followingTask; }
            set { followingTask = value; }
        }
        public bool Compelete
        {
            get { return compelete; }
            set { compelete = value; }
        }
        public TaskModel(string productName, int taskNumber, int numberofprecedences, string resource, double resourceprocessingtime, string followingtask, bool complete)
        {
            this.ProductName = productName;
            this.TaskNumber = taskNumber;
            this.NumOfPrecedences = numberofprecedences;
            this.Resource = resource;
            this.ResourceProcessingTime = resourceprocessingtime;
            this.FollowingTask = followingtask;
            this.Compelete = complete;
        }
    }
}
