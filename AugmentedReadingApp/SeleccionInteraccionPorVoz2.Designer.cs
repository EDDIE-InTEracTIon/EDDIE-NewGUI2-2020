﻿namespace AugmentedReadingApp
{
    partial class SeleccionInteraccionPorVoz2
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbtn_voz_no = new System.Windows.Forms.RadioButton();
            this.rbtn_voz_si = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtn_no_botones = new System.Windows.Forms.RadioButton();
            this.rbtn_Si_botones = new System.Windows.Forms.RadioButton();
            this.InteractionsSettingsPanel1 = new System.Windows.Forms.Panel();
            this.InteractionsTittle = new System.Windows.Forms.Label();
            this.TittlePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.InteractionsSettingsPanel1.SuspendLayout();
            this.TittlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "¿Activar interacción por voz?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rbtn_voz_no
            // 
            this.rbtn_voz_no.AutoSize = true;
            this.rbtn_voz_no.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_voz_no.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.rbtn_voz_no.Location = new System.Drawing.Point(21, 90);
            this.rbtn_voz_no.Name = "rbtn_voz_no";
            this.rbtn_voz_no.Size = new System.Drawing.Size(52, 28);
            this.rbtn_voz_no.TabIndex = 12;
            this.rbtn_voz_no.TabStop = true;
            this.rbtn_voz_no.Text = "No";
            this.rbtn_voz_no.UseVisualStyleBackColor = true;
            // 
            // rbtn_voz_si
            // 
            this.rbtn_voz_si.AutoSize = true;
            this.rbtn_voz_si.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_voz_si.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.rbtn_voz_si.Location = new System.Drawing.Point(21, 67);
            this.rbtn_voz_si.Name = "rbtn_voz_si";
            this.rbtn_voz_si.Size = new System.Drawing.Size(44, 28);
            this.rbtn_voz_si.TabIndex = 11;
            this.rbtn_voz_si.TabStop = true;
            this.rbtn_voz_si.Text = "Si";
            this.rbtn_voz_si.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbtn_no_botones);
            this.panel1.Controls.Add(this.rbtn_Si_botones);
            this.panel1.Location = new System.Drawing.Point(338, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 137);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "¿Mostrar botones?";
            // 
            // rbtn_no_botones
            // 
            this.rbtn_no_botones.AutoSize = true;
            this.rbtn_no_botones.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_no_botones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.rbtn_no_botones.Location = new System.Drawing.Point(7, 65);
            this.rbtn_no_botones.Name = "rbtn_no_botones";
            this.rbtn_no_botones.Size = new System.Drawing.Size(52, 28);
            this.rbtn_no_botones.TabIndex = 17;
            this.rbtn_no_botones.TabStop = true;
            this.rbtn_no_botones.Text = "No";
            this.rbtn_no_botones.UseVisualStyleBackColor = true;
            this.rbtn_no_botones.CheckedChanged += new System.EventHandler(this.rbtn_no_botones_CheckedChanged);
            // 
            // rbtn_Si_botones
            // 
            this.rbtn_Si_botones.AutoSize = true;
            this.rbtn_Si_botones.Font = new System.Drawing.Font("IBM Plex Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_Si_botones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.rbtn_Si_botones.Location = new System.Drawing.Point(7, 41);
            this.rbtn_Si_botones.Name = "rbtn_Si_botones";
            this.rbtn_Si_botones.Size = new System.Drawing.Size(44, 28);
            this.rbtn_Si_botones.TabIndex = 16;
            this.rbtn_Si_botones.TabStop = true;
            this.rbtn_Si_botones.Text = "Si";
            this.rbtn_Si_botones.UseVisualStyleBackColor = true;
            // 
            // InteractionsSettingsPanel1
            // 
            this.InteractionsSettingsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.InteractionsSettingsPanel1.Controls.Add(this.label1);
            this.InteractionsSettingsPanel1.Controls.Add(this.rbtn_voz_si);
            this.InteractionsSettingsPanel1.Controls.Add(this.panel1);
            this.InteractionsSettingsPanel1.Controls.Add(this.rbtn_voz_no);
            this.InteractionsSettingsPanel1.Location = new System.Drawing.Point(12, 94);
            this.InteractionsSettingsPanel1.Name = "InteractionsSettingsPanel1";
            this.InteractionsSettingsPanel1.Size = new System.Drawing.Size(947, 199);
            this.InteractionsSettingsPanel1.TabIndex = 20;
            // 
            // InteractionsTittle
            // 
            this.InteractionsTittle.AutoSize = true;
            this.InteractionsTittle.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteractionsTittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.InteractionsTittle.Location = new System.Drawing.Point(12, 8);
            this.InteractionsTittle.Name = "InteractionsTittle";
            this.InteractionsTittle.Size = new System.Drawing.Size(280, 58);
            this.InteractionsTittle.TabIndex = 0;
            this.InteractionsTittle.Text = "Interactions";
            // 
            // TittlePanel
            // 
            this.TittlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.TittlePanel.Controls.Add(this.InteractionsTittle);
            this.TittlePanel.Location = new System.Drawing.Point(0, -1);
            this.TittlePanel.Name = "TittlePanel";
            this.TittlePanel.Size = new System.Drawing.Size(988, 74);
            this.TittlePanel.TabIndex = 21;
            // 
            // SeleccionInteraccionPorVoz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(971, 500);
            this.Controls.Add(this.InteractionsSettingsPanel1);
            this.Controls.Add(this.TittlePanel);
            this.Name = "SeleccionInteraccionPorVoz2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeleccionInteraccionPorVoz";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.InteractionsSettingsPanel1.ResumeLayout(false);
            this.InteractionsSettingsPanel1.PerformLayout();
            this.TittlePanel.ResumeLayout(false);
            this.TittlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton rbtn_voz_no;
        public System.Windows.Forms.RadioButton rbtn_voz_si;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.RadioButton rbtn_no_botones;
        public System.Windows.Forms.RadioButton rbtn_Si_botones;
        private System.Windows.Forms.Panel InteractionsSettingsPanel1;
        private System.Windows.Forms.Label InteractionsTittle;
        private System.Windows.Forms.Panel TittlePanel;
    }
}