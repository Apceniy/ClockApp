using System;
using System.Collections.Generic;
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
        private List<models.WorldTimeItem> items;
        public Form1()
        {
            InitializeComponent();
            items = new List<models.WorldTimeItem>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var tz = TimeZoneInfo.GetSystemTimeZones();
            comboBox1.DataSource = tz;
            comboBox1.DisplayMember = "DisplayName";
            comboBox1.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs ev)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                GroupBox gb = new GroupBox();
                gb.Height = 50;
                Label name = new Label();
                name.Text = comboBox1.SelectedText;
                name.Location = new Point(5, 5);
                Label time = new Label();
                time.Text = "Время";
                time.Location = new Point(5, 20);                

                gb.Controls.Add(name);
                gb.Controls.Add(time);

                flowLayoutPanel1.Controls.Add(gb);
                items.Add(new models.WorldTimeItem { Id = (string)comboBox1.SelectedValue });
            }
        }
    }
}
