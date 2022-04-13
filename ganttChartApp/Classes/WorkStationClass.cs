using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace ganttChartApp
{
    public class WorkStationClass
    {
        private ObservableCollection<Resource> _resources = new ObservableCollection<Resource>();
        private ObservableCollection<Product> _products = new ObservableCollection<Product>();
        public ObservableCollection<Resource> Resources
        {
            get { return _resources; }
            set { _resources = value; }
        }
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { _products = value; }
        }
        public void GenerateProducts()
        {
            Resource r1 = new Resource("robot");
            _resources.Add(r1);
            _resources.Add(new Resource("worker"));
            Product p1 = new Product("Product 1");
            _products.Add(p1);
            _products.Add(new Product("Product 2"));
            Task t1 = new Task("t1", "5");
            Process pr1 = new Process(t1, r1, 5);
            p1.addTask(t1);
        }
        public Resource FindResource(string rn)
        {
            foreach (Resource r in Resources)
            {
                if (r.Name == rn)
                {
                    return r;
                }
            }
            throw new Exception($"Resource with name {rn} not found");
        }
        public Product FindProduct(string pn)
        {
            foreach (Product p in Products)
            {
                if (p.Name == pn)
                {
                    return p;
                }
            }
            throw new Exception($"Product with name {pn} not found");
        }        
        //Used to look at each process
        public ObservableCollection<Object> MakeObservableCollection()
        {
            ObservableCollection<Object> c = new ObservableCollection<Object>();

            foreach (Resource r in Resources)
            {
                foreach (Process p in r.Processes)
                {
                    c.Add(p);
                }
            }
            return c;
        }
        public List<Task> MakeAllTasks()
        {
            List<Task> tasks = new List<Task>();
            foreach(Product p in Products)
            {
                tasks.AddRange(p.Tasks);
            }
            return tasks;
        }
        //Used to look at previous tasks added
        public ObservableCollection<Object> MakePrevTaskCollection()
        {
            ObservableCollection <Object> c = new ObservableCollection<Object>();

            foreach(Product p in Products)
            {
                foreach(Task t in p.Tasks)
                {
                    c.Add(t.PrevTasks);
                }
            }
            return c;
        }
        public ObservableCollection<Object> MakeNextTaskCollection()
        {
            ObservableCollection<Object> c = new ObservableCollection<Object>();

            foreach (Product p in Products)
            {
                foreach (Task t in p.Tasks)
                {
                    c.Add(t.NextTasks);
                }
            }
            return c;
        }
        public void InsertNewProcess(string resource, string productName, string taskName, string taskPrecedence, double processTime)
        {
            //add resource
            //Check if resource exists            
            Resource r;
            try
            {
                r = FindResource(resource);
            }
            catch (Exception)
            {
                r = new Resource(resource);
                _resources.Add(r);
            }

            //add product
            //check if product exsist
            Product p;

            try
            {
                p = FindProduct(productName);
            }
            catch (Exception)
            {
                p = new Product(productName);
                _products.Add(p);
            }

            //add task
            //check if task name exsist
            Task t;

            try
            {
                t = p.FindTask(taskName);
            }
            catch (Exception)
            {
                t = new Task(taskName, taskPrecedence);
                p.addTask(t);
            }

            // add process
            Process pro = new Process(t, r, processTime);            
            
        }
        public void ImportFileInfo(string FileName)
        {
            StreamReader InFile;
            InFile = File.OpenText(FileName);
            //read header throw away
            string header = InFile.ReadLine();
            while (!InFile.EndOfStream)
            {
                string s = InFile.ReadLine();
                string[] token = s.Split(',');
                string resource = token[0];
                string productName = token[1];
                string taskName = token[2];
                string taskPrecedence = token[3];
                double processTime = double.Parse(token[4]);
                try
                {
                    InsertNewProcess(resource, productName, taskName, taskPrecedence, processTime);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            InFile.Close();
        }
        public void ModifiedCOMSOAL()
        {
            List<Task> tasks = MakeAllTasks();
            List<Task> Sw = new List<Task>();
            List<Task> Sr = new List<Task>();
            List<Task> Srw = new List<Task>();
            List<Task> processTask = new List<Task>();

            //Step 1: Identify all unassigned tasks
            foreach (Task t in tasks)
            {
                //Step 2:Identify tasks whose immediate processors has been assigned   
                if(t.IsReady())
                {
                    //Step 3: Identify processes that can be handled by Worker, Robot, or Both
                    List<ResourceType> rTypes = t.TaskResources();
                    if(rTypes.Contains(ResourceType.ROBOT)&& rTypes.Contains(ResourceType.WORKER))
                    {
                        Srw.Add(t);
                    }
                    else if(rTypes.Contains(ResourceType.ROBOT))
                    {
                        Sr.Add(t);
                    }
                    else if(rTypes.Contains(ResourceType.WORKER))
                    {
                        Sw.Add(t);
                    }
                    else
                    {
                        throw new Exception($"Task {t.Name} does not use robot or worker");
                    }
                }

                if (!t.ImmediatePredecessorCheck(t))
                {
                    processTask.Add(t);
                }
                else
                {

                }
            }
        }
    }
}
