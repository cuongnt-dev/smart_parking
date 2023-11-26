using ActUtlTypeLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.classes
{
    public class PLC
    {
        static public ActUtlType plc;
        static public void Connect(int actLogicalStationNumber)
        {
            plc = new ActUtlType();
            try
            {
                plc.ActLogicalStationNumber = actLogicalStationNumber;
                plc.Open();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show($"Error when connect to PLC {ex}");
            }
        }

        static public int ReadFrom(string addr)
        {
            int readInt;
            plc.GetDevice(addr, out readInt);
            return readInt;

        }

        static public void WriteTo(string addr, int writeInt)
        {
            plc.SetDevice(addr, writeInt);
        }
    }
}
