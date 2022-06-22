using System;
using Ur_Rtde;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Timers;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace DashboardComDemo
{
    
    public partial class Main : Form
    { 
        static UniversalRobot_Outputs UrOutputs = new UniversalRobot_Outputs(); //Output set up
        static UniversalRobot_Inputs UrInputs = new UniversalRobot_Inputs(); //Input set up
        private RtdeClient Ur3 = new RtdeClient(); //Client connection
        private int refreshRate = 5; //Sets the refresh rate currently stable at 5hz
        private int webViewRefreshRate = 500; //Sets the refresh rate of the webview to half a second. stable
        static string path = @"C:\Users\Infam\OneDrive\Documents\GitHub\cameron-work\DashboardComDemo\HoloDashboard\CamsDashboard.html";
        private System.Timers.Timer aTimer; //Creates a timer
        

        static float[] newsetp = new float[6];
        static float[] setp1 = new float[6];
        static float[] setp2 = new float[6];

        public Main()
        {
            InitializeComponent();

            //The cordinates sent are of the TCP
            //The 0,1,2 X, Y, Z
            //The 3,4,5 Rx,Ry,Rz
            //The TCP from the Base of the UR Robot
            setp1[0] = -.12f;
            setp1[1] = -0.51f;
            setp1[2] = 0.0f;
            setp1[3] = 0f;
            setp1[4] = -3.11f;
            setp1[5] = 0.00f;

            setp2[0] = -.12f;
            setp2[1] = -0.51f;
            setp2[2] = 0.01f;
            setp2[3] = 0f;
            setp2[4] = -3.11f;
            setp2[5] = 0.00f;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool input = false, output = false, control = false;
            Ur3.Connect(txtIP.Text, 2);

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
                    $" \n </head> \n <p> { "X: " + (UrOutputs.actual_q[0] * 180 / Math.PI).ToString() } </p> \n " +
                    $"<p>{"Y: " + (UrOutputs.actual_q[1] * 180 / Math.PI).ToString()}</p> \n " +
                    $"<p>{"Z: " + (UrOutputs.actual_q[2] * 180 / Math.PI).ToString()}</p> \n " +
                    $"<p>{"Rx: " + (UrOutputs.actual_q[3] * 180 / Math.PI).ToString()}</p> \n " +
                    $"<p>{"Ry: " + (UrOutputs.actual_q[4] * 180 / Math.PI).ToString()}</p> \n " +
                    $"<p>{"Rz: " + (UrOutputs.actual_q[5] * 180 / Math.PI).ToString()}</p> \n </html>");


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
        
        void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                string site = File.ReadAllText(path); //Used for the webbrowser object
                webBrowser1.DocumentText = site;
            }
            catch
            {
                //Incase it is in use and being written by data recieve event
            }
            
        }

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
