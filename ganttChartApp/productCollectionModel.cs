using System;
using System.Collections.ObjectModel;


namespace ganttChartApp
{
    public class productCollectionModel
    {

        private ObservableCollection<productModel> _products;

        //Reference to call on and set product infomation
        public ObservableCollection<productModel> Products
        {
            get { return _products; }
            set { _products = value; }
        }

        //creates the new product collection used in form load
        public productCollectionModel()
        {
            _products = new ObservableCollection<productModel>();
            this.GenerateProducts();
        }


        /// <summary>
        /// Static data generated for initial use
        /// </summary>
        /// 
        /// Global var to hold told num of tasks
        int totalTaskNum = 0;
        private void GenerateProducts()
        {

            int numOfPrecedences = 0;
            bool robot = false;
            bool worker = false;
            double robotT = 0;
            double workerT = 0;
            int maxNumParts = 0;
            string followingTask = null;
            bool completedTask = false;

            //2 = max number of products
            for (int i = 1; i <= 2; i++)
            {
                //14 = max number of total parts for single product
                for (int j = 1; j <= 7; j++)
                {
                    totalTaskNum += 1;
                    if (totalTaskNum == 1) { numOfPrecedences = 0; robot = true; worker = false; robotT = 5; workerT = 0; followingTask = "2_3"; completedTask = false; }
                    else if (totalTaskNum == 2) { numOfPrecedences = 1; robot = true; worker = true; robotT = 3; workerT = 6; followingTask = "4"; completedTask = false; }
                    else if (totalTaskNum == 3) { numOfPrecedences = 1; robot = false; worker = true; robotT = 0; workerT = 13; followingTask = "5"; completedTask = false; }
                    else if (totalTaskNum == 4) { numOfPrecedences = 1; robot = true; worker = false; robotT = 3; workerT = 0; followingTask = "6_7"; completedTask = false; }
                    else if (totalTaskNum == 5) { numOfPrecedences = 1; robot = true; worker = true; robotT = 3; workerT = 6; followingTask = "6"; completedTask = false; }
                    else if (totalTaskNum == 6) { numOfPrecedences = 2; robot = true; worker = true; robotT = 7; workerT = 12; followingTask = "7"; completedTask = false; }
                    else if (totalTaskNum == 7) { numOfPrecedences = 2; robot = false; worker = true; robotT = 0; workerT = 4; followingTask = ""; completedTask = false; }
                    else if (totalTaskNum == 8) { numOfPrecedences = 0; robot = false; worker = true; robotT = 0; workerT = 9; followingTask = "9_10_11"; completedTask = false; }
                    else if (totalTaskNum == 9) { numOfPrecedences = 1; robot = true; worker = true; robotT = 3; workerT = 5; followingTask = "12"; completedTask = false; }
                    else if (totalTaskNum == 10) { numOfPrecedences = 1; robot = true; worker = false; robotT = 4; workerT = 0; followingTask = "13"; completedTask = false; }
                    else if (totalTaskNum == 11) { numOfPrecedences = 1; robot = true; worker = true; robotT = 2; workerT = 4; followingTask = "13"; completedTask = false; }
                    else if (totalTaskNum == 12) { numOfPrecedences = 1; robot = false; worker = true; robotT = 0; workerT = 6; followingTask = "14"; completedTask = false; }
                    else if (totalTaskNum == 13) { numOfPrecedences = 2; robot = true; worker = true; robotT = 5; workerT = 7; followingTask = "14"; completedTask = false; }
                    else if (totalTaskNum == 14) { numOfPrecedences = 2; robot = true; worker = false; robotT = 9; workerT = 0; followingTask = ""; completedTask = false; }

                    _products.Add(new productModel($"Product {i}", totalTaskNum, numOfPrecedences, robot, worker, robotT, workerT, followingTask, completedTask));

                    maxNumParts = j;
                }
                totalTaskNum = maxNumParts;
            }


        }
    }
}
