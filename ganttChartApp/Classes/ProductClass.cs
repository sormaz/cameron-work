using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class ProductClass
    {
        private ObservableCollection<TaskClass> _tasks = new ObservableCollection<TaskClass>();
        public ObservableCollection<TaskClass> Tasks
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
        public ProductClass(string name)
        {
            this.Name = name;
        }

        public void addTask(TaskClass t)
        {
            Tasks.Add(t);
            t.Product = this;
        }
    }
}
