using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ganttChartApp
{
    public class comsoalCollection
    {
        //Reference to call on and set product infomation
        private ObservableCollection<comsoalModel> _availableTasks = new ObservableCollection<comsoalModel>();
        private ObservableCollection<cordinatesModel> _cords = new ObservableCollection<cordinatesModel>();
        public ObservableCollection<cordinatesModel> Cords
        {
            get { return _cords; }
            set { _cords = value; }
        }
        public ObservableCollection<comsoalModel> AvailableTasks
        {
            get { return _availableTasks; }
            set { _availableTasks = value; }
        }

        //prep for connections to product collection model
        productCollectionModel con = new productCollectionModel();
        Random Random = new Random();
        double probability = 0;
        double availableTaskCount = 0;
        int precedenceCount = 0;
        double probabilityCount = 0;
        double currentWorkerCompleteionTime = 0;
        double currentRobotCompleteionTime = 0;
        string workerPrevProudct = "";
        string robotPrevProduct = "";
        bool endOfProducts = false;
       
       
        public void GenerateNewSchedule()
        {

            //infinite loop watch out!
            while (true)
            {
                //start generating first interval
                foreach (productModel product in con.Products)
                {
                    if (precedenceCount > product.NumOfPrecedences)
                    {
                        endOfProducts = true;
                        break;
                    }
                    else if (product.NumOfPrecedences == precedenceCount)
                    {
                        AvailableTasks.Add(new comsoalModel(product.ProductName, product.TaskNumber, product.NumOfPrecedences, product.RobotTask, product.WorkerTask, product.RobotProcessingTime, product.WorkerProcessingTime, product.FollowingTask));
                    }
                }
                //break loop if precedence value is higher then what is availabel in product collection
                if (endOfProducts == true)
                {
                    break;
                }
                //reset
                availableTaskCount = 0;
                probability = 0;
                probabilityCount = 0;
                //count tasks available
                foreach (comsoalModel task in AvailableTasks)
                {
                    availableTaskCount += 1;
                }
                //Get probability of each
                probability = 1 / availableTaskCount * 100;
                //Get random number
                int rn = Random.Next(0, 100);
                //check available tasks list
                //then remove task after assigned
                foreach (comsoalModel task in AvailableTasks)
                {
                    //generate probability of the select task
                    probabilityCount += probability;
                    //Check to see if the select task is the one randomly selected
                    if (rn <= probabilityCount && rn >= probabilityCount - probability)
                    {
                        //check to see if any task is assigned
                        if (currentRobotCompleteionTime == 0 && currentWorkerCompleteionTime == 0)
                        {
                            //product 1?
                            if (task.ProductName == "Product 1")
                            {
                                //is it a hybrid task?
                                if (task.RobotTask == true && task.WorkerTask == true)
                                {
                                    //robot processing time less than work
                                    //assign to robot
                                    if (task.RobotProcessingTime < task.WorkerProcessingTime)
                                    {
                                        currentRobotCompleteionTime += task.RobotProcessingTime;
                                        robotPrevProduct = task.ProductName;
                                        Cords.Add(new cordinatesModel(0,currentRobotCompleteionTime,task.RobotProcessingTime));
                                        AvailableTasks.Remove(task);
                                    }
                                    //else assign to worker
                                    else
                                    {
                                        currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                        workerPrevProudct = task.ProductName;
                                        Cords.Add(new cordinatesModel(1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                        AvailableTasks.Remove(task);
                                    }
                                }
                                //is it a robot task?
                                else if (task.RobotTask == true && task.WorkerTask == false)
                                {
                                    currentRobotCompleteionTime += task.RobotProcessingTime;
                                    robotPrevProduct = task.ProductName;
                                    Cords.Add(new cordinatesModel(0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                                //is it a worker task?
                                else if (task.RobotTask == false && task.WorkerTask == true)
                                {
                                    currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                    workerPrevProudct = task.ProductName;
                                    Cords.Add(new cordinatesModel(1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                            }
                            //product 2?
                            else
                            {
                                //is it a hybrid task?
                                if (task.RobotTask == true && task.WorkerTask == true)
                                {
                                    //robot processing time less than work
                                    //assign to robot
                                    if (task.RobotProcessingTime < task.WorkerProcessingTime)
                                    {
                                        currentRobotCompleteionTime += task.RobotProcessingTime;
                                        robotPrevProduct = task.ProductName;
                                        Cords.Add(new cordinatesModel( 0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                        _availableTasks.Remove(task);

                                    }
                                    //else assign to worker
                                    else
                                    {
                                        currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                        workerPrevProudct = task.ProductName;
                                        Cords.Add(new cordinatesModel( 1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                        _availableTasks.Remove(task);
                                    }
                                }
                                //is it a robot task?
                                else if (task.RobotTask == true && task.WorkerTask == false)
                                {
                                    currentRobotCompleteionTime += task.RobotProcessingTime;
                                    robotPrevProduct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                    _availableTasks.Remove(task);
                                }
                                //is it a worker task?
                                else if (task.RobotTask == false && task.WorkerTask == true)
                                {
                                    currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                    workerPrevProudct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                    _availableTasks.Remove(task);
                                }
                            }
                        }
                        //A task already assigned
                        else
                        {
                            //is it a hybrid task?
                            if (task.RobotTask == true && task.WorkerTask == true)
                            {
                                //if the last task assigned to the robot have the same product
                                if (robotPrevProduct == task.ProductName)
                                {
                                    currentRobotCompleteionTime += task.RobotProcessingTime;
                                    robotPrevProduct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                                //else assign to the worker
                                else
                                {
                                    currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                    workerPrevProudct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                            }
                            //is it a robot task?
                            else if (task.RobotTask == true && task.WorkerTask == false)
                            {
                                //if it is a robot task and last task was of same product then assign to robot
                                if (robotPrevProduct == task.ProductName)
                                {
                                    currentRobotCompleteionTime += task.RobotProcessingTime;
                                    robotPrevProduct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                                //if last product is differnet then make a jump to creat new interval
                                else
                                {
                                    currentRobotCompleteionTime = currentWorkerCompleteionTime + task.RobotProcessingTime;
                                    robotPrevProduct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 0, currentRobotCompleteionTime, task.RobotProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                            }
                            //is it a worker task?
                            else if (task.RobotTask == false && task.WorkerTask == true)
                            {
                                //if it is a worker task and last task was of same product then assign to worker
                                if (workerPrevProudct == task.ProductName)
                                {
                                    currentWorkerCompleteionTime += task.WorkerProcessingTime;
                                    workerPrevProudct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                                //if last product is differnet then make a jump to creat new interval
                                else
                                {
                                    currentWorkerCompleteionTime = currentRobotCompleteionTime + task.WorkerProcessingTime;
                                    workerPrevProudct = task.ProductName;
                                    Cords.Add(new cordinatesModel( 1, currentWorkerCompleteionTime, task.WorkerProcessingTime));
                                    AvailableTasks.Remove(task);
                                }
                            }
                        }
                    }
                }
                //add to the next precedence of task
                precedenceCount++;
            }

        }
    }
}
