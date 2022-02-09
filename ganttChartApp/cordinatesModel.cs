using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class cordinatesModel
    {
        //private string assignment;
        private double x;
        private double y;
        private double z;
        //public string Assignment
        //{
        //    get { return assignment; }
        //    set { assignment = value; }
        //}
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public cordinatesModel(double x, double y, double z)
        {
            //this.Assignment = assignment;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
   

