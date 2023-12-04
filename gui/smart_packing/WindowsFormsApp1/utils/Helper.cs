using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.utils
{
    internal class Helper
    {
        public static bool HasValue(string val)
        {
            if(val != null && val != "")
            {
                return true;
            }
            return false;
        }
    }
}
