using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class ProcessClass
    {
        private TaskClass task;
        private ResourceClass resource;
        private double time;//In minutes assumption
        private DateTime starttime =DateTime.Now;
        public TaskClass Task
        {
            get { return task; }
            set { task = value; }
        }
        public ResourceClass Resource
        {
            get { return resource; }
            set { resource = value; }
        }
        public double Time
        {
            get { return time; }
            set { time = value; }
        }
        public DateTime Starttime
        {
            get { return starttime; }
            set { starttime = value; }
        }
        public ProcessClass(TaskClass task, ResourceClass resource, double time)
        {
            this.Task = task;
            this.Resource = resource;
            this.Time = time;
        }
    }
}
