namespace AugmentedReadingApp
{
    partial class GestureRecognitionSettings
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reconocimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comenzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complementoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rastreoOcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ComboBoxCameraList2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.numericUpDownAStartY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAEndY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSStartY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSEndY = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.numericUpDownAStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAEndX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSStartX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSEndX = new System.Windows.Forms.NumericUpDown();
            this.checkBoxY = new System.Windows.Forms.CheckBox();
            this.checkBoxX = new System.Windows.Forms.CheckBox();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownXGestual = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYGestual = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxMouse = new System.Windows.Forms.CheckBox();
            this.imageBox4 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartProjectionButtonModified = new Front_EDDIE_WindowsForm.ButtonModified();
            this.buttonModified1 = new Front_EDDIE_WindowsForm.ButtonModified();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXGestual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYGestual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconocimientoToolStripMenuItem,
            this.complementoToolStripMenuItem,
            this.rastreoOcularToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // reconocimientoToolStripMenuItem
            // 
            this.reconocimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comenzarToolStripMenuItem,
            this.detenerToolStripMenuItem});
            this.reconocimientoToolStripMenuItem.Name = "reconocimientoToolStripMenuItem";
            this.reconocimientoToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.reconocimientoToolStripMenuItem.Text = "Reconocimiento";
            // 
            // comenzarToolStripMenuItem
            // 
            this.comenzarToolStripMenuItem.Name = "comenzarToolStripMenuItem";
            this.comenzarToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.comenzarToolStripMenuItem.Text = "Comenzar";
            this.comenzarToolStripMenuItem.Click += new System.EventHandler(this.comenzarToolStripMenuItem_Click);
            // 
            // detenerToolStripMenuItem
            // 
            this.detenerToolStripMenuItem.Name = "detenerToolStripMenuItem";
            this.detenerToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.detenerToolStripMenuItem.Text = "Detener";
            this.detenerToolStripMenuItem.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // complementoToolStripMenuItem
            // 
            this.complementoToolStripMenuItem.Name = "complementoToolStripMenuItem";
            this.complementoToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.complementoToolStripMenuItem.Text = "Complemento";
            // 
            // rastreoOcularToolStripMenuItem
            // 
            this.rastreoOcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurarToolStripMenuItem});
            this.rastreoOcularToolStripMenuItem.Name = "rastreoOcularToolStripMenuItem";
            this.rastreoOcularToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.rastreoOcularToolStripMenuItem.Text = "Rastreo Ocular";
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.configurarToolStripMenuItem.Text = "Configurar";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // ComboBoxCameraList2
            // 
            this.ComboBoxCameraList2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCameraList2.FormattingEnabled = true;
            this.ComboBoxCameraList2.Location = new System.Drawing.Point(11, 46);
            this.ComboBoxCameraList2.Name = "ComboBoxCameraList2";
            this.ComboBoxCameraList2.Size = new System.Drawing.Size(226, 21);
            this.ComboBoxCameraList2.TabIndex = 5;
            this.ComboBoxCameraList2.SelectedIndexChanged += new System.EventHandler(this.ComboCameras_SelectedIndexChangedGesture);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Camara para reconocimiento gestual";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(571, 379);
            this.label51.Margin = new System.Windows.Forms.Padding(0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(48, 13);
            this.label51.TabIndex = 109;
            this.label51.Text = "App End";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(384, 379);
            this.label52.Margin = new System.Windows.Forms.Padding(0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(51, 13);
            this.label52.TabIndex = 108;
            this.label52.Text = "App Start";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(571, 357);
            this.label53.Margin = new System.Windows.Forms.Padding(0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(62, 13);
            this.label53.TabIndex = 107;
            this.label53.Text = "Sensor End";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(384, 357);
            this.label54.Margin = new System.Windows.Forms.Padding(0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 13);
            this.label54.TabIndex = 106;
            this.label54.Text = "Sensor Start";
            // 
            // numericUpDownAStartY
            // 
            this.numericUpDownAStartY.Location = new System.Drawing.Point(459, 379);
            this.numericUpDownAStartY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAStartY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAStartY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAStartY.Name = "numericUpDownAStartY";
            this.numericUpDownAStartY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAStartY.TabIndex = 105;
            this.numericUpDownAStartY.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownAEndY
            // 
            this.numericUpDownAEndY.BackColor = System.Drawing.SystemColors.Window;
            this.numericUpDownAEndY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.numericUpDownAEndY.Location = new System.Drawing.Point(646, 377);
            this.numericUpDownAEndY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAEndY.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAEndY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAEndY.Name = "numericUpDownAEndY";
            this.numericUpDownAEndY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAEndY.TabIndex = 104;
            this.numericUpDownAEndY.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownSStartY
            // 
            this.numericUpDownSStartY.Location = new System.Drawing.Point(459, 355);
            this.numericUpDownSStartY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSStartY.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSStartY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSStartY.Name = "numericUpDownSStartY";
            this.numericUpDownSStartY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSStartY.TabIndex = 103;
            this.numericUpDownSStartY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSEndY
            // 
            this.numericUpDownSEndY.Location = new System.Drawing.Point(646, 355);
            this.numericUpDownSEndY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSEndY.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSEndY.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSEndY.Name = "numericUpDownSEndY";
            this.numericUpDownSEndY.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSEndY.TabIndex = 102;
            this.numericUpDownSEndY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(197, 390);
            this.label38.Margin = new System.Windows.Forms.Padding(0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(48, 13);
            this.label38.TabIndex = 101;
            this.label38.Text = "App End";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(10, 390);
            this.label39.Margin = new System.Windows.Forms.Padding(0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(51, 13);
            this.label39.TabIndex = 100;
            this.label39.Text = "App Start";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(197, 370);
            this.label40.Margin = new System.Windows.Forms.Padding(0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(62, 13);
            this.label40.TabIndex = 99;
            this.label40.Text = "Sensor End";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(10, 368);
            this.label41.Margin = new System.Windows.Forms.Padding(0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(65, 13);
            this.label41.TabIndex = 98;
            this.label41.Text = "Sensor Start";
            // 
            // numericUpDownAStartX
            // 
            this.numericUpDownAStartX.Location = new System.Drawing.Point(85, 390);
            this.numericUpDownAStartX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAStartX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAStartX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAStartX.Name = "numericUpDownAStartX";
            this.numericUpDownAStartX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAStartX.TabIndex = 97;
            this.numericUpDownAStartX.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // numericUpDownAEndX
            // 
            this.numericUpDownAEndX.Location = new System.Drawing.Point(272, 392);
            this.numericUpDownAEndX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownAEndX.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownAEndX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownAEndX.Name = "numericUpDownAEndX";
            this.numericUpDownAEndX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownAEndX.TabIndex = 96;
            this.numericUpDownAEndX.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // numericUpDownSStartX
            // 
            this.numericUpDownSStartX.Location = new System.Drawing.Point(85, 366);
            this.numericUpDownSStartX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSStartX.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSStartX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSStartX.Name = "numericUpDownSStartX";
            this.numericUpDownSStartX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSStartX.TabIndex = 95;
            this.numericUpDownSStartX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownSEndX
            // 
            this.numericUpDownSEndX.Location = new System.Drawing.Point(272, 368);
            this.numericUpDownSEndX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownSEndX.Maximum = new decimal(new int[] {
            300000,
            0,
            0,
            0});
            this.numericUpDownSEndX.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownSEndX.Name = "numericUpDownSEndX";
            this.numericUpDownSEndX.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownSEndX.TabIndex = 94;
            this.numericUpDownSEndX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBoxY
            // 
            this.checkBoxY.AutoSize = true;
            this.checkBoxY.Location = new System.Drawing.Point(387, 328);
            this.checkBoxY.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxY.Name = "checkBoxY";
            this.checkBoxY.Size = new System.Drawing.Size(92, 17);
            this.checkBoxY.TabIndex = 93;
            this.checkBoxY.Text = "Transformar Y";
            this.checkBoxY.UseVisualStyleBackColor = true;
            // 
            // checkBoxX
            // 
            this.checkBoxX.AutoSize = true;
            this.checkBoxX.Location = new System.Drawing.Point(13, 333);
            this.checkBoxX.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxX.Name = "checkBoxX";
            this.checkBoxX.Size = new System.Drawing.Size(92, 17);
            this.checkBoxX.TabIndex = 92;
            this.checkBoxX.Text = "Transformar X";
            this.checkBoxX.UseVisualStyleBackColor = true;
            // 
            // buttonSetting
            // 
            this.buttonSetting.Location = new System.Drawing.Point(624, 410);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(121, 44);
            this.buttonSetting.TabIndex = 110;
            this.buttonSetting.Text = "Save Settings";
            this.buttonSetting.UseVisualStyleBackColor = true;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(272, 330);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(90, 20);
            this.textBoxX.TabIndex = 119;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(646, 326);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(90, 20);
            this.textBoxY.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Sensor X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 122;
            this.label3.Text = "Sensor Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "X";
            // 
            // numericUpDownXGestual
            // 
            this.numericUpDownXGestual.Location = new System.Drawing.Point(11, 72);
            this.numericUpDownXGestual.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownXGestual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownXGestual.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownXGestual.Name = "numericUpDownXGestual";
            this.numericUpDownXGestual.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownXGestual.TabIndex = 138;
            this.numericUpDownXGestual.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            // 
            // numericUpDownYGestual
            // 
            this.numericUpDownYGestual.Location = new System.Drawing.Point(148, 74);
            this.numericUpDownYGestual.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.numericUpDownYGestual.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownYGestual.Minimum = new decimal(new int[] {
            3000,
            0,
            0,
            -2147483648});
            this.numericUpDownYGestual.Name = "numericUpDownYGestual";
            this.numericUpDownYGestual.Size = new System.Drawing.Size(90, 20);
            this.numericUpDownYGestual.TabIndex = 139;
            this.numericUpDownYGestual.Value = new decimal(new int[] {
            720,
            0,
            0,
            0});
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(245, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 54);
            this.button4.TabIndex = 140;
            this.button4.Text = "Captura";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxMouse
            // 
            this.checkBoxMouse.AutoSize = true;
            this.checkBoxMouse.Location = new System.Drawing.Point(387, 425);
            this.checkBoxMouse.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.checkBoxMouse.Name = "checkBoxMouse";
            this.checkBoxMouse.Size = new System.Drawing.Size(98, 17);
            this.checkBoxMouse.TabIndex = 161;
            this.checkBoxMouse.Text = "Recognition on";
            this.checkBoxMouse.UseVisualStyleBackColor = true;
            // 
            // imageBox4
            // 
            this.imageBox4.Location = new System.Drawing.Point(369, 103);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(352, 200);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox4.TabIndex = 126;
            this.imageBox4.TabStop = false;
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(11, 103);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(352, 200);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 124;
            this.imageBox2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(369, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 21);
            this.comboBox1.TabIndex = 162;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 13);
            this.label4.TabIndex = 163;
            this.label4.Text = "Complemento de reconocimiento";
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
            this.StartProjectionButtonModified.Location = new System.Drawing.Point(739, 46);
            this.StartProjectionButtonModified.Name = "StartProjectionButtonModified";
            this.StartProjectionButtonModified.Size = new System.Drawing.Size(178, 48);
            this.StartProjectionButtonModified.TabIndex = 164;
            this.StartProjectionButtonModified.Text = "Comenzar";
            this.StartProjectionButtonModified.UseVisualStyleBackColor = false;
            this.StartProjectionButtonModified.Click += new System.EventHandler(this.comenzarToolStripMenuItem_Click);
            // 
            // buttonModified1
            // 
            this.buttonModified1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(157)))), ((int)(((byte)(236)))));
            this.buttonModified1.FlatAppearance.BorderSize = 5;
            this.buttonModified1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(202)))));
            this.buttonModified1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.buttonModified1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified1.Font = new System.Drawing.Font("IBM Plex Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModified1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonModified1.Location = new System.Drawing.Point(739, 103);
            this.buttonModified1.Name = "buttonModified1";
            this.buttonModified1.Size = new System.Drawing.Size(178, 48);
            this.buttonModified1.TabIndex = 165;
            this.buttonModified1.Text = "Detener";
            this.buttonModified1.UseVisualStyleBackColor = false;
            this.buttonModified1.Click += new System.EventHandler(this.detenerToolStripMenuItem_Click);
            // 
            // GestureRecognitionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 654);
            this.Controls.Add(this.buttonModified1);
            this.Controls.Add(this.StartProjectionButtonModified);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxMouse);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.numericUpDownYGestual);
            this.Controls.Add(this.numericUpDownXGestual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageBox4);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttonSetting);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label54);
            this.Controls.Add(this.numericUpDownAStartY);
            this.Controls.Add(this.numericUpDownAEndY);
            this.Controls.Add(this.numericUpDownSStartY);
            this.Controls.Add(this.numericUpDownSEndY);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.numericUpDownAStartX);
            this.Controls.Add(this.numericUpDownAEndX);
            this.Controls.Add(this.numericUpDownSStartX);
            this.Controls.Add(this.numericUpDownSEndX);
            this.Controls.Add(this.checkBoxY);
            this.Controls.Add(this.checkBoxX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxCameraList2);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GestureRecognitionSettings";
            this.Text = "Configuración";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXGestual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYGestual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reconocimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comenzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complementoToolStripMenuItem;
        private System.Windows.Forms.ComboBox ComboBoxCameraList2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        public System.Windows.Forms.NumericUpDown numericUpDownAStartY;
        public System.Windows.Forms.NumericUpDown numericUpDownAEndY;
        public System.Windows.Forms.NumericUpDown numericUpDownSStartY;
        public System.Windows.Forms.NumericUpDown numericUpDownSEndY;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        public System.Windows.Forms.NumericUpDown numericUpDownAStartX;
        public System.Windows.Forms.NumericUpDown numericUpDownAEndX;
        public System.Windows.Forms.NumericUpDown numericUpDownSStartX;
        public System.Windows.Forms.NumericUpDown numericUpDownSEndX;
        private System.Windows.Forms.CheckBox checkBoxY;
        private System.Windows.Forms.CheckBox checkBoxX;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown numericUpDownXGestual;
        public System.Windows.Forms.NumericUpDown numericUpDownYGestual;
        private System.Windows.Forms.Button button4;
        public System.Windows.Forms.CheckBox checkBoxMouse;
        private System.Windows.Forms.ToolStripMenuItem rastreoOcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private Front_EDDIE_WindowsForm.ButtonModified StartProjectionButtonModified;
        private Front_EDDIE_WindowsForm.ButtonModified buttonModified1;
    }
}
