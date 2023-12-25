
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
            this.timerTabPageCountdowns = new System.Windows.Forms.TabPage();
            this.timerMesssengLabel = new System.Windows.Forms.Label();
            this.timerMessageTextBox = new System.Windows.Forms.TextBox();
            this.timerFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timerAddButton = new System.Windows.Forms.Button();
            this.timerSecondLabel = new System.Windows.Forms.Label();
            this.timerMinuteLabel = new System.Windows.Forms.Label();
            this.timerHourLabel = new System.Windows.Forms.Label();
            this.secondNumeric = new System.Windows.Forms.NumericUpDown();
            this.minuteNumeric = new System.Windows.Forms.NumericUpDown();
            this.hourNumeric = new System.Windows.Forms.NumericUpDown();
            this.tabPageStopwatches = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageClocks.SuspendLayout();
            this.groupBoxAddTimezone.SuspendLayout();
            this.timerTabPageCountdowns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageClocks);
            this.tabControl1.Controls.Add(this.tabPageAlarms);
            this.tabControl1.Controls.Add(this.timerTabPageCountdowns);
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
            this.buttonAddTimezone.Click += new System.EventHandler(this.buttonAddTimezone_Click);
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
            this.tabPageAlarms.Location = new System.Drawing.Point(4, 29);
            this.tabPageAlarms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAlarms.Name = "tabPageAlarms";
            this.tabPageAlarms.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPageAlarms.Size = new System.Drawing.Size(1195, 662);
            this.tabPageAlarms.TabIndex = 1;
            this.tabPageAlarms.Text = "Будильники";
            this.tabPageAlarms.UseVisualStyleBackColor = true;
            // 
            // timerTabPageCountdowns
            // 
            this.timerTabPageCountdowns.Controls.Add(this.timerMesssengLabel);
            this.timerTabPageCountdowns.Controls.Add(this.timerMessageTextBox);
            this.timerTabPageCountdowns.Controls.Add(this.timerFlowLayoutPanel);
            this.timerTabPageCountdowns.Controls.Add(this.timerAddButton);
            this.timerTabPageCountdowns.Controls.Add(this.timerSecondLabel);
            this.timerTabPageCountdowns.Controls.Add(this.timerMinuteLabel);
            this.timerTabPageCountdowns.Controls.Add(this.timerHourLabel);
            this.timerTabPageCountdowns.Controls.Add(this.secondNumeric);
            this.timerTabPageCountdowns.Controls.Add(this.minuteNumeric);
            this.timerTabPageCountdowns.Controls.Add(this.hourNumeric);
            this.timerTabPageCountdowns.Location = new System.Drawing.Point(4, 29);
            this.timerTabPageCountdowns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.timerTabPageCountdowns.Name = "timerTabPageCountdowns";
            this.timerTabPageCountdowns.Size = new System.Drawing.Size(1195, 662);
            this.timerTabPageCountdowns.TabIndex = 2;
            this.timerTabPageCountdowns.Text = "Таймеры";
            this.timerTabPageCountdowns.UseVisualStyleBackColor = true;
            // 
            // timerMesssengLabel
            // 
            this.timerMesssengLabel.AutoSize = true;
            this.timerMesssengLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerMesssengLabel.Location = new System.Drawing.Point(349, 76);
            this.timerMesssengLabel.Name = "timerMesssengLabel";
            this.timerMesssengLabel.Size = new System.Drawing.Size(195, 37);
            this.timerMesssengLabel.TabIndex = 9;
            this.timerMesssengLabel.Text = "Сообщение:";
            // 
            // timerMessageTextBox
            // 
            this.timerMessageTextBox.Location = new System.Drawing.Point(114, 116);
            this.timerMessageTextBox.Multiline = true;
            this.timerMessageTextBox.Name = "timerMessageTextBox";
            this.timerMessageTextBox.Size = new System.Drawing.Size(653, 67);
            this.timerMessageTextBox.TabIndex = 8;
            // 
            // timerFlowLayoutPanel
            // 
            this.timerFlowLayoutPanel.Location = new System.Drawing.Point(0, 197);
            this.timerFlowLayoutPanel.Name = "timerFlowLayoutPanel";
            this.timerFlowLayoutPanel.Size = new System.Drawing.Size(1195, 465);
            this.timerFlowLayoutPanel.TabIndex = 7;
            // 
            // timerAddButton
            // 
            this.timerAddButton.Location = new System.Drawing.Point(955, 110);
            this.timerAddButton.Name = "timerAddButton";
            this.timerAddButton.Size = new System.Drawing.Size(85, 39);
            this.timerAddButton.TabIndex = 6;
            this.timerAddButton.Text = "Запуск";
            this.timerAddButton.UseVisualStyleBackColor = true;
            this.timerAddButton.Click += new System.EventHandler(this.timerAddButton_Click);
            // 
            // timerSecondLabel
            // 
            this.timerSecondLabel.AutoSize = true;
            this.timerSecondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerSecondLabel.Location = new System.Drawing.Point(807, 29);
            this.timerSecondLabel.Name = "timerSecondLabel";
            this.timerSecondLabel.Size = new System.Drawing.Size(155, 37);
            this.timerSecondLabel.TabIndex = 5;
            this.timerSecondLabel.Text = "Секунда:";
            // 
            // timerMinuteLabel
            // 
            this.timerMinuteLabel.AutoSize = true;
            this.timerMinuteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerMinuteLabel.Location = new System.Drawing.Point(471, 29);
            this.timerMinuteLabel.Name = "timerMinuteLabel";
            this.timerMinuteLabel.Size = new System.Drawing.Size(137, 37);
            this.timerMinuteLabel.TabIndex = 4;
            this.timerMinuteLabel.Text = "Минута:";
            // 
            // timerHourLabel
            // 
            this.timerHourLabel.AutoSize = true;
            this.timerHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerHourLabel.Location = new System.Drawing.Point(119, 29);
            this.timerHourLabel.Name = "timerHourLabel";
            this.timerHourLabel.Size = new System.Drawing.Size(84, 37);
            this.timerHourLabel.TabIndex = 3;
            this.timerHourLabel.Text = "Час:";
            // 
            // secondNumeric
            // 
            this.secondNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNumeric.Location = new System.Drawing.Point(996, 27);
            this.secondNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.secondNumeric.Name = "secondNumeric";
            this.secondNumeric.Size = new System.Drawing.Size(81, 44);
            this.secondNumeric.TabIndex = 2;
            // 
            // minuteNumeric
            // 
            this.minuteNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minuteNumeric.Location = new System.Drawing.Point(641, 27);
            this.minuteNumeric.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumeric.Name = "minuteNumeric";
            this.minuteNumeric.Size = new System.Drawing.Size(81, 44);
            this.minuteNumeric.TabIndex = 1;
            // 
            // hourNumeric
            // 
            this.hourNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourNumeric.Location = new System.Drawing.Point(236, 27);
            this.hourNumeric.Name = "hourNumeric";
            this.hourNumeric.Size = new System.Drawing.Size(81, 44);
            this.hourNumeric.TabIndex = 0;
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
            this.timerTabPageCountdowns.ResumeLayout(false);
            this.timerTabPageCountdowns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClocks;
        private System.Windows.Forms.TabPage tabPageAlarms;
        private System.Windows.Forms.TabPage timerTabPageCountdowns;
        private System.Windows.Forms.TabPage tabPageStopwatches;
        private System.Windows.Forms.GroupBox groupBoxAddTimezone;
        private System.Windows.Forms.Button buttonAddTimezone;
        private System.Windows.Forms.ComboBox comboBoxAddTimezone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTimezones;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown hourNumeric;
        private System.Windows.Forms.Label timerHourLabel;
        private System.Windows.Forms.NumericUpDown secondNumeric;
        private System.Windows.Forms.NumericUpDown minuteNumeric;
        private System.Windows.Forms.FlowLayoutPanel timerFlowLayoutPanel;
        private System.Windows.Forms.Button timerAddButton;
        private System.Windows.Forms.Label timerSecondLabel;
        private System.Windows.Forms.Label timerMinuteLabel;
        private System.Windows.Forms.Label timerMesssengLabel;
        private System.Windows.Forms.TextBox timerMessageTextBox;
    }
}

