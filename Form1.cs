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

namespace ClockApp
{
    public partial class Form1 : Form
    {
        private ObservableCollection<models.WorldTimeItem> items;
        public Form1()
        {
            InitializeComponent();
            items = new ObservableCollection<models.WorldTimeItem>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones();
            comboBox1.DataSource = tz;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Id";
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
            btn.Click += Btn_Click;

            gb.Controls.Add(name);
            gb.Controls.Add(time);
            gb.Controls.Add(btn);
            btn.Tag = gb;
            gb.Tag = (string)comboBox1.SelectedValue;
            flowLayoutPanel1.Controls.Add(gb);
            item.control = time;
        }
        private void RemoveTime(WorldTimeItem item)
        {
            var gb = (GroupBox)((Label)item.control).Tag;
            gb.Dispose();
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                items.Add(new WorldTimeItem() { Id = (string)comboBox1.SelectedValue });
            }
        }

        private void Btn_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var item in items)
            {
                var tz = TimeZoneInfo.GetSystemTimeZones().FirstOrDefault(i => i.Id == item.Id);
                item.control.Text = (DateTime.UtcNow + tz.BaseUtcOffset).ToString();
            }
        }
    }
}
