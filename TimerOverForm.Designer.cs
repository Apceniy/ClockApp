namespace ClockApp
{
    partial class TimerOverForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerTextLabel = new System.Windows.Forms.Label();
            this.TimerOverResetBtn = new System.Windows.Forms.Button();
            this.TimerOverCloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimerTextLabel
            // 
            this.TimerTextLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimerTextLabel.Location = new System.Drawing.Point(0, 0);
            this.TimerTextLabel.Name = "TimerTextLabel";
            this.TimerTextLabel.Size = new System.Drawing.Size(410, 71);
            this.TimerTextLabel.TabIndex = 0;
            this.TimerTextLabel.Text = "text";
            // 
            // TimerOverResetBtn
            // 
            this.TimerOverResetBtn.Location = new System.Drawing.Point(36, 90);
            this.TimerOverResetBtn.Name = "TimerOverResetBtn";
            this.TimerOverResetBtn.Size = new System.Drawing.Size(95, 31);
            this.TimerOverResetBtn.TabIndex = 1;
            this.TimerOverResetBtn.Text = "Заново";
            this.TimerOverResetBtn.UseVisualStyleBackColor = true;
            this.TimerOverResetBtn.Click += new System.EventHandler(this.TimerOverResetBtn_Click);
            // 
            // TimerOverCloseBtn
            // 
            this.TimerOverCloseBtn.Location = new System.Drawing.Point(242, 90);
            this.TimerOverCloseBtn.Name = "TimerOverCloseBtn";
            this.TimerOverCloseBtn.Size = new System.Drawing.Size(95, 31);
            this.TimerOverCloseBtn.TabIndex = 2;
            this.TimerOverCloseBtn.Text = "Закрыть";
            this.TimerOverCloseBtn.UseVisualStyleBackColor = true;
            this.TimerOverCloseBtn.Click += new System.EventHandler(this.TimerOverCloseBtn_Click);
            // 
            // TimerOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 133);
            this.Controls.Add(this.TimerOverCloseBtn);
            this.Controls.Add(this.TimerOverResetBtn);
            this.Controls.Add(this.TimerTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "TimerOverForm";
            this.Text = "TimerOver";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerTextLabel;
        private System.Windows.Forms.Button TimerOverResetBtn;
        private System.Windows.Forms.Button TimerOverCloseBtn;
    }
}