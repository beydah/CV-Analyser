using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Analyser.Engine
{
    internal class App
    {
        public static void Browser_Start(string URL) { Process.Start("cmd", $"/c start {URL}"); }
    }
}
