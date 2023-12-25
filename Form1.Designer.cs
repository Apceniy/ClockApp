
namespace ClockApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClocks = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelTimezones = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxAddTimezone = new System.Windows.Forms.GroupBox();
            this.buttonAddTimezone = new System.Windows.Forms.Button();
            this.comboBoxAddTimezone = new System.Windows.Forms.ComboBox();
            this.tabPageAlarms = new System.Windows.Forms.TabPage();
            this.AlarmflowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxMain = new System.Windows.Forms.GroupBox();
            this.AlarmNumericUpDownMinute = new System.Windows.Forms.NumericUpDown();
            this.AlarmNumericUpDownHour = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSnooze = new System.Windows.Forms.CheckBox();
            this.comboBoxAlarmRepeat = new System.Windows.Forms.ComboBox();
            this.checkBoxWeekSunday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekSaturday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekFriday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekThursday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekWednesday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekTuesday = new System.Windows.Forms.CheckBox();
            this.checkBoxWeekMonday = new System.Windows.Forms.CheckBox();
            this.groupDevider = new System.Windows.Forms.Label();
            this.groupMessageBox = new System.Windows.Forms.Label();
            this.buttonGroupSetAlarm = new System.Windows.Forms.Button();
            this.textBoxAlarm = new System.Windows.Forms.TextBox();
            this.groupHour = new System.Windows.Forms.Label();
            this.groupMinute = new System.Windows.Forms.Label();
            this.tabPageCountdowns = new System.Windows.Forms.TabPage();
            this.tabPageStopwatches = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPageClocks.SuspendLayout();
            this.groupBoxAddTimezone.SuspendLayout();
            this.tabPageAlarms.SuspendLayout();
            this.groupBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmNumericUpDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmNumericUpDownHour)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageClocks);
            this.tabControl1.Controls.Add(this.tabPageAlarms);
            this.tabControl1.Controls.Add(this.tabPageCountdowns);
            this.tabControl1.Controls.Add(this.tabPageStopwatches);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1203, 695);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageClocks
            // 
            this.tabPageClocks.Controls.Add(this.flowLayoutPanelTimezones);
            this.tabPageClocks.Controls.Add(this.groupBoxAddTimezone);
            this.tabPageClocks.Location = new System.Drawing.Point(4, 29);
            this.tabPageClocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageClocks.Name = "tabPageClocks";
            this.tabPageClocks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageClocks.Size = new System.Drawing.Size(1195, 662);
            this.tabPageClocks.TabIndex = 0;
            this.tabPageClocks.Text = "Мировое время";
            this.tabPageClocks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTimezones
            // 
            this.flowLayoutPanelTimezones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTimezones.Location = new System.Drawing.Point(14, 86);
            this.flowLayoutPanelTimezones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanelTimezones.Name = "flowLayoutPanelTimezones";
            this.flowLayoutPanelTimezones.Size = new System.Drawing.Size(1162, 554);
            this.flowLayoutPanelTimezones.TabIndex = 1;
            // 
            // groupBoxAddTimezone
            // 
            this.groupBoxAddTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddTimezone.Controls.Add(this.buttonAddTimezone);
            this.groupBoxAddTimezone.Controls.Add(this.comboBoxAddTimezone);
            this.groupBoxAddTimezone.Location = new System.Drawing.Point(4, 9);
            this.groupBoxAddTimezone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAddTimezone.Name = "groupBoxAddTimezone";
            this.groupBoxAddTimezone.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxAddTimezone.Size = new System.Drawing.Size(1172, 68);
            this.groupBoxAddTimezone.TabIndex = 0;
            this.groupBoxAddTimezone.TabStop = false;
            this.groupBoxAddTimezone.Text = "Добавление новой временной зоны";
            // 
            // buttonAddTimezone
            // 
            this.buttonAddTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTimezone.Location = new System.Drawing.Point(1036, 25);
            this.buttonAddTimezone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddTimezone.Name = "buttonAddTimezone";
            this.buttonAddTimezone.Size = new System.Drawing.Size(112, 35);
            this.buttonAddTimezone.TabIndex = 1;
            this.buttonAddTimezone.Text = "Добавить";
            this.buttonAddTimezone.UseVisualStyleBackColor = true;
            this.buttonAddTimezone.Click += new System.EventHandler(this.ButtonAddTimezone_Click);
            // 
            // comboBoxAddTimezone
            // 
            this.comboBoxAddTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAddTimezone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAddTimezone.FormattingEnabled = true;
            this.comboBoxAddTimezone.Location = new System.Drawing.Point(9, 26);
            this.comboBoxAddTimezone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxAddTimezone.Name = "comboBoxAddTimezone";
            this.comboBoxAddTimezone.Size = new System.Drawing.Size(1016, 28);
            this.comboBoxAddTimezone.TabIndex = 0;
            // 
            // tabPageAlarms
            // 
            this.tabPageAlarms.Controls.Add(this.AlarmflowLayoutPanel);
            this.tabPageAlarms.Controls.Add(this.groupBoxMain);
            this.tabPageAlarms.Location = new System.Drawing.Point(4, 29);
            this.tabPageAlarms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAlarms.Name = "tabPageAlarms";
            this.tabPageAlarms.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAlarms.Size = new System.Drawing.Size(1195, 662);
            this.tabPageAlarms.TabIndex = 1;
            this.tabPageAlarms.Text = "Будильники";
            this.tabPageAlarms.UseVisualStyleBackColor = true;
            // 
            // AlarmflowLayoutPanel
            // 
            this.AlarmflowLayoutPanel.Location = new System.Drawing.Point(7, 289);
            this.AlarmflowLayoutPanel.Name = "AlarmflowLayoutPanel";
            this.AlarmflowLayoutPanel.Size = new System.Drawing.Size(1177, 365);
            this.AlarmflowLayoutPanel.TabIndex = 6;
            // 
            // groupBoxMain
            // 
            this.groupBoxMain.Controls.Add(this.AlarmNumericUpDownMinute);
            this.groupBoxMain.Controls.Add(this.AlarmNumericUpDownHour);
            this.groupBoxMain.Controls.Add(this.checkBoxSnooze);
            this.groupBoxMain.Controls.Add(this.comboBoxAlarmRepeat);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekSunday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekSaturday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekFriday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekThursday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekWednesday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekTuesday);
            this.groupBoxMain.Controls.Add(this.checkBoxWeekMonday);
            this.groupBoxMain.Controls.Add(this.groupDevider);
            this.groupBoxMain.Controls.Add(this.groupMessageBox);
            this.groupBoxMain.Controls.Add(this.buttonGroupSetAlarm);
            this.groupBoxMain.Controls.Add(this.textBoxAlarm);
            this.groupBoxMain.Controls.Add(this.groupHour);
            this.groupBoxMain.Controls.Add(this.groupMinute);
            this.groupBoxMain.Location = new System.Drawing.Point(8, 52);
            this.groupBoxMain.Name = "groupBoxMain";
            this.groupBoxMain.Size = new System.Drawing.Size(1176, 217);
            this.groupBoxMain.TabIndex = 5;
            this.groupBoxMain.TabStop = false;
            this.groupBoxMain.Text = "Alarm";
            // 
            // AlarmNumericUpDownMinute
            // 
            this.AlarmNumericUpDownMinute.Location = new System.Drawing.Point(194, 60);
            this.AlarmNumericUpDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.AlarmNumericUpDownMinute.Name = "AlarmNumericUpDownMinute";
            this.AlarmNumericUpDownMinute.Size = new System.Drawing.Size(120, 26);
            this.AlarmNumericUpDownMinute.TabIndex = 21;
            // 
            // AlarmNumericUpDownHour
            // 
            this.AlarmNumericUpDownHour.Location = new System.Drawing.Point(39, 60);
            this.AlarmNumericUpDownHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.AlarmNumericUpDownHour.Name = "AlarmNumericUpDownHour";
            this.AlarmNumericUpDownHour.Size = new System.Drawing.Size(120, 26);
            this.AlarmNumericUpDownHour.TabIndex = 20;
            // 
            // checkBoxSnooze
            // 
            this.checkBoxSnooze.AutoSize = true;
            this.checkBoxSnooze.Location = new System.Drawing.Point(508, 96);
            this.checkBoxSnooze.Name = "checkBoxSnooze";
            this.checkBoxSnooze.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSnooze.Size = new System.Drawing.Size(92, 24);
            this.checkBoxSnooze.TabIndex = 19;
            this.checkBoxSnooze.Text = "Повтор";
            this.checkBoxSnooze.UseVisualStyleBackColor = true;
            // 
            // comboBoxAlarmRepeat
            // 
            this.comboBoxAlarmRepeat.FormattingEnabled = true;
            this.comboBoxAlarmRepeat.Location = new System.Drawing.Point(489, 126);
            this.comboBoxAlarmRepeat.Name = "comboBoxAlarmRepeat";
            this.comboBoxAlarmRepeat.Size = new System.Drawing.Size(121, 28);
            this.comboBoxAlarmRepeat.TabIndex = 17;
            // 
            // checkBoxWeekSunday
            // 
            this.checkBoxWeekSunday.AutoSize = true;
            this.checkBoxWeekSunday.Location = new System.Drawing.Point(848, 56);
            this.checkBoxWeekSunday.Name = "checkBoxWeekSunday";
            this.checkBoxWeekSunday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekSunday.Size = new System.Drawing.Size(64, 24);
            this.checkBoxWeekSunday.TabIndex = 14;
            this.checkBoxWeekSunday.Text = "Sun";
            this.checkBoxWeekSunday.UseMnemonic = false;
            this.checkBoxWeekSunday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekSaturday
            // 
            this.checkBoxWeekSaturday.AutoSize = true;
            this.checkBoxWeekSaturday.Location = new System.Drawing.Point(764, 56);
            this.checkBoxWeekSaturday.Name = "checkBoxWeekSaturday";
            this.checkBoxWeekSaturday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekSaturday.Size = new System.Drawing.Size(60, 24);
            this.checkBoxWeekSaturday.TabIndex = 13;
            this.checkBoxWeekSaturday.Text = "Sat";
            this.checkBoxWeekSaturday.UseMnemonic = false;
            this.checkBoxWeekSaturday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekFriday
            // 
            this.checkBoxWeekFriday.AutoSize = true;
            this.checkBoxWeekFriday.Location = new System.Drawing.Point(683, 56);
            this.checkBoxWeekFriday.Name = "checkBoxWeekFriday";
            this.checkBoxWeekFriday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekFriday.Size = new System.Drawing.Size(53, 24);
            this.checkBoxWeekFriday.TabIndex = 12;
            this.checkBoxWeekFriday.Text = "Fri";
            this.checkBoxWeekFriday.UseMnemonic = false;
            this.checkBoxWeekFriday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekThursday
            // 
            this.checkBoxWeekThursday.AutoSize = true;
            this.checkBoxWeekThursday.Location = new System.Drawing.Point(598, 56);
            this.checkBoxWeekThursday.Name = "checkBoxWeekThursday";
            this.checkBoxWeekThursday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekThursday.Size = new System.Drawing.Size(62, 24);
            this.checkBoxWeekThursday.TabIndex = 11;
            this.checkBoxWeekThursday.Text = "Thu";
            this.checkBoxWeekThursday.UseMnemonic = false;
            this.checkBoxWeekThursday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekWednesday
            // 
            this.checkBoxWeekWednesday.AutoSize = true;
            this.checkBoxWeekWednesday.Location = new System.Drawing.Point(508, 56);
            this.checkBoxWeekWednesday.Name = "checkBoxWeekWednesday";
            this.checkBoxWeekWednesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekWednesday.Size = new System.Drawing.Size(68, 24);
            this.checkBoxWeekWednesday.TabIndex = 10;
            this.checkBoxWeekWednesday.Text = "Wed";
            this.checkBoxWeekWednesday.UseMnemonic = false;
            this.checkBoxWeekWednesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekTuesday
            // 
            this.checkBoxWeekTuesday.AutoSize = true;
            this.checkBoxWeekTuesday.Location = new System.Drawing.Point(428, 56);
            this.checkBoxWeekTuesday.Name = "checkBoxWeekTuesday";
            this.checkBoxWeekTuesday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekTuesday.Size = new System.Drawing.Size(62, 24);
            this.checkBoxWeekTuesday.TabIndex = 9;
            this.checkBoxWeekTuesday.Text = "Tue";
            this.checkBoxWeekTuesday.UseVisualStyleBackColor = true;
            // 
            // checkBoxWeekMonday
            // 
            this.checkBoxWeekMonday.AutoSize = true;
            this.checkBoxWeekMonday.Location = new System.Drawing.Point(344, 56);
            this.checkBoxWeekMonday.Name = "checkBoxWeekMonday";
            this.checkBoxWeekMonday.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxWeekMonday.Size = new System.Drawing.Size(66, 24);
            this.checkBoxWeekMonday.TabIndex = 8;
            this.checkBoxWeekMonday.Text = "Mon";
            this.checkBoxWeekMonday.UseVisualStyleBackColor = true;
            // 
            // groupDevider
            // 
            this.groupDevider.AutoSize = true;
            this.groupDevider.Location = new System.Drawing.Point(175, 60);
            this.groupDevider.Name = "groupDevider";
            this.groupDevider.Size = new System.Drawing.Size(13, 20);
            this.groupDevider.TabIndex = 6;
            this.groupDevider.Text = ":";
            // 
            // groupMessageBox
            // 
            this.groupMessageBox.AutoSize = true;
            this.groupMessageBox.Location = new System.Drawing.Point(128, 160);
            this.groupMessageBox.Name = "groupMessageBox";
            this.groupMessageBox.Size = new System.Drawing.Size(96, 20);
            this.groupMessageBox.TabIndex = 5;
            this.groupMessageBox.Text = "Сообщение";
            // 
            // buttonGroupSetAlarm
            // 
            this.buttonGroupSetAlarm.Location = new System.Drawing.Point(1025, 90);
            this.buttonGroupSetAlarm.Name = "buttonGroupSetAlarm";
            this.buttonGroupSetAlarm.Size = new System.Drawing.Size(119, 39);
            this.buttonGroupSetAlarm.TabIndex = 4;
            this.buttonGroupSetAlarm.Text = "Add alarm";
            this.buttonGroupSetAlarm.UseVisualStyleBackColor = true;
            this.buttonGroupSetAlarm.Click += new System.EventHandler(this.buttonGroupSetAlarm_Click);
            // 
            // textBoxAlarm
            // 
            this.textBoxAlarm.Location = new System.Drawing.Point(26, 122);
            this.textBoxAlarm.Name = "textBoxAlarm";
            this.textBoxAlarm.Size = new System.Drawing.Size(312, 26);
            this.textBoxAlarm.TabIndex = 4;
            // 
            // groupHour
            // 
            this.groupHour.AutoSize = true;
            this.groupHour.Location = new System.Drawing.Point(67, 34);
            this.groupHour.Name = "groupHour";
            this.groupHour.Size = new System.Drawing.Size(38, 20);
            this.groupHour.TabIndex = 0;
            this.groupHour.Text = "Час";
            // 
            // groupMinute
            // 
            this.groupMinute.AutoSize = true;
            this.groupMinute.Location = new System.Drawing.Point(249, 34);
            this.groupMinute.Name = "groupMinute";
            this.groupMinute.Size = new System.Drawing.Size(65, 20);
            this.groupMinute.TabIndex = 1;
            this.groupMinute.Text = "Минута";
            // 
            // tabPageCountdowns
            // 
            this.tabPageCountdowns.Location = new System.Drawing.Point(4, 29);
            this.tabPageCountdowns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageCountdowns.Name = "tabPageCountdowns";
            this.tabPageCountdowns.Size = new System.Drawing.Size(1195, 662);
            this.tabPageCountdowns.TabIndex = 2;
            this.tabPageCountdowns.Text = "Таймеры";
            this.tabPageCountdowns.UseVisualStyleBackColor = true;
            // 
            // tabPageStopwatches
            // 
            this.tabPageStopwatches.Location = new System.Drawing.Point(4, 29);
            this.tabPageStopwatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageStopwatches.Name = "tabPageStopwatches";
            this.tabPageStopwatches.Size = new System.Drawing.Size(1195, 662);
            this.tabPageStopwatches.TabIndex = 3;
            this.tabPageStopwatches.Text = "Секундомеры";
            this.tabPageStopwatches.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ClockApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageClocks.ResumeLayout(false);
            this.groupBoxAddTimezone.ResumeLayout(false);
            this.tabPageAlarms.ResumeLayout(false);
            this.groupBoxMain.ResumeLayout(false);
            this.groupBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmNumericUpDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmNumericUpDownHour)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClocks;
        private System.Windows.Forms.TabPage tabPageAlarms;
        private System.Windows.Forms.TabPage tabPageCountdowns;
        private System.Windows.Forms.TabPage tabPageStopwatches;
        private System.Windows.Forms.GroupBox groupBoxAddTimezone;
        private System.Windows.Forms.Button buttonAddTimezone;
        private System.Windows.Forms.ComboBox comboBoxAddTimezone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTimezones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label groupHour;
        private System.Windows.Forms.Button buttonGroupSetAlarm;
        private System.Windows.Forms.Label groupMinute;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBoxMain;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label groupDevider;
        private System.Windows.Forms.Label groupMessageBox;
        private System.Windows.Forms.TextBox textBoxAlarm;
        private System.Windows.Forms.CheckBox checkBoxWeekFriday;
        private System.Windows.Forms.CheckBox checkBoxWeekThursday;
        private System.Windows.Forms.CheckBox checkBoxWeekWednesday;
        private System.Windows.Forms.CheckBox checkBoxWeekTuesday;
        private System.Windows.Forms.CheckBox checkBoxWeekMonday;
        private System.Windows.Forms.CheckBox checkBoxWeekSunday;
        private System.Windows.Forms.CheckBox checkBoxWeekSaturday;
        private System.Windows.Forms.CheckBox checkBoxSnooze;
        private System.Windows.Forms.ComboBox comboBoxAlarmRepeat;
        private System.Windows.Forms.FlowLayoutPanel AlarmflowLayoutPanel;
        private System.Windows.Forms.NumericUpDown AlarmNumericUpDownMinute;
        private System.Windows.Forms.NumericUpDown AlarmNumericUpDownHour;
    }
}

