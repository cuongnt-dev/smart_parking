using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationPLCMitsubishiFX;
using System.IO.Ports;
using System.Net;
using WindowsFormsApp1.utils;

namespace WindowsFormsApp1.classes
{
    public class PLC
    {
        static public CommunicationPLCMitsubishiFX.CommunicationPLCMitsubishiFX plc;
        static int[] datawrite = new int[4];

        static public void Connect()
        {
            try
            {
                if(plc == null)
                {
                    plc = new CommunicationPLCMitsubishiFX.CommunicationPLCMitsubishiFX(Constant.PLC_PORT_NAME, Constant.PLC_BAUD_RATE, Constant.PLC_DATABIT , Constant.PLC_STOPBIT , Constant.PLC_PARITY);
                }
                plc.Connect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        static public void Disconnect()
        {
            try
            {
                plc.Disconnect();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        static public bool IsRunning()
        {
            return plc != null;
        }

        static public int ReadFrom(int register)
        {
            int[] data = new int[4];
            data = plc.Read();
            if (data != null)
            {
                return data[register];
            }
            return 0;
        }

        static public void WriteTo(string action)
        {
            (int register , int value) = Hash.ExtractRegister(action);
            datawrite[register] = value;
            plc.Write(datawrite);
        }
    }
}
