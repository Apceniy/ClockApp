﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}