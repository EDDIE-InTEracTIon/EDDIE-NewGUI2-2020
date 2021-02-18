namespace AugmentedReadingApp
{
    partial class PageDetectionSettings2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PDFSelectBt = new System.Windows.Forms.Button();
            this.textBoxPathPDF = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Resize = new System.Windows.Forms.Button();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.FinalLocateY = new System.Windows.Forms.NumericUpDown();
            this.FinalLocateX = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalLocateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalLocateX)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PDFSelectBt
            // 
            this.PDFSelectBt.Location = new System.Drawing.Point(344, 53);
            this.PDFSelectBt.Name = "PDFSelectBt";
            this.PDFSelectBt.Size = new System.Drawing.Size(75, 47);
            this.PDFSelectBt.TabIndex = 142;
            this.PDFSelectBt.Text = "Seleccionar PDF";
            this.PDFSelectBt.UseVisualStyleBackColor = true;
            this.PDFSelectBt.Click += new System.EventHandler(this.PDFSelectBt_Click);
            // 
            // textBoxPathPDF
            // 
            this.textBoxPathPDF.Location = new System.Drawing.Point(21, 79);
            this.textBoxPathPDF.Name = "textBoxPathPDF";
            this.textBoxPathPDF.Size = new System.Drawing.Size(317, 20);
            this.textBoxPathPDF.TabIndex = 143;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(27, 122);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 144;
            this.numericUpDown1.Value = new decimal(new int[] {
            2159,
            0,
            0,
            131072});
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Location = new System.Drawing.Point(149, 122);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown2.TabIndex = 145;
            this.numericUpDown2.Value = new decimal(new int[] {
            2794,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 146;
            this.label6.Text = "cm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 147;
            this.label7.Text = "cm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 148;
            this.label8.Text = "Tamaño del texto";
            // 
            // Resize
            // 
            this.Resize.Location = new System.Drawing.Point(344, 185);
            this.Resize.Name = "Resize";
            this.Resize.Size = new System.Drawing.Size(75, 23);
            this.Resize.TabIndex = 149;
            this.Resize.Text = "Resize";
            this.Resize.UseVisualStyleBackColor = true;
            this.Resize.Click += new System.EventHandler(this.Resize_Click);
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(27, 155);
            this.numericUpDown5.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown5.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown5.TabIndex = 152;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(149, 155);
            this.numericUpDown6.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDown6.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown6.TabIndex = 153;
            this.numericUpDown6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FinalLocateY
            // 
            this.FinalLocateY.Location = new System.Drawing.Point(149, 188);
            this.FinalLocateY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.FinalLocateY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.FinalLocateY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.FinalLocateY.Name = "FinalLocateY";
            this.FinalLocateY.Size = new System.Drawing.Size(90, 20);
            this.FinalLocateY.TabIndex = 155;
            this.FinalLocateY.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // FinalLocateX
            // 
            this.FinalLocateX.Location = new System.Drawing.Point(27, 188);
            this.FinalLocateX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.FinalLocateX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.FinalLocateX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.FinalLocateX.Name = "FinalLocateX";
            this.FinalLocateX.Size = new System.Drawing.Size(90, 20);
            this.FinalLocateX.TabIndex = 154;
            this.FinalLocateX.Value = new decimal(new int[] {
            757,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(120, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 156;
            this.label9.Text = "pix";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(242, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 157;
            this.label10.Text = "pix";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(120, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 158;
            this.label11.Text = "uu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(243, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 159;
            this.label12.Text = "uu";
            // 
            // PageDetectionSettings2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 654);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.FinalLocateY);
            this.Controls.Add(this.FinalLocateX);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.Resize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBoxPathPDF);
            this.Controls.Add(this.PDFSelectBt);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PageDetectionSettings2";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalLocateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalLocateX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button PDFSelectBt;
        private System.Windows.Forms.TextBox textBoxPathPDF;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        public System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Resize;
        public System.Windows.Forms.NumericUpDown numericUpDown5;
        public System.Windows.Forms.NumericUpDown numericUpDown6;
        public System.Windows.Forms.NumericUpDown FinalLocateY;
        public System.Windows.Forms.NumericUpDown FinalLocateX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}
