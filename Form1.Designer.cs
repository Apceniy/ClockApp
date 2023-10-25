
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageClocks = new System.Windows.Forms.TabPage();
            this.tabPageAlarms = new System.Windows.Forms.TabPage();
            this.tabPageCountdowns = new System.Windows.Forms.TabPage();
            this.tabPageStopwatches = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabPageClocks.Location = new System.Drawing.Point(4, 22);
            this.tabPageClocks.Name = "tabPageClocks";
            this.tabPageClocks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClocks.Size = new System.Drawing.Size(794, 426);
            this.tabPageClocks.TabIndex = 0;
            this.tabPageClocks.Text = "Мировое время";
            this.tabPageClocks.UseVisualStyleBackColor = true;
            // 
            // tabPageAlarms
            // 
            this.tabPageAlarms.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlarms.Name = "tabPageAlarms";
            this.tabPageAlarms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlarms.Size = new System.Drawing.Size(767, 399);
            this.tabPageAlarms.TabIndex = 1;
            this.tabPageAlarms.Text = "Будильники";
            this.tabPageAlarms.UseVisualStyleBackColor = true;
            // 
            // tabPageCountdowns
            // 
            this.tabPageCountdowns.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountdowns.Name = "tabPageCountdowns";
            this.tabPageCountdowns.Size = new System.Drawing.Size(767, 399);
            this.tabPageCountdowns.TabIndex = 2;
            this.tabPageCountdowns.Text = "Таймеры";
            this.tabPageCountdowns.UseVisualStyleBackColor = true;
            // 
            // tabPageStopwatches
            // 
            this.tabPageStopwatches.Location = new System.Drawing.Point(4, 22);
            this.tabPageStopwatches.Name = "tabPageStopwatches";
            this.tabPageStopwatches.Size = new System.Drawing.Size(767, 399);
            this.tabPageStopwatches.TabIndex = 3;
            this.tabPageStopwatches.Text = "Секундомеры";
            this.tabPageStopwatches.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ClockApp";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageClocks;
        private System.Windows.Forms.TabPage tabPageAlarms;
        private System.Windows.Forms.TabPage tabPageCountdowns;
        private System.Windows.Forms.TabPage tabPageStopwatches;
    }
}

