/*

See :
https://www.universal-robots.com/how-tos-and-faqs/how-to/ur-how-tos/real-time-data-exchange-rtde-guide-22229/ 
 
BOOL : bool
UINT8 : byte
UINT32 : uint
UINT64 : ulong
INT32 : int
DOUBLE : double
VECTOR3D : double[]
VECTOR6D : double []
VECTOR6INT32 : int[]
VECTOR6UINT32 : uint[]
  
TODO and not TODO : do not declare public fields with other types & creates the array with the right size

*/
using System;



namespace DashboardComDemo
{

    [Serializable]
    public class UniversalRobot_Outputs
    {
        // public int robot_mode;

        // free private & protected attributs are allows
        // all properties and methods also (even public)
        //public double[] target_q = new double[6];
        //public double[] target_qd = new double[6];
        //public uint output_int_register_0;
        // public double io_current; // check the fields name in the RTDE guide : MUST be the same with the same type
        //public double[] actual_q = new double[6]; // array creation must be done here to give the size
        public double[] actual_TCP_pose = new double[6];
        
    }

    [Serializable]
    public class UniversalRobot_Inputs
    {
        //public byte tool_digital_output_mask;
        //public byte tool_digital_output;
        //0 --> 23 are for Field bus and modbus (probably best for sending coordinates)
        //24 --> 47 used by external RTDE clients (probably best to use to read for digital twin)
        //public double input_double_register_24;       
        //public double input_double_register_0 = 0f;
        //public double input_double_register_1 = 0f;
        //public double input_double_register_2 = 0f;
        //public double input_double_register_3 = 0f;
        //public double input_double_register_4 = 0f;
        //public double input_double_register_5 = 0f;
        //public uint input_int_register_0;
    }
}