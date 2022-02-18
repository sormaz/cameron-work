using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class ResourceClass
    {
        //private ObservableCollection<ProcessClass> _process = new ObservableCollection<ProcessClass>();
        //public ObservableCollection<ProcessClass> Process
        //{
        //    get { return _process; }
        //    set { _process = value; }
        //}
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ResourceClass(string name)
        {
            this.Name = name;
        }
    }
}
