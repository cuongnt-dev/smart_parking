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
        public const string PLC_WRITE_ENTRANCE_1_CLOSE_BR1 = "D1_1";
        public const string PLC_WRITE_ENTRANCE_1_OPEN_BR1 = "D1_2";
        public const string PLC_WRITE_ENTRANCE_1_CLOSE_BR2 = "D1_3";
        public const string PLC_WRITE_ENTRANCE_1_OPEN_BR2 = "D1_4";

        public const string PLC_WRITE_ENTRANCE_2_CLOSE_BR1 = "D1_1";
        public const string PLC_WRITE_ENTRANCE_2_OPEN_BR1 = "D1_2";
        public const string PLC_WRITE_ENTRANCE_2_CLOSE_BR2 = "D1_3";
        public const string PLC_WRITE_ENTRANCE_2_OPEN_BR2 = "D1_4";

        public const int PLC_READ_ENTRANCE_1_BR_REGISTER = 0;
        public const int PLC_READ_ENTRANCE_1_BR1C_BR2C = 6;
        public const int PLC_READ_ENTRANCE_1_BR1O_BR2O = 12;
        public const int PLC_READ_ENTRANCE_1_BR1O_BR2C = 11;
        public const int PLC_READ_ENTRANCE_1_BR1C_BR2O = 7;

        public const int PLC_READ_ENTRANCE_2_BR_REGISTER = 0;
        public const int PLC_READ_ENTRANCE_2_BR1C_BR2C = 6;
        public const int PLC_READ_ENTRANCE_2_BR1O_BR2O = 12;
        public const int PLC_READ_ENTRANCE_2_BR1O_BR2C = 11;
        public const int PLC_READ_ENTRANCE_2_BR1C_BR2O = 7;




    }
}
