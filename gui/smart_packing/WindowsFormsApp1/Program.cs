using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Console.WriteLine("Execute python process...");
            Option1_ExecProcess();
            Application.Run(new Form1());
        }

        static void Option1_ExecProcess()
        {
            Console.WriteLine("Option1_ExecProcess");
            var psi = new ProcessStartInfo();
            psi.FileName = @"D:\LV\detect_plate\venv\Scripts\python.exe";
            var script = @"D:\LV\detect_plate\DaysBetweenDates.py";
            var start = "2019-1-1";
            var end = "2019-1-22";

            psi.Arguments = $"\"{script}\" \"{start}\" \"{end}\"";

            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardError = true;
            psi.RedirectStandardOutput = true;

            var errors = "";
            var results = "";

            using(var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }

            Console.WriteLine("Erroros");
            Console.WriteLine(errors);
            Console.WriteLine();

            Console.WriteLine("Results");
            Console.WriteLine(results);

        
        }

        static void Option2_IronPython()
        {
            // 1) Create engine
            var engine = Python.CreateEngine();
            // 2) Provide script and arguments
            var script = @"D:\LV\detect_plate\DaysBetweenDates.py";
            var source = engine.CreateScriptSourceFromFile(script);

            var argv = new List<string>();
            argv.Add("");
            argv.Add("2019-1-1");
            argv.Add("2019-1-22");

            engine.GetSysModule().SetVariable("argv", argv);

            // 3) Output redirect
            var eIO = engine.Runtime.IO;

            var errors = new MemoryStream();
            eIO.SetErrorOutput(errors, Encoding.Default);

            var results = new MemoryStream();
            eIO.SetOutput(results, Encoding.Default);

            // 4) Execute script
            var scope = engine.CreateScope();
            source.Execute(scope);

            // 5) Display output
            string str(byte[] x) => Encoding.Default.GetString(x);

            Console.WriteLine("ERRORS:");
            Console.WriteLine(str(errors.ToArray()));
            Console.WriteLine();
            Console.WriteLine("Results:");
            Console.WriteLine(str(results.ToArray()));

        }


    }
}
