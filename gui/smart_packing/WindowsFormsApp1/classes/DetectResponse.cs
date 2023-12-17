using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class DetectResponse
    {
        public string PlateExtractPath { get; set; }
        public string PlatePath { get; set; }
        public string PlateText { get; set; }

        public string Error { get; set; }

        public string FrontFilePath { get; set; }

        public string BackFilePath { get; set; }
    }
}
