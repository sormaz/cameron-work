using System;
using Ur_Rtde;
using System.Net;
using System.Collections.Generic;

namespace Mycode
{
    class Program
    {
        static UniversalRobot_Outputs UrOutputs=new UniversalRobot_Outputs();
        static UniversalRobot_Inputs UrInputs=new UniversalRobot_Inputs();
       
        static void Main(string[] args)
        {
            // Connection using the protocol version 2 (allows update frequency less or equal to 125 Hz)
            //Watchdog Example set to 1 Hz
            RtdeClient Ur3 = new RtdeClient();

            //If socket is closed notify
            Ur3.OnSockClosed += new EventHandler(Ur3_OnSockClosed);

            //Attempt to connect to RTDE server host protocol version 2
            Ur3.Connect("10.130.255.117",2);
            //Ur3.Connect("192.168.50.84", 2);


            // Register Inputs (UR point of view)
            // Register watch dog 
            //Console.WriteLine(Ur3.Setup_Ur_Inputs(WatchDog));
            Console.WriteLine(Ur3.Setup_Ur_Inputs(UrInputs));

            // Original Register Outputs (UR point of view), for an update frequency 10Hz
            // Register Outputs (UR point of view), for an update frequency 1Hz
            Console.WriteLine(Ur3.Setup_Ur_Outputs(UrOutputs, 10));

            

            //Originally Request the UR to send back Outputs periodically
            //Now gets the controller verison
            Console.WriteLine(Ur3.Ur_ControlStart());




            Ur3.OnDataReceive += new EventHandler(Ur3_OnDataReceive);
            

            

            Console.ReadKey();

            // Bye bye Robot
            Ur3.Disconnect();           
        }

        static void Ur3_OnSockClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Closed");
        }
        
        static float[] newsetp = new float[6];
        static float[] setp1 = new float[6];
        static float[] setp2 = new float[6];
        // Data change Event 
        static void Ur3_OnDataReceive(object sender, EventArgs e)
        {
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

            //Console.WriteLine(UrInputs.input_double_register_0 + " " + UrInputs.input_double_register_1 + " " + UrInputs.input_double_register_2 + " " + UrInputs.input_double_register_3 + " " + UrInputs.input_double_register_4 + " " + UrInputs.input_double_register_5);

            //Notice Info is giving in radians
            Console.WriteLine(UrOutputs.actual_q[0] * 180/Math.PI + " " + UrOutputs.actual_q[1] * 180 / Math.PI + " " + UrOutputs.actual_q[2] * 180 / Math.PI + " " + UrOutputs.actual_q[3] * 180 / Math.PI + " " + UrOutputs.actual_q[4] * 180 / Math.PI + " " + UrOutputs.actual_q[5] * 180 / Math.PI);

            //Console.WriteLine(UrOutputs.target_q[0] + " " + UrOutputs.target_q[1] + " " + UrOutputs.target_q[2] + " " + UrOutputs.target_q[3] + " " + UrOutputs.target_q[4] + " " + UrOutputs.target_q[5]);
            //Console.WriteLine(UrOutputs.output_int_register_0);
        }
    }
}
