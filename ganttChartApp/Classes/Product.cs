using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class Product
    {
        private ObservableCollection<Task> _tasks = new ObservableCollection<Task>();
        public ObservableCollection<Task> Tasks
        {
            get { return _tasks; }
            set { _tasks = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Product(string name)
        {
            this.Name = name;
        }

        public void addTask(Task t)
        {
            Tasks.Add(t);
            t.Product = this;
        }
        public Task FindTask(string tn)
        {
            foreach (Task t in Tasks)
            {
                if (t.Name == tn)
                {
                    return t;
                }
            }
            throw new Exception($"Task with name {tn} not found");
        }

    }
}
