using System;
using Ur_Rtde;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.ComponentModel;

namespace DashboardComDemo
{
    
    public partial class Main : Form
    { 
        static UniversalRobot_Outputs UrOutputs = new UniversalRobot_Outputs(); //Output set up
        static UniversalRobot_Inputs UrInputs = new UniversalRobot_Inputs(); //Input set up
        private RtdeClient Ur3 = new RtdeClient(); //Client connection
        private int refreshRate = 1; //Sets the refresh rate currently stable and tested at around 1 to 5hz but can go up to 125hz.
        private int webViewRefreshRate = 500; //Sets the refresh rate of the webview to half a second.
        static string path = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\CamsDashboard.html";
        static string Xpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\XValue.html";
        static string Ypath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\YValue.html";
        static string Zpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\ZValue.html";
        static string Rxpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RxValue.html";
        static string Rypath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RyValue.html";
        static string Rzpath = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\RzValue.html";
        private System.Timers.Timer aTimer; //Creates a timer
        

        static float[] newsetp = new float[6];
        static float[] setp1 = new float[6];
        static float[] setp2 = new float[6];

        static private string ipAddress;

        public Main()
        {
            InitializeComponent();

            //The cordinates sent are of the TCP
            //The 0,1,2 X, Y, Z
            //The 3,4,5 Rx,Ry,Rz
            //The TCP from the Base of the UR Robot
            //setp1[0] = -.12f;
            //setp1[1] = -0.51f;
            //setp1[2] = 0.0f;
            //setp1[3] = 0f;
            //setp1[4] = -3.11f;
            //setp1[5] = 0.00f;

            //setp2[0] = -.12f;
            //setp2[1] = -0.51f;
            //setp2[2] = 0.01f;
            //setp2[3] = 0f;
            //setp2[4] = -3.11f;
            //setp2[5] = 0.00f;

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            ipAddress = txtIP.Text;
            bool input = false, output = false, control = false;
            Ur3.Connect(ipAddress, 2);

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
            if (newsetp == setp1)
            {
                newsetp = setp2;
            }
            else
            {
                newsetp = setp1;
            }

            UrInputs.input_double_register_0 = newsetp[0];
            UrInputs.input_double_register_1 = newsetp[1];
            UrInputs.input_double_register_2 = newsetp[2];
            UrInputs.input_double_register_3 = newsetp[3];
            UrInputs.input_double_register_4 = newsetp[4];
            UrInputs.input_double_register_5 = newsetp[5];
            
            File.WriteAllText(path, $"<!DOCTYPE html> \n" +
                    $" <html> \n <head> \n <title> HoloLens Dashboard </title> \n <meta http-equiv=\"refresh\" content = \"1\"> " +
                    $" \n </head> \n <p> { "X: " + (UrOutputs.actual_TCP_pose[0]).ToString() } </p> \n " +
                    $"<p>{"Y: " + (UrOutputs.actual_TCP_pose[1] ).ToString()}</p> \n " +
                    $"<p>{"Z: " + (UrOutputs.actual_TCP_pose[2]).ToString()}</p> \n " +
                    $"<p>{"Rx: " + (UrOutputs.actual_TCP_pose[3] ).ToString()}</p> \n " +
                    $"<p>{"Ry: " + (UrOutputs.actual_TCP_pose[4] ).ToString()}</p> \n " +
                    $"<p>{"Rz: " + (UrOutputs.actual_TCP_pose [5] ).ToString()}</p> \n </html>");

            File.WriteAllText(Xpath, UrOutputs.actual_TCP_pose[0].ToString());
            File.WriteAllText(Ypath, UrOutputs.actual_TCP_pose[1].ToString());
            File.WriteAllText(Zpath, UrOutputs.actual_TCP_pose[2].ToString());
            File.WriteAllText(Rxpath, UrOutputs.actual_TCP_pose[3].ToString());
            File.WriteAllText(Rypath, UrOutputs.actual_TCP_pose[4].ToString());
            File.WriteAllText(Rzpath, UrOutputs.actual_TCP_pose[5].ToString());
        }
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
        static void Ur3_OnSockClosed(object sender, EventArgs e)
        {
            MessageBox.Show("Connection Closed");
        }      

        private void button2_Click(object sender, EventArgs e)
        {
            txtIP.Clear();
            txtIP.Focus();
            lblStatusDesc.Text = "";
            //Getting error temp disabled
            //Ur3.Disconnect();            
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


        string X,Y,Z,Rx,Ry,Rz;
        
        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                X = File.ReadAllText(Xpath);
                Y = File.ReadAllText(Ypath);
                Z = File.ReadAllText(Zpath);
                Rx = File.ReadAllText(Rxpath);
                Ry = File.ReadAllText(Rypath);
                Rz = File.ReadAllText(Rzpath);
               
                string site = File.ReadAllText(path); //Used for the webbrowser object
                webBrowser1.DocumentText = site;    
                
            }
            catch
            {
                //Incase it is in use and being written by data recieve event
            }
            
        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
           lblDashboardStatus.Text = Ur3.DashConnectAndCommand(ipAddress, null);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cbDashboardCommand.SelectedIndex!=-1) { lblDashStatus.Text = Ur3.DashConnectAndCommand(ipAddress, cbDashboardCommand.Text); }
        }

        BindingList<RobotPoses> poses = new BindingList<RobotPoses>();
        private void Main_Load(object sender, EventArgs e)
        {
            poses.Add(new RobotPoses() { Value = "movej(p[.282,-.221,.297,1.5,2.496,-0.06],a=3,v=0.75,t=0,r=0)", Text = "MoveJ 1" });
            poses.Add(new RobotPoses() { Value = "movej(p[.170,-.413,.494,1.959,0.894,0.082],a=3,v=0.75,t=0,r=0)", Text = "MoveJ 2" });
            lbRobotPoses.DisplayMember = "Text";
            lbRobotPoses.DataSource = poses;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbRobotPoses.Items.Count!=0) 
            {
                string value = (lbRobotPoses.SelectedItem as RobotPoses).Value;
                string text = (lbRobotPoses.SelectedItem as RobotPoses).Text;
                if (Ur3.URscriptCommand(ipAddress, value) == true) { lblUrScriptStatus.Text = "Moving to " + text; } 
                else { lblUrScriptStatus.Text = "Not Connected to robot"; }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(X!=""&&Y!=""&&Z!=""&&Rx!=""&&Ry!=""&Rz!="")
            {
                int count = lbRobotPoses.Items.Count + 1;
                //For now a, v, and t are default values
                //Also only doing Move J at the moment
                poses.Add(new RobotPoses() { Value=$"movej(p[{X},{Y},{Z},{Rx},{Ry},{Rz}],a=3,v=0.75,t=0,r=0)", Text = "MoveJ " + count.ToString()});
                lbRobotPoses.DisplayMember ="Text";
                lbRobotPoses.DataSource = poses;
                
                
                lblUrScriptStatus.Text = "New pose recorded";
            }
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
