using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Constant
    {
        public const string PLC_PORT_NAME = "COM8";
        public const int PLC_BAUD_RATE = 19200;
        public const int PLC_DATABIT = 7;
        public const StopBits PLC_STOPBIT = StopBits.One;
        public const Parity PLC_PARITY = Parity.Even;

        public const string ENTRANCE_1_CAM_IN = "ENTRANCE_1_CAM_IN";
        public const string ENTRANCE_1_CAM_OUT = "ENTRANCE_1_CAM_OUT";
        public const string ENTRANCE_2_CAM_IN = "ENTRANCE_2_CAM_IN";
        public const string ENTRANCE_2_CAM_OUT = "ENTRANCE_2_CAM_OUT";

        public const string ENTRANCE_1 = "ENTRANCE_1";
        public const string ENTRANCE_2 = "ENTRANCE_2";

        public const string CHECKIN_STATE = "Checkin";
        public const string CHECKOUT_STATE = "Checkout";

        public const string PORT_NAME = "COM1";
        public const int BAUD_RATE = 9600;
        public const int ACT_LOGICAL_STATION_NUMBER = 1;

        public const string CAPTURE_PATH = "D:\\LV\\smart_parking\\detect_plate\\capture";
        public const string TEST_PLATE_PATH = "D:\\LV\\smart_parking\\detect_plate\\test";
        // 8no in D - last 3 bytes
        //  User defined byte 0 
        public const char LAST_CHAR_ENTRANCE_1 = 'e';
        //  User defined byte 1 
        public const char LAST_CHAR_ENTRANCE_2 = 'u';


        // PLC Communication
        // M0
        public const Int32 ENTRANCE_1_BARIER_1_CLOSE = 0x00;
        // M2
        public const Int32 ENTRANCE_1_BARIER_1_OPEN = 0x02;
        // M3
        public const Int32 ENTRANCE_1_BARIER_2_OPEN = 0x03;
        // M1
        public const Int32 ENTRANCE_1_BARIER_2_CLOSE = 0x01;


        // M4
        public const Int32 ENTRANCE_2_BARIER_1_CLOSE = 0x04;
        // M6
        public const Int32 ENTRANCE_2_BARIER_1_OPEN = 0x06;
        // M5
        public const Int32 ENTRANCE_2_BARIER_2_OPEN = 0x05;
        // M7
        public const Int32 ENTRANCE_2_BARIER_2_CLOSE = 0x07;

        // M8
        public const Int32 ENTRANCE_1_BARIER_1_STATE = 0x08;
        // M9
        public const Int32 ENTRANCE_1_BARIER_2_STATE = 0x09;
    }
}
