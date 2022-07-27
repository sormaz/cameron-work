using System;
using Ur_Rtde;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.ComponentModel;
using Microsoft.Data.Sqlite;


namespace DashboardComDemo
{
    
    public partial class Main : Form
    { 
        
        static UniversalRobot_Outputs UrOutputs = new UniversalRobot_Outputs(); //Output set up
        static UniversalRobot_Inputs UrInputs = new UniversalRobot_Inputs(); //Input set up
        private RtdeClient Ur3 = new RtdeClient(); //RTDEClient connection
        private static SQLite db = new SQLite();
        private int refreshRate = 1; //Sets the refresh rate currently stable and tested at around 1 to 5hz but can go up to 125hz.
        private int webViewRefreshRate = 500; //Sets the refresh rate of the webview to half a second.
        static string path = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\CamsDashboard.html";
        //static string Xpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\XValue.html";
        //static string Ypath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\YValue.html";
        //static string Zpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\ZValue.html";
        //static string Rxpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RxValue.html";
        //static string Rypath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RyValue.html";
        //static string Rzpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RzValue.html";
        private System.Timers.Timer aTimer; //Creates a timer
        static private string ipAddress;

        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ipAddress = txtIP.Text;
            bool input = false, output = false, control = false;


            try
            {
                Ur3.Connect(ipAddress, 2);
            }
            catch
            {
                MessageBox.Show("");
            }
            

            if (Ur3.Setup_Ur_Inputs(UrInputs))
            {
                input = true;
            }
            if (Ur3.Setup_Ur_Outputs(UrOutputs, refreshRate))
            {
                output = true;
            }
            if (Ur3.Ur_ControlStart())
            {
                control = true;
            }

            if (input == true && output == true && control == true)
            {
                Ur3.OnSockClosed += new EventHandler(Ur3_OnSockClosed);
                Ur3.OnDataReceive += new EventHandler(Ur3_OnDataReceive);                

                rbStatus.Checked = true;
                rbStatus.Text = "Connected";
                rbStatus.BackColor = System.Drawing.Color.Green;
                txtIP.Clear();
                btnRecordPose.Enabled = true;
                btnRemovePoses.Enabled = true;
                btnSend.Enabled = true;
                SetTimer();
                
            }
            else
            {
                if (!input) { lblStatusDesc.Text = "Input error"; }
                if (!output) { lblStatusDesc.Text = lblStatusDesc.Text + " Ouput error"; }
                if (!control) { lblStatusDesc.Text = lblStatusDesc.Text + " Control error"; }
                rbStatus.Checked = false;
                rbStatus.Text = "Not Connected";
                rbStatus.BackColor = System.Drawing.Color.Red;
            }

        }
        static void Ur3_OnDataReceive(object sender, EventArgs e)
        {
            //if (newsetp == setp1)
            //{
            //    newsetp = setp2;
            //}
            //else
            //{
            //    newsetp = setp1;
            //}
            //UrInputs.input_double_register_0 = newsetp[0];
            //UrInputs.input_double_register_1 = newsetp[1];
            //UrInputs.input_double_register_2 = newsetp[2];
            //UrInputs.input_double_register_3 = newsetp[3];
            //UrInputs.input_double_register_4 = newsetp[4];
            //UrInputs.input_double_register_5 = newsetp[5];

            //X = UrOutputs.actual_q[0].ToString();
            //Notice Info is giving in radians
            //Console.WriteLine(UrOutputs.actual_q[0] * 180 / Math.PI + " " + UrOutputs.actual_q[1] * 180 / Math.PI + " " + UrOutputs.actual_q[2] * 180 / Math.PI + " " + UrOutputs.actual_q[3] * 180 / Math.PI + " " + UrOutputs.actual_q[4] * 180 / Math.PI + " " + UrOutputs.actual_q[5] * 180 / Math.PI);
            //_joints.Add(UrOutputs.actual_q[0] * 180 / Math.PI + " " + UrOutputs.actual_q[1] * 180 / Math.PI + " " + UrOutputs.actual_q[2] * 180 / Math.PI + " " + UrOutputs.actual_q[3] * 180 / Math.PI + " " + UrOutputs.actual_q[4] * 180 / Math.PI + " " + UrOutputs.actual_q[5] * 180 / Math.PI);
            //if (!File.Exists(path))
            //{
            //    MessageBox.Show("File does not Exist");
            //}
            //else
            //{
            //}


            ///Outdated why causes thread control errors if reading and writing
            //File.WriteAllText(path, $"<!DOCTYPE html> \n" +
            //        $" <html> \n <head> \n <title> HoloLens Dashboard </title> \n <meta http-equiv=\"refresh\" content = \"1\"> " +
            //        $" \n </head> \n <p> { "X: " + (UrOutputs.actual_TCP_pose[0]).ToString() } </p> \n " +
            //        $"<p>{"Y: " + (UrOutputs.actual_TCP_pose[1] ).ToString()}</p> \n " +
            //        $"<p>{"Z: " + (UrOutputs.actual_TCP_pose[2]).ToString()}</p> \n " +
            //        $"<p>{"Rx: " + (UrOutputs.actual_TCP_pose[3] ).ToString()}</p> \n " +
            //        $"<p>{"Ry: " + (UrOutputs.actual_TCP_pose[4] ).ToString()}</p> \n " +
            //        $"<p>{"Rz: " + (UrOutputs.actual_TCP_pose [5] ).ToString()}</p> \n </html>");

            //File.WriteAllText(Xpath, UrOutputs.actual_TCP_pose[0].ToString());
            //File.WriteAllText(Ypath, UrOutputs.actual_TCP_pose[1].ToString());
            //File.WriteAllText(Zpath, UrOutputs.actual_TCP_pose[2].ToString());
            //File.WriteAllText(Rxpath, UrOutputs.actual_TCP_pose[3].ToString());
            //File.WriteAllText(Rypath, UrOutputs.actual_TCP_pose[4].ToString());
            //File.WriteAllText(Rzpath, UrOutputs.actual_TCP_pose[5].ToString());

            //Adds new value to variable in db file
            //if (db.X == UrOutputs.actual_TCP_pose[0].ToString()) { }
            //else { db.X = UrOutputs.actual_TCP_pose[0].ToString(); }
            
                db.X = UrOutputs.actual_TCP_pose[0].ToString();
                db.Y = UrOutputs.actual_TCP_pose[1].ToString();
                db.Z = UrOutputs.actual_TCP_pose[2].ToString();
                db.Rx = UrOutputs.actual_TCP_pose[3].ToString();
                db.Ry = UrOutputs.actual_TCP_pose[4].ToString();
                db.Rz = UrOutputs.actual_TCP_pose[5].ToString();
        }
        static void Ur3_OnSockClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Connection Closed");
        }      
        void SetTimer()
        {
            //Create a timer with a half a second interval.
            aTimer = new System.Timers.Timer(webViewRefreshRate);
            //Hook up the Elapsed event for the timer. 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
            
        }       

        //refreshs the html doc and the webbrowser every half a second
        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //db.Insert_TCP_Updated_Position();
            //string[] answer = new string[5];
            //answer = db.Get_TCP_Position();
            //lblTCPX.Text = answer[0];
            //lblTCPY.Text = answer[1];
            //lblTCPZ.Text = answer[2];
            //lblTCPRx.Text = answer[3];
            //lblTCPRy.Text = answer[4];
            //lblTCPRz.Text = answer[5];
            ///Trash....
            //try
            //{
            //    //Outdated way
            //    //X = File.ReadAllText(Xpath);
            //    //Y = File.ReadAllText(Ypath);
            //    //Z = File.ReadAllText(Zpath);
            //    //Rx = File.ReadAllText(Rxpath);
            //    //Ry = File.ReadAllText(Rypath);
            //    //Rz = File.ReadAllText(Rzpath);

            File.WriteAllText(path, $"<!DOCTYPE html> \n" +
                     $" <html> \n <head> \n <title> TCP Display </title> \n  " +
                     $" \n </head> \n <p> { "X: " + db.X} </p> \n " +
                     $"<p>{"Y: " + db.Y}</p> \n " +
                     $"<p>{"Z: " + db.Z}</p> \n " +
                     $"<p>{"Rx: " + db.Rx}</p> \n " +
                     $"<p>{"Ry: " + db.Ry}</p> \n " +
                     $"<p>{"Rz: " + db.Rz}</p> \n </html>");
            string site = File.ReadAllText(path); //Used for the webbrowser object
            webBrowser1.DocumentText = site;
        }

        //the remove button for the listbox and update for the database
        private void button6_Click(object sender, EventArgs e)
        {
            //int num = lbRobotPoses.SelectedIndex;
            //poses.Remove(poses[num]);
        }

        //button sends command to the dashboard port of the UR robot
        private void button3_Click(object sender, EventArgs e)
        {
            string command = cbDashboardCommand.SelectedText;
            if (cbDashboardCommand.SelectedIndex!=-1) 
            {
                //requires the text input 
                if (command=="load"||command=="set operational mode")
                {
                    lblDashStatus.Text = Ur3.DashConnectAndCommand(ipAddress, cbDashboardCommand.Text + "<"+txtTextinput.Text+">");
                }
                else
                {
                    lblDashStatus.Text = Ur3.DashConnectAndCommand(ipAddress, cbDashboardCommand.Text);
                }
            }
        }

        BindingList<RobotPoses> poses = new BindingList<RobotPoses>();
        private void Main_Load(object sender, EventArgs e)
        {
            //muy trashhhhh.....
            //poses.Add(new RobotPoses() { Value = "movej(p[.282,-.221,.297,1.5,2.496,-0.06],a=3,v=0.75,t=0,r=0)", Text = "MoveJ 1" });
            //poses.Add(new RobotPoses() { Value = "movej(p[.170,-.413,.494,1.959,0.894,0.082],a=3,v=0.75,t=0,r=0)", Text = "MoveJ 2" });
            //lbRobotPoses.DisplayMember = "Text";
            
            string[] answer = new string[100000];
            int i = 0;

            answer = db.GetMoveName();
            
            while (true)
            {
                if (answer[i] == null) { break; }
                lbRobotPoses.Items.Add(answer[i]);
                i++;
            }
            button1.Focus();
        }
        //button send the URScript command
        private void button4_Click(object sender, EventArgs e)
        {
            if (lbRobotPoses.Items.Count!=0&&lbRobotPoses.SelectedIndex!=-1) 
            {
                string value = db.GetURScriptCommand(lbRobotPoses.SelectedItem.ToString());
                if (Ur3.URscriptCommand(ipAddress, value) == true) { lblUrScriptStatus.Text = "Moving to " + lbRobotPoses.SelectedItem.ToString(); } 
                else { lblUrScriptStatus.Text = "Not Connected to robot"; }
            }
        }

        //button adds new recorded position to listbox
        //the a,v,t,r are currently defualts until form update
        private void button5_Click(object sender, EventArgs e)
        {
            if(db.X!=""&&db.Y!=""&&db.Z!=""&&db.Rx!=""&&db.Ry!=""&db.Rz!="")
            {
                //For now a, v, and t are default values
                //Also only doing Move J at the moment
                //poses.Add(new RobotPoses() { Value=$"movej(p[{X},{Y},{Z},{Rx},{Ry},{Rz}],a=3,v=0.75,t=0,r=0)", Text = "MoveJ " + count.ToString()});
                //lbRobotPoses.DisplayMember ="Text";
                //lbRobotPoses.DataSource = poses;
                
                int count = lbRobotPoses.Items.Count + 1;
                db.InsertNewPose("movej", $"p[{db.X},{db.Y},{db.Z},{db.Rx},{db.Ry},{db.Rz}]", "a=3,v=0.75,t=0,r=0", "MoveJ " + count.ToString());
                lbRobotPoses.Items.Clear();//reset
                
                //refresh
                string[] answer = new string[100000];
                int i = 0;
                answer = db.GetMoveName();
                while (true)
                {
                    if (answer[i] == null) { break; }
                    lbRobotPoses.Items.Add(answer[i]);
                    i++;
                }

                //update status
                lblUrScriptStatus.Text = "New pose recorded";
            }
        }


        //ALL of the selection within the dropdown list
        //load
        //play
        //stop
        //pause
        //quit
        //shutdown
        //running
        //robotmode
        //get loaded program
        //isProgramSaved
        //programState
        //PolyscopeVersion
        //set operational mode
        //get operational mode
        //clear operational mode
        //power on
        //power off
        //brake release
        //safetystatus
        //unlock protective stop
        //close safety popup
        //load installation<default.installation>
        //restart safety
        //is in remote control
        //get serial number
        //get robot model
        private void cbDashboardCommand_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = cbDashboardCommand.SelectedItem.ToString();
            if(selection=="load"||selection== "set operational mode")
            {
                txtTextinput.Enabled = true;
            }
            else
            {
                txtTextinput.Enabled = false;
            }
        }

        private void btnNewTCPPosition_Click(object sender, EventArgs e)
        {

        }
        //Check if file is being accessed 
        //Not needed anymore replaced with try catch
        //protected virtual bool IsFileLocked(FileInfo file)
        //{
        //    try 
        //    {
        //        using (FileStream stream = file.Open(FileMode.Open,FileAccess.Read,FileShare.None))
        //        {
        //            stream.Close();
        //        }
        //    }
        //    catch 
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}
