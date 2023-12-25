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
    public partial class TimerOverForm : Form
    {
        Timer timer;
        public TimerOverForm(Timer timer)
        {
            InitializeComponent();
            this.FormClosing += TimerOverForm_FormClosing;
            this.timer = timer;
            TimerTextLabel.Text = timer.Text;
            ResetBtnHide();
            PauseBtnHide();
            this.Show();
        }

        void ResetBtnShow()
        {
            timer.ResetBtn.Show();
            timer.ResetBtn.Enabled = true;
        }
        void ResetBtnHide()
        {
            timer.ResetBtn.Hide();
            timer.ResetBtn.Enabled = false;
        }
        void PauseBtnShow()
        {
            timer.PauseBtn.Show();
            timer.PauseBtn.Enabled = true;
        }
        void PauseBtnHide()
        {
            timer.PauseBtn.Hide();
            timer.PauseBtn.Enabled = false;
        }
        private void TimerOverForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetBtnShow();
        }

        private void TimerOverResetBtn_Click(object sender, EventArgs e)
        {
            timer.Reset();
            timer.IsActive = true;
            ResetBtnShow();
            PauseBtnShow();
            this.Close();
        }

        private void TimerOverCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ResetBtnShow();
        }
    }
}
