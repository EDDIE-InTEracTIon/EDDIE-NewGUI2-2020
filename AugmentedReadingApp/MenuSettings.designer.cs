namespace AugmentedReadingApp
{
    partial class MenuSettings
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuSettings));
            this.PanelNavBar = new System.Windows.Forms.Panel();
            this.ContenidoNavBar = new System.Windows.Forms.Panel();
            this.PageDetectionButton = new System.Windows.Forms.Button();
            this.TextRecognitiionButton = new System.Windows.Forms.Button();
            this.GestureRecognitionButton = new System.Windows.Forms.Button();
            this.EyeTrackingButton = new System.Windows.Forms.Button();
            this.WebSearchServicesButton = new System.Windows.Forms.Button();
            this.InteractionsButton = new System.Windows.Forms.Button();
            this.SettingsText = new System.Windows.Forms.TextBox();
            this.PanelBarraSuperior = new System.Windows.Forms.Panel();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.ExitPictureBox = new System.Windows.Forms.PictureBox();
            this.PanelContenido = new System.Windows.Forms.Panel();
            this.LoadingPictureBox = new System.Windows.Forms.PictureBox();
            this.ResetSettingsButtonModified = new Front_EDDIE_WindowsForm.ButtonModified();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SaveSettingsButtonModified = new Front_EDDIE_WindowsForm.ButtonModified();
            this.StartProjectionButtonModified = new Front_EDDIE_WindowsForm.ButtonModified();
            this.PanelNavBar.SuspendLayout();
            this.ContenidoNavBar.SuspendLayout();
            this.PanelBarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).BeginInit();
            this.PanelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelNavBar
            // 
            this.PanelNavBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.PanelNavBar.Controls.Add(this.ContenidoNavBar);
            this.PanelNavBar.Location = new System.Drawing.Point(0, 58);
            this.PanelNavBar.Name = "PanelNavBar";
            this.PanelNavBar.Size = new System.Drawing.Size(257, 662);
            this.PanelNavBar.TabIndex = 1;
            // 
            // ContenidoNavBar
            // 
            this.ContenidoNavBar.Controls.Add(this.PageDetectionButton);
            this.ContenidoNavBar.Controls.Add(this.TextRecognitiionButton);
            this.ContenidoNavBar.Controls.Add(this.GestureRecognitionButton);
            this.ContenidoNavBar.Controls.Add(this.EyeTrackingButton);
            this.ContenidoNavBar.Controls.Add(this.WebSearchServicesButton);
            this.ContenidoNavBar.Controls.Add(this.InteractionsButton);
            this.ContenidoNavBar.Controls.Add(this.SettingsText);
            this.ContenidoNavBar.Location = new System.Drawing.Point(32, 24);
            this.ContenidoNavBar.Name = "ContenidoNavBar";
            this.ContenidoNavBar.Size = new System.Drawing.Size(210, 331);
            this.ContenidoNavBar.TabIndex = 0;
            this.ContenidoNavBar.Paint += new System.Windows.Forms.PaintEventHandler(this.ContenidoNavBar_Paint);
            // 
            // PageDetectionButton
            // 
            this.PageDetectionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.PageDetectionButton.FlatAppearance.BorderSize = 0;
            this.PageDetectionButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDetectionButton.Location = new System.Drawing.Point(0, 282);
            this.PageDetectionButton.Name = "PageDetectionButton";
            this.PageDetectionButton.Size = new System.Drawing.Size(210, 39);
            this.PageDetectionButton.TabIndex = 5;
            this.PageDetectionButton.Text = "Page detection";
            this.PageDetectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PageDetectionButton.UseVisualStyleBackColor = false;
            this.PageDetectionButton.Click += new System.EventHandler(this.PageDetectionButton_Click);
            // 
            // TextRecognitiionButton
            // 
            this.TextRecognitiionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.TextRecognitiionButton.FlatAppearance.BorderSize = 0;
            this.TextRecognitiionButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextRecognitiionButton.Location = new System.Drawing.Point(0, 194);
            this.TextRecognitiionButton.Name = "TextRecognitiionButton";
            this.TextRecognitiionButton.Size = new System.Drawing.Size(210, 39);
            this.TextRecognitiionButton.TabIndex = 4;
            this.TextRecognitiionButton.Text = "Text Recognition";
            this.TextRecognitiionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TextRecognitiionButton.UseVisualStyleBackColor = false;
            this.TextRecognitiionButton.Click += new System.EventHandler(this.TextRecognitiionButton_Click);
            // 
            // GestureRecognitionButton
            // 
            this.GestureRecognitionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.GestureRecognitionButton.FlatAppearance.BorderSize = 0;
            this.GestureRecognitionButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestureRecognitionButton.Location = new System.Drawing.Point(0, 238);
            this.GestureRecognitionButton.Name = "GestureRecognitionButton";
            this.GestureRecognitionButton.Size = new System.Drawing.Size(210, 39);
            this.GestureRecognitionButton.TabIndex = 3;
            this.GestureRecognitionButton.Text = "Gesture Recognition";
            this.GestureRecognitionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GestureRecognitionButton.UseVisualStyleBackColor = false;
            this.GestureRecognitionButton.Click += new System.EventHandler(this.GestureRecognitionButton_Click);
            // 
            // EyeTrackingButton
            // 
            this.EyeTrackingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.EyeTrackingButton.FlatAppearance.BorderSize = 0;
            this.EyeTrackingButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EyeTrackingButton.Location = new System.Drawing.Point(0, 150);
            this.EyeTrackingButton.Name = "EyeTrackingButton";
            this.EyeTrackingButton.Size = new System.Drawing.Size(210, 39);
            this.EyeTrackingButton.TabIndex = 2;
            this.EyeTrackingButton.Text = "Eye Tracking";
            this.EyeTrackingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EyeTrackingButton.UseVisualStyleBackColor = false;
            this.EyeTrackingButton.Click += new System.EventHandler(this.EyeTrackingButton_Click);
            // 
            // WebSearchServicesButton
            // 
            this.WebSearchServicesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.WebSearchServicesButton.FlatAppearance.BorderSize = 0;
            this.WebSearchServicesButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WebSearchServicesButton.Location = new System.Drawing.Point(0, 108);
            this.WebSearchServicesButton.Name = "WebSearchServicesButton";
            this.WebSearchServicesButton.Size = new System.Drawing.Size(210, 39);
            this.WebSearchServicesButton.TabIndex = 1;
            this.WebSearchServicesButton.Text = "Web search services";
            this.WebSearchServicesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WebSearchServicesButton.UseVisualStyleBackColor = false;
            this.WebSearchServicesButton.Click += new System.EventHandler(this.WebSearchServicesButton_Click);
            // 
            // InteractionsButton
            // 
            this.InteractionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.InteractionsButton.FlatAppearance.BorderSize = 0;
            this.InteractionsButton.Font = new System.Drawing.Font("IBM Plex Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InteractionsButton.Location = new System.Drawing.Point(0, 62);
            this.InteractionsButton.Name = "InteractionsButton";
            this.InteractionsButton.Size = new System.Drawing.Size(210, 39);
            this.InteractionsButton.TabIndex = 0;
            this.InteractionsButton.Text = "Interactions";
            this.InteractionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InteractionsButton.UseVisualStyleBackColor = false;
            this.InteractionsButton.Click += new System.EventHandler(this.InteractionsButton_Click);
            // 
            // SettingsText
            // 
            this.SettingsText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.SettingsText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SettingsText.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 16.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsText.Location = new System.Drawing.Point(0, 0);
            this.SettingsText.Name = "SettingsText";
            this.SettingsText.Size = new System.Drawing.Size(210, 30);
            this.SettingsText.TabIndex = 0;
            this.SettingsText.Text = "Settings";
            // 
            // PanelBarraSuperior
            // 
            this.PanelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.PanelBarraSuperior.Controls.Add(this.MinimizePictureBox);
            this.PanelBarraSuperior.Controls.Add(this.ExitPictureBox);
            this.PanelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraSuperior.Name = "PanelBarraSuperior";
            this.PanelBarraSuperior.Size = new System.Drawing.Size(1281, 58);
            this.PanelBarraSuperior.TabIndex = 2;
            this.PanelBarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBarraSuperior_MouseMove);
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MinimizePictureBox.Image")));
            this.MinimizePictureBox.Location = new System.Drawing.Point(1207, 12);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(20, 20);
            this.MinimizePictureBox.TabIndex = 1;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            // 
            // ExitPictureBox
            // 
            this.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExitPictureBox.Image")));
            this.ExitPictureBox.Location = new System.Drawing.Point(1248, 12);
            this.ExitPictureBox.Name = "ExitPictureBox";
            this.ExitPictureBox.Size = new System.Drawing.Size(20, 20);
            this.ExitPictureBox.TabIndex = 0;
            this.ExitPictureBox.TabStop = false;
            this.ExitPictureBox.Click += new System.EventHandler(this.ExitIconPictureBox_Click);
            // 
            // PanelContenido
            // 
            this.PanelContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.PanelContenido.Controls.Add(this.LoadingPictureBox);
            this.PanelContenido.Location = new System.Drawing.Point(257, 58);
            this.PanelContenido.Name = "PanelContenido";
            this.PanelContenido.Size = new System.Drawing.Size(987, 539);
            this.PanelContenido.TabIndex = 3;
            this.PanelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelContenido_Paint);
            // 
            // LoadingPictureBox
            // 
            this.LoadingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LoadingPictureBox.Image")));
            this.LoadingPictureBox.Location = new System.Drawing.Point(462, 236);
            this.LoadingPictureBox.Name = "LoadingPictureBox";
            this.LoadingPictureBox.Size = new System.Drawing.Size(63, 62);
            this.LoadingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LoadingPictureBox.TabIndex = 6;
            this.LoadingPictureBox.TabStop = false;
            // 
            // ResetSettingsButtonModified
            // 
            this.ResetSettingsButtonModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.ResetSettingsButtonModified.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.ResetSettingsButtonModified.FlatAppearance.BorderSize = 5;
            this.ResetSettingsButtonModified.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.ResetSettingsButtonModified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.ResetSettingsButtonModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetSettingsButtonModified.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSettingsButtonModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ResetSettingsButtonModified.Location = new System.Drawing.Point(263, 605);
            this.ResetSettingsButtonModified.Name = "ResetSettingsButtonModified";
            this.ResetSettingsButtonModified.Size = new System.Drawing.Size(252, 84);
            this.ResetSettingsButtonModified.TabIndex = 4;
            this.ResetSettingsButtonModified.Text = "Reset Settings";
            this.ResetSettingsButtonModified.UseVisualStyleBackColor = false;
            // 
            // SaveSettingsButtonModified
            // 
            this.SaveSettingsButtonModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.SaveSettingsButtonModified.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.SaveSettingsButtonModified.FlatAppearance.BorderSize = 5;
            this.SaveSettingsButtonModified.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.SaveSettingsButtonModified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.SaveSettingsButtonModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSettingsButtonModified.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButtonModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.SaveSettingsButtonModified.Location = new System.Drawing.Point(639, 605);
            this.SaveSettingsButtonModified.Name = "SaveSettingsButtonModified";
            this.SaveSettingsButtonModified.Size = new System.Drawing.Size(252, 84);
            this.SaveSettingsButtonModified.TabIndex = 5;
            this.SaveSettingsButtonModified.Text = "Save Settings";
            this.SaveSettingsButtonModified.UseVisualStyleBackColor = false;
            this.SaveSettingsButtonModified.Click += new System.EventHandler(this.SaveSettingsButtonModified_Click);
            // 
            // StartProjectionButtonModified
            // 
            this.StartProjectionButtonModified.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.StartProjectionButtonModified.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.StartProjectionButtonModified.FlatAppearance.BorderSize = 5;
            this.StartProjectionButtonModified.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.StartProjectionButtonModified.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.StartProjectionButtonModified.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartProjectionButtonModified.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartProjectionButtonModified.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.StartProjectionButtonModified.Location = new System.Drawing.Point(990, 605);
            this.StartProjectionButtonModified.Name = "StartProjectionButtonModified";
            this.StartProjectionButtonModified.Size = new System.Drawing.Size(252, 84);
            this.StartProjectionButtonModified.TabIndex = 6;
            this.StartProjectionButtonModified.Text = "Start Projection";
            this.StartProjectionButtonModified.UseVisualStyleBackColor = false;
            this.StartProjectionButtonModified.Click += new System.EventHandler(this.StartProjectionButtonModified_Click_1);
            // 
            // MenuSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.StartProjectionButtonModified);
            this.Controls.Add(this.SaveSettingsButtonModified);
            this.Controls.Add(this.ResetSettingsButtonModified);
            this.Controls.Add(this.PanelContenido);
            this.Controls.Add(this.PanelBarraSuperior);
            this.Controls.Add(this.PanelNavBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSettings";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuSettings_Load);
            this.PanelNavBar.ResumeLayout(false);
            this.ContenidoNavBar.ResumeLayout(false);
            this.ContenidoNavBar.PerformLayout();
            this.PanelBarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitPictureBox)).EndInit();
            this.PanelContenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoadingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelNavBar;
        private System.Windows.Forms.Panel PanelBarraSuperior;
        private System.Windows.Forms.Panel PanelContenido;
        private System.Windows.Forms.Panel ContenidoNavBar;
        private System.Windows.Forms.TextBox SettingsText;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button PageDetectionButton;
        private System.Windows.Forms.Button TextRecognitiionButton;
        private System.Windows.Forms.Button GestureRecognitionButton;
        private System.Windows.Forms.Button EyeTrackingButton;
        private System.Windows.Forms.Button WebSearchServicesButton;
        private System.Windows.Forms.Button InteractionsButton;
        private System.Windows.Forms.PictureBox ExitPictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox LoadingPictureBox;
        private Front_EDDIE_WindowsForm.ButtonModified ResetSettingsButtonModified;
        private Front_EDDIE_WindowsForm.ButtonModified SaveSettingsButtonModified;
        private Front_EDDIE_WindowsForm.ButtonModified StartProjectionButtonModified;
        //private ButtonModified StartProjectionButtonModified;
        //private ButtonModified SaveSettingsButtonModified;
        //private ButtonModified ResetSettingsButtonModified;
    }
}

