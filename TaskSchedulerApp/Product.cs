using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSchedulerApp
{
    public class Product
    {
        //Type of resource utilized
        public string Resource { get; set; } 

        //Part processing time data
        public decimal P1 { get; set; }
        public decimal P2 { get; set; }
        public decimal P3 { get; set; }
        public decimal P4 { get; set; }
        public decimal P5 { get; set; }
        public decimal P6 { get; set; }
        public decimal P7 { get; set; }
        public decimal P8 { get; set; }
        public decimal P9 { get; set; }
        public decimal P10 { get; set; }
        public decimal P11 { get; set; }
        public decimal P12 { get; set; }
        public decimal P13 { get; set; }
        public decimal P14 { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
