using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    class Alarm
    {
        public TimeSpan TimeOfDay = new TimeSpan();
        public bool[] ActiveDays = { true, true, true, true, true, true, true };
        public bool IsActive = false;
        public bool IsRepeating = true;
        public string Text;
    }

    public class Timer
    {
        TimeSpan SaveTime;
        public TimeSpan InitialTime;
        public TimeSpan TimeLeft = new TimeSpan();
        public bool IsActive = true;
        public string Text;
        public GroupBox Box;
        public Label LabelTimer;
        public Button PauseBtn;
        public Button ResetBtn;

        private TimeSpan GetNowTimeSpan()
        {
            DateTime dt = DateTime.Now;
            TimeSpan result = new TimeSpan(dt.Hour, dt.Minute, dt.Second);
            return result;
        }
        public Timer()
        {
            SaveTime = GetNowTimeSpan();
        }

        public void Pause()
        {
            IsActive = false;
        
        }

        public void Unpause() 
        { 
            IsActive=true;
            SaveTime = GetNowTimeSpan();
        }

        public void TimeTick()
        {
            if(IsActive)
            {
                TimeSpan newTimeSpan = GetNowTimeSpan();
                TimeLeft -= newTimeSpan - SaveTime;
                SaveTime = newTimeSpan;
            }
        }
        public void Reset()
        {
            TimeLeft = InitialTime;
            Unpause();
            LabelTimer.Text = TimeLeft.ToString();
        }

    }

    class Stopwatch
    {
        public TimeSpan Elapsed = new TimeSpan();
        public bool IsActive = false;
        public string Title;
    }
}
