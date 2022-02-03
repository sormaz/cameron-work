﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class productModel
    {
        //Implement SQL db Conneections later
        string productName;
        int taskNumber;
        bool robotTask;
        bool workerTask;
        double robotProcessingTime;
        double workerProcessingTime;
        string followingTask;
        bool compelete;

        public string ProductName
        {
            get {return productName;}
            set { productName = value; }
        }
        public int TaskNumber
        {
            get { return taskNumber;}
            set { taskNumber = value; }
        }
        public bool RobotTask
        {
            get { return robotTask;}
            set { robotTask = value; }
        }
        public bool WorkerTask
        {
            get { return workerTask;}
            set { workerTask = value; }
        }
        public double RobotProcessingTime
        {
            get { return robotProcessingTime;}
            set { robotProcessingTime = value; }
        }
        public double WorkerProcessingTime
        {
            get { return workerProcessingTime;}
            set { workerProcessingTime = value; }
        }
        public string FollowingTask
        {
            get { return followingTask;}
            set { followingTask = value; }
        }
        public bool Compelete
        {
            get { return compelete;}   
            set { compelete = value; }
        }
        public productModel(string productName, int taskNumber, bool robotTask, bool workerTask, double robotprocesingtime, double workerprocessingtime,string followingtask,bool complete)
        {
            this.ProductName = productName;
            this.TaskNumber = taskNumber;
            this.WorkerTask = workerTask;
            this.RobotTask = robotTask;
            this.RobotProcessingTime = robotprocesingtime;
            this.WorkerProcessingTime = workerprocessingtime;
            this.FollowingTask = followingtask;
            this.Compelete = complete;
        }
    }
}
