using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace ganttChartApp
{
    public class WorkStationClass
    {
        private ObservableCollection<ResourceClass> _resources = new ObservableCollection<ResourceClass>();
        private ObservableCollection<ProductClass> _products = new ObservableCollection<ProductClass>();
        public ObservableCollection<ResourceClass> Resources
        { 
            get { return _resources; }
            set { _resources = value; }
        }
        public ObservableCollection<ProductClass> Products
        {
            get { return _products; }
            set { _products = value; }
        }
        public void GenerateProducts()
        {
            ResourceClass r1 = new ResourceClass("robot");
            _resources.Add(r1);
            _resources.Add(new ResourceClass("worker"));
            ProductClass p1 = new ProductClass("Product 1");
            _products.Add(p1);
            _products.Add(new ProductClass("Product 2"));
            TaskClass t1 = new TaskClass("t1","5");
            ProcessClass pr1 = new ProcessClass(t1, r1, 5);
            p1.addTask(t1);
        }
        public void InsertNewProducts(string resource, string productName, string taskName, string taskPrecedence, double processTime)
        {
            //add resource
            ResourceClass r = new ResourceClass(resource);
            _resources.Add(r);
            //add product
            ProductClass p = new ProductClass(productName);
            _products.Add(p);
            //add task
            TaskClass t = new TaskClass(taskName, taskPrecedence);
            p.addTask(t);
            //Add process
            ProcessClass pro = new ProcessClass(t, r, processTime);            
        }
        public void ImportProductInfo(string FileName)
        {
            StreamReader InFile;
            InFile = File.OpenText(FileName);
            //read header throw away
            string header = InFile.ReadLine();
            while(!InFile.EndOfStream)
            {
                string s = InFile.ReadLine();
                string[] token = s.Split(',');
                string resource = token[0];
                string productName = token[1];
                string taskName = token[2];
                string taskPrecedence = token[3];
                double processTime= double.Parse(token[4]);
                try
                {
                    InsertNewProducts(resource,productName,taskName,taskPrecedence,processTime);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
            InFile.Close();
        }
    }
}
