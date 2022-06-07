using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ur_Rtde;
using System.Threading;
 
namespace Mycode
{
    class Program
    {
        static UniversalRobot_Outputs UrOutputs=new UniversalRobot_Outputs();
        static UniversalRobot_Inputs UrInputs=new UniversalRobot_Inputs();

        static void Main(string[] args)
        {
            // Connection using the protocol version 2 (allows update frequency less or equal to 125 Hz)
            RtdeClient Ur3 = new RtdeClient();

            Ur3.OnSockClosed += new EventHandler(Ur3_OnSockClosed);

            Ur3.Connect("192.168.50.84",2);

            // Register Inputs (UR point of view)
            Console.WriteLine(Ur3.Setup_Ur_Inputs(UrInputs));

            /*
            UrInputs.tool_digital_output = 255;
            UrInputs.tool_digital_output_mask = 255;
            Console.WriteLine(Ur3.Send_Ur_Inputs());
             */

            // Register Outputs (UR point of view), for an update frequency 10Hz
            Console.WriteLine(Ur3.Setup_Ur_Outputs(UrOutputs,10));
            Ur3.OnDataReceive += new EventHandler(Ur3_OnDataReceive);

            // Request the UR to send back Outputs periodically
            Ur3.Ur_ControlStart();

            Console.ReadKey();

            // Bye bye Robot
            Ur3.Disconnect();
        }

        static void Ur3_OnSockClosed(object sender, EventArgs e)
        {
            Console.WriteLine("Closed");
        }

        // Data change Event 
        static void Ur3_OnDataReceive(object sender, EventArgs e)
        {
            Console.WriteLine(UrOutputs.actual_q[0]);
            //Console.WriteLine(UrOutputs.actual_TCP_pose[0]);
        }
    }
}
