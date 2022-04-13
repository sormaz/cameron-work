using System.Collections.ObjectModel;


namespace ganttChartApp
{

    public class Resource
    {
        private ObservableCollection<Process> _processes = new ObservableCollection<Process>();
        public ObservableCollection<Process> Processes
        {
            get { return _processes; }
            set { _processes = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Resource(string name)
        {
            this.Name = name;
        }
        public void addProcess(Process pro)
        {
            Processes.Add(pro);
            pro.Resource = this;
        }
        public ResourceType resourceType;
    }    
    public enum ResourceType
    {
        NONE,
        ROBOT,
        WORKER
    }
}
