using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Constant
    {
        public const string ENTRANCE_1_CAM_IN = "ENTRANCE_1_CAM_IN";
        public const string ENTRANCE_1_CAM_OUT = "ENTRANCE_1_CAM_OUT";
        public const string ENTRANCE_2_CAM_IN = "ENTRANCE_2_CAM_IN";
        public const string ENTRANCE_2_CAM_OUT = "ENTRANCE_2_CAM_OUT";

        public const string ENTRANCE_1 = "ENTRANCE_1";
        public const string ENTRANCE_2 = "ENTRANCE_2";

        public const string CHECKIN_STATE = "Checkin";
        public const string CHECKOUT_STATE = "Checkout";

        public const string PORT_NAME = "COM1";
        public const string BAUD_RATE = "9600";
        public const int ACT_LOGICAL_STATION_NUMBER = 1;

        public const string CAPTURE_PATH = "D:\\LV\\smart_parking\\detect_plate\\capture";
        public const string TEST_PLATE_PATH = "D:\\LV\\smart_parking\\detect_plate\\test";
        // 8no in D - last 3 bytes
        //  User defined byte 0 
        public const char LAST_CHAR_ENTRANCE_1 = 'e';
        //  User defined byte 1 
        public const char LAST_CHAR_ENTRANCE_2 = 'u';


        // PLC Communication
        public const string ENTRANCE_1_BARIER_1_OPEN = "M2";
        public const string ENTRANCE_1_BARIER_1_CLOSE = "M0";
        public const string ENTRANCE_1_BARIER_2_OPEN = "M3";
        public const string ENTRANCE_1_BARIER_2_CLOSE = "M1";

    }
}
