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

        static public int ReadFrom(Int32 addr)
        {
            byte addrByte = Convert.ToByte(addr);
            byte[] data = new byte[2];

            // Construct FXGP/WIN read command for M0
            byte[] readCommand = new byte[] {
                0x03, // Read/Write command code
                0x00, // Starting address (MSB)
                addrByte, // Starting address (LSB)
                0x02, // Data length (2 bytes)
                0x02, // Memory area code (M-area)
            };

            // Send FXGP/WIN read command to PLC
            sp.Write(readCommand, 0, readCommand.Length);

            // Read data response from PLC
            int bytesRead = sp.Read(data, 0, 2);

            // Process received data
            if (bytesRead == 2)
            {
                // Convert data to integer
                int value = BitConverter.ToInt16(data, 0);
                Console.WriteLine("Value at M0: " + value);
                return value;
            }
            else
            {
                Console.WriteLine("Error reading data from M0");
                return 0;
            }


        }

        static public void WriteTo(byte address, byte bitValue)
        {
            // Validate address range
            if (address < 0x00 || address > 0x09)
            {
                throw new ArgumentOutOfRangeException("address", "Address must be between 0x00 and 0x09");
            }

            // Validate bit value
            if (bitValue != 0 && bitValue != 1)
            {
                throw new ArgumentOutOfRangeException("bitValue", "Bit value must be 0 or 1");
            }

            // Read the current value of the memory location
            byte[] data = new byte[1];
            byte[] readCommand = new byte[] {
                0x03, // Read/Write command code
                0x00, // Starting address (MSB)
                        address, // Starting address (LSB)
                0x01, // Data length (1 byte)
                0x02, // Memory area code (M-area)
            };
            sp.Write(readCommand, 0, readCommand.Length);
            int bytesRead = sp.Read(data, 0, 1);

            // Modify the desired bit and construct the write command
            if (bytesRead == 1)
            {
                // Modify the desired bit
                if (bitValue == 1)
                {
                    byte bitMask = (byte)(1 << address); // Cast to byte
                    data[0] |= bitMask; // Set bit at address to 1
                }
                else
                {
                    byte bitMask = (byte)(~(1 << address)); // Cast to byte
                    data[0] &= bitMask; // Perform bitwise AND
                }

                // Construct write command
                byte[] writeCommand = new byte[] {
            0x03, // Write operation code
            0x00, // Starting address (MSB)
                    address, // Starting address (LSB)
            0x01, // Data length (1 byte)
            0x02, // Memory area code (M-area)
            data[0] // Data byte
        };

                // Send write command to PLC
                sp.Write(writeCommand, 0, writeCommand.Length);
            }
            else
            {
                Console.WriteLine("Error reading data from M" + address);
            }
        }
    }
}
