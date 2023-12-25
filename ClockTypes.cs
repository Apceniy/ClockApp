using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ClockApp
{
    class WorldTime
    {
        public string Id { set; get; }
        public System.Windows.Forms.Control Control { set; get; }
    }

    class Alarm
    {
        public Label LabelTime;
        public Label LabelMessage;
        public TimeSpan TimeOfDay = new TimeSpan();
        public TimeSpan RealTime = new TimeSpan();
        public bool[] ActiveDays = { true, true, true, true, true, true, true };
        public bool IsActive = true;
        public bool IsRepeating = true;
        public string Text;
        public GroupBox AlarmGroupBox;
        
        public void Tick()
        {
            if (IsActive)
            {
                DateTime time = DateTime.Now;
                if ((time.DayOfWeek == DayOfWeek.Monday && ActiveDays[0]) ||
                    (time.DayOfWeek == DayOfWeek.Tuesday && ActiveDays[1]) ||
                    (time.DayOfWeek == DayOfWeek.Wednesday && ActiveDays[2]) ||
                    (time.DayOfWeek == DayOfWeek.Thursday && ActiveDays[3]) ||
                    (time.DayOfWeek == DayOfWeek.Friday && ActiveDays[4]) ||
                    (time.DayOfWeek == DayOfWeek.Saturday && ActiveDays[5]) ||
                    (time.DayOfWeek == DayOfWeek.Sunday && ActiveDays[6]) )
                {
                    TimeSpan now = new TimeSpan(time.Hour, time.Minute, time.Second);
                    if (now == RealTime)
                    {
                        MessageBox.Show(Text);
                    }
                } 
            }
        }
    }

    class Timer
    {
        public TimeSpan InitialTime;
        public TimeSpan TimeLeft = new TimeSpan();
        public bool IsActive = false;
        public string Text;
    }

    class Stopwatch
    {
        public TimeSpan Elapsed = new TimeSpan();
        public bool IsActive = false;
        public string Title;
    }
}
