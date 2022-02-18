using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class TaskClass
    {
        private string name;
        private ProductClass product;
        private string precedence;

        private bool completed = false;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public ProductClass Product
        {
            get { return product; }
            set { product = value; }
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

        public TaskClass(string name, string precedence)
        {
            this.Name = name;
            this.Precedence = precedence;            
        }
    }
}
