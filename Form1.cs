using ClockApp.models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ClockApp
{
    public partial class Form1 : Form
    {
        private ObservableCollection<models.WorldTimeItem> items;
        private TimeSpan zeroTimeSpan = TimeSpan.Zero;
        public Form1()
        {
            InitializeComponent();
            items = new ObservableCollection<models.WorldTimeItem>();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones();
            comboBoxAddTimezone.DataSource = tz;
            comboBoxAddTimezone.DisplayMember = "DisplayName";
            comboBoxAddTimezone.ValueMember = "Id";
            items.CollectionChanged += Items_CollectionChanged;
            timer1.Start();
        }

        private void Items_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    AddTime((WorldTimeItem)e.NewItems[0]);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    RemoveTime((WorldTimeItem)e.OldItems[0]);
                    break;
            }
        }
        private void AddTime(WorldTimeItem item)
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
            item.control = time;
        }
        private void RemoveTime(WorldTimeItem item)
        {
            var gb = (GroupBox)((Label)item.control).Tag;
            gb.Dispose();
        }

        private void buttonAddTimezone_Click(object sender, EventArgs ev)
        {
            if (comboBoxAddTimezone.SelectedIndex != -1)
            {
                items.Add(new WorldTimeItem() { Id = (string)comboBoxAddTimezone.SelectedValue });
            }
        }

        private void BtnRemoveTZ_Click(object sender, EventArgs e)
        {
            var gb = (GroupBox)((Button)sender).Tag;
            string id = (string)gb.Tag;
            var item = items.FirstOrDefault(i => i.Id == id);
            items.Remove(item);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
        //Серьгей савельев Иллюзия моделирования мозга
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                var tz = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(i => i.Id == item.Id);
                item.control.Text = (DateTime.UtcNow + tz.BaseUtcOffset).ToString();
            }
            foreach(var timer in Program.Timers)
            {
                if (timer.IsActive)
                {
                    timer.TimeTick();
                    timer.LabelTimer.Text = timer.TimeLeft.ToString();
                    if (timer.TimeLeft <= zeroTimeSpan)
                    {
                        timer.Pause();
                        //MessageBox.Show(timer.Text);
                        TimerOverForm timerOverForm = new TimerOverForm(timer);
                    }
                }
            }
        }

        private void addTimer(int hour, int minute, int seconds, string text)
        {
            GroupBox gb = new GroupBox();
            Button pauseBtn = new Button();
            Button resetBtn = new Button();

            Timer timer = new Timer()
            {
                Text = text,
                InitialTime = new TimeSpan(hour, minute, seconds),
                TimeLeft = new TimeSpan(hour, minute, seconds),
                Box= gb,
                IsActive = true,
                PauseBtn = pauseBtn,
                ResetBtn = resetBtn
            };
            Program.Timers.Add(timer);

            gb.Height = 60;
            gb.Width = 770;
            gb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            
            Label name = new Label();
            name.Text = timer.TimeLeft.ToString();
            name.Location = new Point(5, 10);
            name.Width = 300;
            name.Height = 20;
            Label time = new Label();
            time.Text = text;
            time.Location = new Point(5, 40);
            time.Width = 700;
            time.Height = 20;
            time.Tag = gb;

            Button btn = new Button();
            btn.Text = "X";
            btn.Location = new Point(740, 10);
            btn.Width = 20;
            btn.Height = 20;
            btn.Tag = gb;
            btn.Click += deleteTimer;

            
            pauseBtn.Text = "| |";
            pauseBtn.Location = new Point (700, 15);
            pauseBtn.Width = 25;
            pauseBtn.Height = 25;
            pauseBtn.Tag = timer;
            pauseBtn.Click += pauseTimerBtn_Click;

            resetBtn.Text = "R";
            resetBtn.Location = new Point(665, 15);
            resetBtn.Width = 25;
            resetBtn.Height = 25;
            resetBtn.Tag = timer;
            resetBtn.Click += resetTimerBtn_Click;

            gb.Controls.Add(name);
            gb.Controls.Add(time);
            gb.Controls.Add(btn);
            gb.Controls.Add(pauseBtn);
            gb.Controls.Add(resetBtn);
            gb.Tag = (string)comboBoxAddTimezone.SelectedValue;
            timerFlowLayoutPanel.Controls.Add(gb);

            timer.LabelTimer = name;
            //timerFlowLayoutPanel.Controls.Remove(gb);
        }

        private void resetTimerBtn_Click(object sender, EventArgs e)
        {
            Timer timer = (Timer)((Button)sender).Tag;
            timer.Reset();
            if (!timer.PauseBtn.Enabled)
            {
                timer.PauseBtn.Show();
                timer.PauseBtn.Enabled = true;
            }
        }

            private void pauseTimerBtn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender); 
            ((Timer)btn.Tag).Pause();
            btn.Text = "|>";
            btn.Click -= pauseTimerBtn_Click;
            btn.Click += unpauseTimerBtn_Click;
        }
        private void unpauseTimerBtn_Click(object sender, EventArgs e)
        {
            Button btn = ((Button)sender);
            ((Timer)btn.Tag).Unpause();
            btn.Text = "||";
            btn.Click -= unpauseTimerBtn_Click;
            btn.Click += pauseTimerBtn_Click;
        }
        private void deleteTimer(object sender, EventArgs e)
        {
            var gb = (GroupBox)((Button)sender).Tag;
            foreach (var i in Program.Timers)
            {
                if (i.Box == gb)
                {
                    Program.Timers.Remove(i);
                    break;
                }
                
            }
            timerFlowLayoutPanel.Controls.Remove(gb);
        }
        private void deleteTimer(GroupBox sender)
        {
            var gb = sender;
            foreach (var i in Program.Timers)
            {
                if (i.Box == gb)
                {
                    Program.Timers.Remove(i);
                    break;
                }

            }
            timerFlowLayoutPanel.Controls.Remove(gb);
        }
        private void timerAddButton_Click(object sender, EventArgs e)
        {
            addTimer((int)hourNumeric.Value, (int)minuteNumeric.Value, (int)secondNumeric.Value, timerMessageTextBox.Text);
        }
    }
}
