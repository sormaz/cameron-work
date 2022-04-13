using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;


namespace ganttChartApp
{
    public class Task
    {
        private ObservableCollection<Process> _processes = new ObservableCollection<Process>();
        private string name;
        private Product product;
        private string precedence;
        private List<Task> prevtasks = new List<Task>();
        private List<Task> nexttasks = new List<Task>();
        private bool completed = false;
        private Process selectedProcess;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Precedence
        {
            get { return precedence; }
            set { precedence = value; }
        }
        public bool Completed
        {
            get { return completed; }
            set { completed = value; }
        }
        public Task(string name, string precedence)
        {
            this.Name = name;
            this.Precedence = precedence;
        }
        public void AddPrevTask(Task t)
        {
            prevtasks.Add(t);
            t.nexttasks.Add(this);
        }
        public void AddNextTask(Task t)
        {
            nexttasks.Add(t);
            t.prevtasks.Add(this);
        }
        public List<Task> PrevTasks
        {
            get { return prevtasks; }
        }
        public List<Task> NextTasks
        {
            get { return nexttasks; }
        }
        public void AddProcess(Process process)
        {
            _processes.Add(process);
        }
        public bool IsReady()
        {
            foreach (Task t in prevtasks)
            {
                if (!t.completed)
                {
                    return false;
                }
            }
            return true;
        }
        public List<ResourceType> TaskResources()
        {
            List<ResourceType> result = new List<ResourceType>();
            foreach (Process p in _processes)
            {
                if (p.Resource.Name == ResourceType.NONE.ToString())
                {
                    result.Add(ResourceType.NONE);
                }
                else if (p.Resource.Name == ResourceType.ROBOT.ToString())
                {
                    result.Add(ResourceType.ROBOT);
                }
                else if (p.Resource.Name == ResourceType.WORKER.ToString())
                {
                    result.Add(ResourceType.WORKER);
                }
            }
            return result;
        }
        public bool ImmediatePredecessorCheck(Task t)
        {
            if (t.Precedence == "")
            {
                return false;
            }
            return true;

        }
        //public List<Task> PredecessorNeeded(Task task)
        //{
        //    List<Task> result = new List<Task>();
        //    foreach (Task t in prevtasks)
        //    {

        //    }            
        //}
    }
}
