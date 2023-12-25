using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones();
            comboBoxAddTimezone.DataSource = tz;
            comboBoxAddTimezone.DisplayMember = "DisplayName";
            comboBoxAddTimezone.ValueMember = "Id";
            Program.TimeZones.CollectionChanged += Items_CollectionChanged;
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1010 - DateTime.Now.Millisecond);
                this.Invoke(new Action(timer1.Start));
            });
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    AddTime((WorldTime)e.NewItems[0]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    RemoveTime((WorldTime)e.OldItems[0]);
                    break;
            }
        }
        private void AddTime(WorldTime item)
        {
            string tzName = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(i => i.Id == item.Id).DisplayName;
            GroupBox gb = new GroupBox();
            gb.Height = 50;
            gb.Width = 770;
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label name = new Label();
            name.Text = tzName;
            name.Location = new Point(5, 10);
            name.Width = 700;
            name.Height = 20;
            Label time = new Label();
            time.Text = "";
            time.Location = new Point(5, 30);
            time.Width = 700;
            time.Height = 20;
            time.Tag = gb;
            Button btn = new Button();
            btn.Text = "X";
            btn.Location = new Point(740, 10);
            btn.Width = 20;
            btn.Height = 20;
            btn.Tag = gb;
            btn.Click += BtnRemoveTZ_Click;

            gb.Controls.Add(name);
            gb.Controls.Add(time);
            gb.Controls.Add(btn);
            gb.Tag = (string)comboBoxAddTimezone.SelectedValue;
            flowLayoutPanelTimezones.Controls.Add(gb);
            item.Control = time;
            UpdateText(item);
        }
        private void RemoveTime(WorldTime item)
        {
            var gb = (GroupBox)((Label)item.Control).Tag;
            gb.Dispose();
        }

        private void ButtonAddTimezone_Click(object sender, EventArgs ev)
        {
            if (comboBoxAddTimezone.SelectedIndex != -1)
            {
                Program.TimeZones.Add(new WorldTime() { Id = (string)comboBoxAddTimezone.SelectedValue });
            }
        }

        private void BtnRemoveTZ_Click(object sender, EventArgs e)
        {
            var gb = (GroupBox)((Button)sender).Tag;
            string id = (string)gb.Tag;
            var item = Program.TimeZones.FirstOrDefault(i => i.Id == id);
            Program.TimeZones.Remove(item);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.TimeZones.ToList().ForEach(UpdateText);

            foreach(var i in Program.Alarms)
            {
                i.Tick();
            }

        }

        private void UpdateText(WorldTime item)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(i => i.Id == item.Id);
            item.Control.Text = (DateTime.UtcNow + tz.BaseUtcOffset).ToString();
        }


        //Будильник
        
        private void buttonGroupSetAlarm_Click(object sender, EventArgs e)
        {
            bool[] checkBoxWeek = { checkBoxWeekMonday.Checked,
                checkBoxWeekTuesday.Checked,
                checkBoxWeekWednesday.Checked,
                checkBoxWeekThursday.Checked,
                checkBoxWeekFriday.Checked,
                checkBoxWeekSaturday.Checked,
                checkBoxWeekSunday.Checked};
            AddAlarm((int)AlarmNumericUpDownHour.Value,
                (int)AlarmNumericUpDownMinute.Value,
                textBoxAlarm.Text,
                checkBoxWeek
                );
        }
        private void AddAlarm(int hour, int minute, string message, bool[]week)
        {
            TimeSpan AlarmTime = new TimeSpan(hour, minute, 0);
            GroupBox gb = new GroupBox();
            Label name = new Label();
            Label time = new Label();

            Alarm alarm = new Alarm()
            {
                AlarmGroupBox = gb,
                TimeOfDay = AlarmTime,
                ActiveDays = week,
                Text = message,
                LabelMessage = time,
                LabelTime = name,
                RealTime = AlarmTime
            };

            Program.Alarms.Add(alarm);

            gb.Height = 50;
            gb.Width = 770;
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            
            name.Text = AlarmTime.ToString();
            name.Location = new Point(5, 10);
            name.Width = 280;
            name.Height = 20;
            time.Text = message;
            time.Location = new Point(5, 30);
            time.Width = 280;
            time.Height = 20;
            time.Tag = gb;

            Label monlabel = new Label();
            monlabel.Text = "Mon";
            monlabel.Location = new Point(300, 10);
            monlabel.Width = 30;
            monlabel.Height = 20;
            CheckBox mcb = new CheckBox();
            mcb.Location = new Point(300,30);
            mcb.Width = 20;
            mcb.Height = 20;
            mcb.Checked = week[0];
            mcb.Tag = alarm;
            mcb.Click += MondayCheckBox_Click;

            Label tuelabel = new Label();
            tuelabel.Text = "Tue";
            tuelabel.Location = new Point(330, 10);
            tuelabel.Width = 30;
            tuelabel.Height = 20;
            CheckBox tcb = new CheckBox();
            tcb.Location = new Point(330, 30);
            tcb.Width = 20;
            tcb.Height = 20;
            tcb.Checked = week[1];
            tcb.Tag = alarm;
            tcb.Click += TuesdayCheckBox_Click;

            Label wedlabel = new Label();
            wedlabel.Text = "Wed";
            wedlabel.Location = new Point(360, 10);
            wedlabel.Width = 30;
            wedlabel.Height = 20;
            CheckBox wcb = new CheckBox();
            wcb.Location = new Point(360, 30);
            wcb.Width = 20;
            wcb.Height = 20;
            wcb.Checked = week[2];
            wcb.Tag = alarm;
            wcb.Click += WednesdayCheckBox_Click;

            Label thulabel = new Label();
            thulabel.Text = "Thu";
            thulabel.Location = new Point(390, 10);
            thulabel.Width = 30;
            thulabel.Height = 20;
            CheckBox thcb = new CheckBox();
            thcb.Location = new Point(390, 30);
            thcb.Width = 20;
            thcb.Height = 20;
            thcb.Checked = week[3];
            thcb.Tag = alarm;
            thcb.Click += ThursdayCheckBox_Click;

            Label frilabel = new Label();
            frilabel.Text = "Fri";
            frilabel.Location = new Point(420, 10);
            frilabel.Width = 30;
            frilabel.Height = 20;
            CheckBox fcb = new CheckBox();
            fcb.Location = new Point(420, 30);
            fcb.Width = 20;
            fcb.Height = 20;
            fcb.Checked = week[4];
            fcb.Tag = alarm;
            fcb.Click += FridayCheckBox_Click;

            Label satlabel = new Label();
            satlabel.Text = "Sat";
            satlabel.Location = new Point(450, 10);
            satlabel.Width = 30;
            satlabel.Height = 20;
            CheckBox scb = new CheckBox();
            scb.Location = new Point(450, 30);
            scb.Width = 20;
            scb.Height = 20;
            scb.Checked = week[5];
            scb.Tag = alarm;
            scb.Click += SaturdayCheckBox_Click;

            Label sunlabel = new Label();
            sunlabel.Text = "Sun";
            sunlabel.Location = new Point(480, 10);
            sunlabel.Width = 30;
            sunlabel.Height = 20;
            CheckBox sndcb = new CheckBox();
            sndcb.Location = new Point(480, 30);
            sndcb.Width = 20;
            sndcb.Height = 20;
            sndcb.Checked = week[6];
            sndcb.Tag = alarm;
            sndcb.Click += SundayCheckBox_Click;


            Button btn = new Button();
            btn.Text = "X";
            btn.Location = new Point(740, 10);
            btn.Width = 20;
            btn.Height = 20;
            btn.Tag = gb;
            btn.Click += ButtonRemoveAlarm;
            

            gb.Controls.Add(name);
            gb.Controls.Add(time);
            gb.Controls.Add(btn);
            gb.Controls.Add(monlabel);
            gb.Controls.Add(mcb);
            gb.Controls.Add(tuelabel);
            gb.Controls.Add(tcb);
            gb.Controls.Add(wedlabel);
            gb.Controls.Add(wcb);
            gb.Controls.Add(thulabel);
            gb.Controls.Add(thcb);
            gb.Controls.Add(frilabel);
            gb.Controls.Add(fcb);
            gb.Controls.Add(satlabel);
            gb.Controls.Add(scb);
            gb.Controls.Add(sunlabel);
            gb.Controls.Add(sndcb);
            gb.Tag = (Alarm)alarm;

            AlarmflowLayoutPanel.Controls.Add(gb);
        }

        private void MondayCheckBox_Click (object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[0] = mcb.Checked;
        }
        private void TuesdayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[1] = mcb.Checked;
        }
        private void WednesdayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[2] = mcb.Checked;
        }
        private void ThursdayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[3] = mcb.Checked;
        }
        private void FridayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[4] = mcb.Checked;
        }
        private void SaturdayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[5] = mcb.Checked;
        }
        private void SundayCheckBox_Click(object sender, EventArgs e)
        {
            CheckBox mcb = (CheckBox)sender;
            Alarm alarm = (mcb).Tag as Alarm;
            alarm.ActiveDays[6] = mcb.Checked;
        }
        private void ButtonRemoveAlarm(object sender, EventArgs e)
        {
            var gb = (GroupBox)((Button)sender).Tag;
            foreach (var i in Program.Alarms)
            {
                if(i == (Alarm)gb.Tag)
                {
                    Program.Alarms.Remove(i);
                    break;
                }
            }
            AlarmflowLayoutPanel.Controls.Remove(gb);
        }
    }
}
