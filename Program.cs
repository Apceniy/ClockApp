using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static List<TimeZoneInfo> TimeZones = new List<TimeZoneInfo>();
        public static List<Alarm> Alarms = new List<Alarm>();
        public static List<Timer> Timers = new List<Timer>();
        public static List<Stopwatch> Stopwatches = new List<Stopwatch>();
    }
}
