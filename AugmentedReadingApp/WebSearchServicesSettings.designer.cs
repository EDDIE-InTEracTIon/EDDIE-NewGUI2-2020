namespace AugmentedReadingApp
{
    partial class WebSearchServicesSettings
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
            this.WebSearchTittle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebSearchServicesSettingsPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebSearchTittle
            // 
            this.WebSearchTittle.AutoSize = true;
            this.WebSearchTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebSearchTittle.Location = new System.Drawing.Point(12, 8);
            this.WebSearchTittle.Name = "WebSearchTittle";
            this.WebSearchTittle.Size = new System.Drawing.Size(466, 53);
            this.WebSearchTittle.TabIndex = 0;
            this.WebSearchTittle.Text = "Web Search Services";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.WebSearchTittle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 61);
            this.panel1.TabIndex = 1;
            // 
            // WebSearchServicesSettingsPanel
            // 
            this.WebSearchServicesSettingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.WebSearchServicesSettingsPanel.Location = new System.Drawing.Point(12, 76);
            this.WebSearchServicesSettingsPanel.Name = "WebSearchServicesSettingsPanel";
            this.WebSearchServicesSettingsPanel.Size = new System.Drawing.Size(947, 212);
            this.WebSearchServicesSettingsPanel.TabIndex = 2;
            // 
            // WebSearchServicesSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(987, 539);
            this.Controls.Add(this.WebSearchServicesSettingsPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebSearchServicesSettings";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WebSearchServicesSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WebSearchTittle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel WebSearchServicesSettingsPanel;
    }
}