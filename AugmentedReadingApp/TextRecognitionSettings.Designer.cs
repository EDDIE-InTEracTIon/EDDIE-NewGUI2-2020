namespace AugmentedReadingApp
{
    partial class TextRecognitionSettings
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBoxCameraList1 = new System.Windows.Forms.ComboBox();
            this.labelRecTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownResXText = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownResYText = new System.Windows.Forms.NumericUpDown();
            this.imageBox3 = new Emgu.CV.UI.ImageBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResXText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResYText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Comenzar Proyección";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ProyectionActivityBt);
            // 
            // ComboBoxCameraList1
            // 
            this.ComboBoxCameraList1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCameraList1.FormattingEnabled = true;
            this.ComboBoxCameraList1.Location = new System.Drawing.Point(12, 30);
            this.ComboBoxCameraList1.Name = "ComboBoxCameraList1";
            this.ComboBoxCameraList1.Size = new System.Drawing.Size(226, 21);
            this.ComboBoxCameraList1.TabIndex = 2;
            this.ComboBoxCameraList1.SelectedIndexChanged += new System.EventHandler(this.ComboCameras_SelectedIndexChangedText);
            // 
            // labelRecTxt
            // 
            this.labelRecTxt.AutoSize = true;
            this.labelRecTxt.Location = new System.Drawing.Point(12, 14);
            this.labelRecTxt.Name = "labelRecTxt";
            this.labelRecTxt.Size = new System.Drawing.Size(215, 13);
            this.labelRecTxt.TabIndex = 4;
            this.labelRecTxt.Text = "Camara para reconocimiento de texto (OCR)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 134;
            this.label4.Text = "X";
            // 
            // numericUpDownResXText
            // 
            this.numericUpDownResXText.Location = new System.Drawing.Point(12, 56);
            this.numericUpDownResXText.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownResXText.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownResXText.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownResXText.Name = "numericUpDownResXText";
            this.numericUpDownResXText.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownResXText.TabIndex = 136;
            this.numericUpDownResXText.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // numericUpDownResYText
            // 
            this.numericUpDownResYText.Location = new System.Drawing.Point(148, 56);
            this.numericUpDownResYText.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownResYText.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownResYText.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownResYText.Name = "numericUpDownResYText";
            this.numericUpDownResYText.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownResYText.TabIndex = 137;
            this.numericUpDownResYText.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // imageBox3
            // 
            this.imageBox3.Location = new System.Drawing.Point(376, 98);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(352, 200);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox3.TabIndex = 125;
            this.imageBox3.TabStop = false;
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(14, 98);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(352, 200);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // TextRecognitionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 654);
            this.Controls.Add(this.numericUpDownResYText);
            this.Controls.Add(this.numericUpDownResXText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageBox3);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.labelRecTxt);
            this.Controls.Add(this.ComboBoxCameraList1);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "TextRecognitionSettings";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResXText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownResYText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBoxCameraList1;
        private System.Windows.Forms.Label labelRecTxt;
        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown numericUpDownResXText;
        public System.Windows.Forms.NumericUpDown numericUpDownResYText;
    }
}
