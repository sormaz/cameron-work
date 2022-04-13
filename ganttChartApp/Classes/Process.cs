using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Navigation;
using System.Windows.Data;

namespace ganttChartApp
{

    public class Process
    {
        private Task task;
        private Resource resource;
        private string converttask;
        private string convertresource;
        private double time;//In minutes assumption
        private double starttime = 0;

        public Task Task
        {
            get { return task; }
            set { task = value; }
        }
        public string Current_task
        {
            get
            {
                converttask = Task.Name.ToString();
                return converttask;
            }
        }
        public string Current_resource
        {
            get
            {
                convertresource = Resource.Name.ToString();
                return convertresource;
            }
        }
        public Resource Resource
        {
            get { return resource; }
            set { resource = value; }
        }       
        public double Time
        {
            get { return time; }
            set { time = value; }
        }
        public double Starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }
        public Process(Task task, Resource resource, double time)
        {
            this.Task = task;
            this.Resource = resource;
            this.Time = time;
            resource.addProcess(this);
            task.AddProcess(this);
        }
    }
}
