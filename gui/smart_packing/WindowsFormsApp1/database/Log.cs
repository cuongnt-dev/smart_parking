﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.database
{
    public class Log
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public DateTime Occurrence { get; set; }
        public int UserID { get; set; }
    }
}
