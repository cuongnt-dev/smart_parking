using ActUtlTypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunicationPLCMitsubishiFX;
using System.IO.Ports;
using System.Net;

namespace WindowsFormsApp1.classes
{
    public class PLC
    {
        static public SerialPort sp = null;

        private int DELAY = 10;

        /*static public PLC()
        {
            try
                sp = new SerialPort(Constant.PLC_PORT_NAME, Constant.PLC_BAUD_RATE, Constant.PLC_PARITY, Constant.PLC_DATABIT, Constant.PLC_STOPBIT);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/

        // static public ActUtlType plc;
        static public CommunicationPLCMitsubishiFX.CommunicationPLCMitsubishiFX plc;

        /*static public void Connect(int actLogicalStationNumber)
        {
            *//*plc = new ActUtlType();
            try
            {
                plc.ActLogicalStationNumber = actLogicalStationNumber;
                plc.Open();
            }
            catch (Exception ex)
            {
                plc = null;
                System.Windows.Forms.MessageBox.Show($"Error when connect to PLC {ex}");
            }*//*
            plc = new CommunicationPLCMitsubishiFX.CommunicationPLCMitsubishiFX(
                Constant.PLC_PORT_NAME, 
                Constant.PLC_BAUD_RATE, 
                Constant.PLC_DATABIT, 
                Constant.PLC_STOPBIT, 
                Constant.PLC_PARITY);
            try
            {
                plc.Connect();
            }
            catch (Exception ex)
            {
                plc = null;
                System.Windows.Forms.MessageBox.Show($"Error when connect to PLC {ex}");
            }
        }*/

        static public void Connect()
        {
            try
            {
                if(sp == null)
                {
                    sp = new SerialPort(Constant.PLC_PORT_NAME, Constant.PLC_BAUD_RATE, Constant.PLC_PARITY, Constant.PLC_DATABIT, Constant.PLC_STOPBIT);
                }
                if (sp.IsOpen)
                {
                    sp.Close();
                }
                sp.Open();
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
                if (sp.IsOpen)
                {
                    sp.Close();
                }
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

        static public bool ReadFrom(Int32 addr)
        {
            byte[] readCommand = new byte[] {
                0x03, // Read/Write command code
                0x00, // Starting address (MSB)
                0x00, // Starting address (LSB)
                (byte)addr, // Data length (1 byte)
                0x02, // Memory area code (M-area)
            };

            // Send the read command to the PLC
            sp.Write(readCommand, 0, readCommand.Length);

            // Read data response from the PLC
            byte[] data = new byte[1];
            int bytesRead = sp.Read(data, 0, 1);

            // Extract bit value from received data
            bool bitValue = (data[0] & 0x01) == 1;
            return bitValue;

        }

        static public void WriteTo(byte address, bool bitValue)
        {
            // Construct FXGP/WIN write command for M0
            byte[] writeCommand = new byte[] {
                0x03, // Write operation code
                0x00, // Starting address (MSB)
                address, // Starting address (LSB)
                0x01, // Data length (1 byte)
                0x02, // Memory area code (M-area)
                bitValue ? (byte)0x01 : (byte)0x00 // Set bit value based on bitValue
            };

            // Send the write command to the PLC
            sp.Write(writeCommand, 0, writeCommand.Length);
        }
    }
}
