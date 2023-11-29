
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
            this.tabPageCountdowns = new System.Windows.Forms.TabPage();
            this.tabPageStopwatches = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageClocks.SuspendLayout();
            this.groupBoxAddTimezone.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(802, 452);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageClocks
            // 
            this.tabPageClocks.Controls.Add(this.flowLayoutPanelTimezones);
            this.tabPageClocks.Controls.Add(this.groupBoxAddTimezone);
            this.tabPageClocks.Location = new System.Drawing.Point(4, 22);
            this.tabPageClocks.Name = "tabPageClocks";
            this.tabPageClocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClocks.Size = new System.Drawing.Size(794, 426);
            this.tabPageClocks.TabIndex = 0;
            this.tabPageClocks.Text = "Мировое время";
            this.tabPageClocks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelTimezones
            // 
            this.flowLayoutPanelTimezones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTimezones.Location = new System.Drawing.Point(9, 56);
            this.flowLayoutPanelTimezones.Name = "flowLayoutPanelTimezones";
            this.flowLayoutPanelTimezones.Size = new System.Drawing.Size(775, 360);
            this.flowLayoutPanelTimezones.TabIndex = 1;
            // 
            // groupBoxAddTimezone
            // 
            this.groupBoxAddTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxAddTimezone.Controls.Add(this.buttonAddTimezone);
            this.groupBoxAddTimezone.Controls.Add(this.comboBoxAddTimezone);
            this.groupBoxAddTimezone.Location = new System.Drawing.Point(3, 6);
            this.groupBoxAddTimezone.Name = "groupBoxAddTimezone";
            this.groupBoxAddTimezone.Size = new System.Drawing.Size(781, 44);
            this.groupBoxAddTimezone.TabIndex = 0;
            this.groupBoxAddTimezone.TabStop = false;
            this.groupBoxAddTimezone.Text = "Добавление новой временной зоны";
            // 
            // buttonAddTimezone
            // 
            this.buttonAddTimezone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddTimezone.Location = new System.Drawing.Point(691, 16);
            this.buttonAddTimezone.Name = "buttonAddTimezone";
            this.buttonAddTimezone.Size = new System.Drawing.Size(75, 23);
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
            this.comboBoxAddTimezone.Location = new System.Drawing.Point(6, 17);
            this.comboBoxAddTimezone.Name = "comboBoxAddTimezone";
            this.comboBoxAddTimezone.Size = new System.Drawing.Size(679, 21);
            this.comboBoxAddTimezone.TabIndex = 0;
            // 
            // tabPageAlarms
            // 
            this.tabPageAlarms.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlarms.Name = "tabPageAlarms";
            this.tabPageAlarms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlarms.Size = new System.Drawing.Size(794, 426);
            this.tabPageAlarms.TabIndex = 1;
            this.tabPageAlarms.Text = "Будильники";
            this.tabPageAlarms.UseVisualStyleBackColor = true;
            // 
            // tabPageCountdowns
            // 
            this.tabPageCountdowns.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountdowns.Name = "tabPageCountdowns";
            this.tabPageCountdowns.Size = new System.Drawing.Size(794, 426);
            this.tabPageCountdowns.TabIndex = 2;
            this.tabPageCountdowns.Text = "Таймеры";
            this.tabPageCountdowns.UseVisualStyleBackColor = true;
            // 
            // tabPageStopwatches
            // 
            this.tabPageStopwatches.Location = new System.Drawing.Point(4, 22);
            this.tabPageStopwatches.Name = "tabPageStopwatches";
            this.tabPageStopwatches.Size = new System.Drawing.Size(794, 426);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ClockApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageClocks.ResumeLayout(false);
            this.groupBoxAddTimezone.ResumeLayout(false);
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
    }
}

