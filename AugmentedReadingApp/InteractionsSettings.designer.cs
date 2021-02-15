namespace AugmentedReadingApp
{
    partial class InteractionsSettings
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
            this.InteractionsTittle = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.InteractionsSettingsPanel1 = new System.Windows.Forms.Panel();
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.InteractionsSettingsPanel1.SuspendLayout();
            this.TittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InteractionsTittle
            // 
            this.InteractionsTittle.AutoSize = true;
            this.InteractionsTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.InteractionsTittle.Location = new System.Drawing.Point(12, 8);
            this.InteractionsTittle.Name = "InteractionsTittle";
            this.InteractionsTittle.Size = new System.Drawing.Size(263, 53);
            this.InteractionsTittle.TabIndex = 0;
            this.InteractionsTittle.Text = "Interactions";
            this.InteractionsTittle.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(138, 60);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(138, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // InteractionsSettingsPanel1
            // 
            this.InteractionsSettingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.InteractionsSettingsPanel1.Controls.Add(this.radioButton1);
            this.InteractionsSettingsPanel1.Controls.Add(this.radioButton2);
            this.InteractionsSettingsPanel1.Location = new System.Drawing.Point(12, 76);
            this.InteractionsSettingsPanel1.Name = "InteractionsSettingsPanel1";
            this.InteractionsSettingsPanel1.Size = new System.Drawing.Size(947, 199);
            this.InteractionsSettingsPanel1.TabIndex = 3;
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.TittlePanel.Controls.Add(this.InteractionsTittle);
            this.TittlePanel.Location = new System.Drawing.Point(0, 0);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(988, 61);
            this.TittlePanel.TabIndex = 4;
            // 
            // InteractionsSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(987, 539);
            this.Controls.Add(this.TittlePanel);
            this.Controls.Add(this.InteractionsSettingsPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InteractionsSettings";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.InteractionsSettings_Load);
            this.InteractionsSettingsPanel1.ResumeLayout(false);
            this.InteractionsSettingsPanel1.PerformLayout();
            this.TittlePanel.ResumeLayout(false);
            this.TittlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label InteractionsTittle;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel InteractionsSettingsPanel1;
        private System.Windows.Forms.Panel TittlePanel;
    }
}