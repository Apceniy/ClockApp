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
        }

        private void UpdateText(WorldTime item)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(i => i.Id == item.Id);
            item.Control.Text = (DateTime.UtcNow + tz.BaseUtcOffset).ToString();
        }
    }
}
