namespace AugmentedReadingApp
{
    partial class ProjectionScreenActivity2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.markButton = new System.Windows.Forms.Button();
            this.textImageButton = new System.Windows.Forms.Button();
            this.syncButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_turnOFF = new ModuloRastreoOcular.ButtonAlt();
            this.Pages = new System.Windows.Forms.Label();
            this.PagesLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.nextPageButton = new System.Windows.Forms.Button();
            this.backPagebutton = new System.Windows.Forms.Button();
            this.btn_leerEnciclopedia = new ModuloRastreoOcular.ButtonAlt();
            this.btn_nav_adelante = new ModuloRastreoOcular.ButtonAlt();
            this.btn_nav_atras = new ModuloRastreoOcular.ButtonAlt();
            this.btn_cerrarVentanaDerecha = new ModuloRastreoOcular.ButtonAlt();
            this.lbl_PalabraBuscada = new System.Windows.Forms.Label();
            this.panel_navegador = new System.Windows.Forms.Panel();
            this.rtb_ResultadosWikipedia = new System.Windows.Forms.RichTextBox();
            this.lbl_datoBuscado_trad_def = new System.Windows.Forms.Label();
            this.rtb_result_definicion_traduccion = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_log = new System.Windows.Forms.Panel();
            this.gb_busquedasRecientes = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonEliminarComentario = new System.Windows.Forms.Button();
            this.buttonEliminarMarcador = new System.Windows.Forms.Button();
            this.comentariosPDF = new System.Windows.Forms.Label();
            this.labelMarcadoresPDF = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fl_busquedasRecientes = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonComments = new System.Windows.Forms.Button();
            this.buttonMarker = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonFiguresPD = new System.Windows.Forms.Button();
            this.btn_drawMenu = new ModuloRastreoOcular.ButtonAlt();
            this.btn_diccionario = new ModuloRastreoOcular.ButtonAlt();
            this.btn_imagen = new ModuloRastreoOcular.ButtonAlt();
            this.btn_video = new ModuloRastreoOcular.ButtonAlt();
            this.btn_enciclopedia = new ModuloRastreoOcular.ButtonAlt();
            this.btn_traductor = new ModuloRastreoOcular.ButtonAlt();
            this.btn_buscarWeb = new ModuloRastreoOcular.ButtonAlt();
            this.btn_cerrarVentanaIzquierda = new ModuloRastreoOcular.ButtonAlt();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_leerDefinicionTraduccion = new ModuloRastreoOcular.ButtonAlt();
            this.btn_sincronizadorPdf = new ModuloRastreoOcular.ButtonAlt();
            this.panel2.SuspendLayout();
            this.panel_navegador.SuspendLayout();
            this.panel_log.SuspendLayout();
            this.gb_busquedasRecientes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(441, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 38);
            this.textBox1.TabIndex = 6;
            // 
            // markButton
            // 
            this.markButton.Location = new System.Drawing.Point(276, 619);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(101, 59);
            this.markButton.TabIndex = 89;
            this.markButton.Text = "Marcas ";
            this.markButton.UseVisualStyleBackColor = true;
            this.markButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textImageButton
            // 
            this.textImageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.textImageButton.FlatAppearance.BorderSize = 0;
            this.textImageButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.textImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.textImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.textImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textImageButton.Image = global::AugmentedReadingApp.Properties.Resources.HighlightModeButtonImage;
            this.textImageButton.Location = new System.Drawing.Point(553, 510);
            this.textImageButton.Name = "textImageButton";
            this.textImageButton.Size = new System.Drawing.Size(60, 60);
            this.textImageButton.TabIndex = 91;
            this.textImageButton.UseVisualStyleBackColor = false;
            this.textImageButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // syncButton
            // 
            this.syncButton.FlatAppearance.BorderSize = 0;
            this.syncButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.syncButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.syncButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.syncButton.Image = global::AugmentedReadingApp.Properties.Resources.SyncHighlightsButtonImage;
            this.syncButton.Location = new System.Drawing.Point(78, 564);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(81, 61);
            this.syncButton.TabIndex = 92;
            this.syncButton.UseVisualStyleBackColor = true;
            this.syncButton.Click += new System.EventHandler(this.syncPdfButton_Click);
            this.syncButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.syncButton_MouseDown);
            this.syncButton.MouseEnter += new System.EventHandler(this.syncButton_MouseEnter);
            this.syncButton.MouseLeave += new System.EventHandler(this.syncButton_MouseLeave);
            this.syncButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.syncButton_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_turnOFF);
            this.panel2.Controls.Add(this.Pages);
            this.panel2.Controls.Add(this.PagesLabel);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.searchTextBox);
            this.panel2.Controls.Add(this.nextPageButton);
            this.panel2.Controls.Add(this.backPagebutton);
            this.panel2.Controls.Add(this.btn_leerEnciclopedia);
            this.panel2.Controls.Add(this.btn_nav_adelante);
            this.panel2.Controls.Add(this.syncButton);
            this.panel2.Controls.Add(this.btn_nav_atras);
            this.panel2.Controls.Add(this.btn_cerrarVentanaDerecha);
            this.panel2.Controls.Add(this.markButton);
            this.panel2.Controls.Add(this.lbl_PalabraBuscada);
            this.panel2.Controls.Add(this.panel_navegador);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(900, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 720);
            this.panel2.TabIndex = 95;
            // 
            // btn_turnOFF
            // 
            this.btn_turnOFF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_turnOFF.FlatAppearance.BorderSize = 0;
            this.btn_turnOFF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_turnOFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_turnOFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_turnOFF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_turnOFF.Image = global::AugmentedReadingApp.Properties.Resources.TurnOffButtonImage;
            this.btn_turnOFF.Location = new System.Drawing.Point(276, 3);
            this.btn_turnOFF.Name = "btn_turnOFF";
            this.btn_turnOFF.Size = new System.Drawing.Size(81, 61);
            this.btn_turnOFF.TabIndex = 141;
            this.btn_turnOFF.UseVisualStyleBackColor = false;
            this.btn_turnOFF.Visible = false;
            this.btn_turnOFF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_turnOFF_MouseDown);
            this.btn_turnOFF.MouseEnter += new System.EventHandler(this.btn_turnOFF_MouseEnter);
            this.btn_turnOFF.MouseLeave += new System.EventHandler(this.btn_turnOFF_MouseLeave);
            this.btn_turnOFF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_turnOFF_MouseUp);
            // 
            // Pages
            // 
            this.Pages.AutoSize = true;
            this.Pages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.Pages.Location = new System.Drawing.Point(15, 656);
            this.Pages.Name = "Pages";
            this.Pages.Size = new System.Drawing.Size(54, 16);
            this.Pages.TabIndex = 134;
            this.Pages.Text = "Pages :";
            // 
            // PagesLabel
            // 
            this.PagesLabel.AutoSize = true;
            this.PagesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.PagesLabel.Location = new System.Drawing.Point(75, 657);
            this.PagesLabel.Name = "PagesLabel";
            this.PagesLabel.Size = new System.Drawing.Size(20, 16);
            this.PagesLabel.TabIndex = 133;
            this.PagesLabel.Text = "---";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(174, 627);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(59, 51);
            this.searchButton.TabIndex = 132;
            this.searchButton.Text = "Search Pages";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(10, 627);
            this.searchTextBox.Multiline = true;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(162, 21);
            this.searchTextBox.TabIndex = 131;
            // 
            // nextPageButton
            // 
            this.nextPageButton.Location = new System.Drawing.Point(174, 581);
            this.nextPageButton.Name = "nextPageButton";
            this.nextPageButton.Size = new System.Drawing.Size(59, 44);
            this.nextPageButton.TabIndex = 95;
            this.nextPageButton.Text = ">>";
            this.nextPageButton.UseVisualStyleBackColor = true;
            this.nextPageButton.Click += new System.EventHandler(this.nextPageButton_Click);
            // 
            // backPagebutton
            // 
            this.backPagebutton.Location = new System.Drawing.Point(10, 581);
            this.backPagebutton.Name = "backPagebutton";
            this.backPagebutton.Size = new System.Drawing.Size(59, 44);
            this.backPagebutton.TabIndex = 94;
            this.backPagebutton.Text = "<<";
            this.backPagebutton.UseVisualStyleBackColor = true;
            this.backPagebutton.Click += new System.EventHandler(this.backPagebutton_Click);
            // 
            // btn_leerEnciclopedia
            // 
            this.btn_leerEnciclopedia.FlatAppearance.BorderSize = 0;
            this.btn_leerEnciclopedia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_leerEnciclopedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_leerEnciclopedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_leerEnciclopedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leerEnciclopedia.Image = global::AugmentedReadingApp.Properties.Resources.ReadButtonImage;
            this.btn_leerEnciclopedia.Location = new System.Drawing.Point(200, 463);
            this.btn_leerEnciclopedia.Name = "btn_leerEnciclopedia";
            this.btn_leerEnciclopedia.Size = new System.Drawing.Size(81, 61);
            this.btn_leerEnciclopedia.TabIndex = 93;
            this.btn_leerEnciclopedia.UseVisualStyleBackColor = true;
            this.btn_leerEnciclopedia.Visible = false;
            this.btn_leerEnciclopedia.Click += new System.EventHandler(this.btn_leerEnciclopedia_Click);
            this.btn_leerEnciclopedia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_leerEnciclopedia_MouseDown);
            this.btn_leerEnciclopedia.MouseEnter += new System.EventHandler(this.btn_leerEnciclopedia_MouseEnter);
            this.btn_leerEnciclopedia.MouseLeave += new System.EventHandler(this.btn_leerEnciclopedia_MouseLeave);
            this.btn_leerEnciclopedia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_leerEnciclopedia_MouseUp);
            // 
            // btn_nav_adelante
            // 
            this.btn_nav_adelante.FlatAppearance.BorderSize = 0;
            this.btn_nav_adelante.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_adelante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_adelante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_adelante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nav_adelante.Image = global::AugmentedReadingApp.Properties.Resources.RightArrowButtonImage;
            this.btn_nav_adelante.Location = new System.Drawing.Point(100, 463);
            this.btn_nav_adelante.Name = "btn_nav_adelante";
            this.btn_nav_adelante.Size = new System.Drawing.Size(81, 61);
            this.btn_nav_adelante.TabIndex = 7;
            this.btn_nav_adelante.UseVisualStyleBackColor = true;
            this.btn_nav_adelante.Visible = false;
            this.btn_nav_adelante.Click += new System.EventHandler(this.btn_nav_adelante_Click);
            this.btn_nav_adelante.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_nav_adelante_MouseDown);
            this.btn_nav_adelante.MouseEnter += new System.EventHandler(this.btn_nav_adelante_MouseEnter);
            this.btn_nav_adelante.MouseLeave += new System.EventHandler(this.btn_nav_adelante_MouseLeave);
            this.btn_nav_adelante.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_nav_adelante_MouseUp);
            // 
            // btn_nav_atras
            // 
            this.btn_nav_atras.FlatAppearance.BorderSize = 0;
            this.btn_nav_atras.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_nav_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nav_atras.Image = global::AugmentedReadingApp.Properties.Resources.LeftArrowButtonImage;
            this.btn_nav_atras.Location = new System.Drawing.Point(10, 462);
            this.btn_nav_atras.Name = "btn_nav_atras";
            this.btn_nav_atras.Size = new System.Drawing.Size(81, 61);
            this.btn_nav_atras.TabIndex = 6;
            this.btn_nav_atras.UseVisualStyleBackColor = true;
            this.btn_nav_atras.Visible = false;
            this.btn_nav_atras.Click += new System.EventHandler(this.btn_nav_atras_Click);
            this.btn_nav_atras.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_nav_atras_MouseDown);
            this.btn_nav_atras.MouseEnter += new System.EventHandler(this.btn_nav_atras_MouseEnter);
            this.btn_nav_atras.MouseLeave += new System.EventHandler(this.btn_nav_atras_MouseLeave);
            this.btn_nav_atras.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_nav_atras_MouseUp);
            // 
            // btn_cerrarVentanaDerecha
            // 
            this.btn_cerrarVentanaDerecha.FlatAppearance.BorderSize = 0;
            this.btn_cerrarVentanaDerecha.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentanaDerecha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentanaDerecha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentanaDerecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarVentanaDerecha.Image = global::AugmentedReadingApp.Properties.Resources.XButtonImage;
            this.btn_cerrarVentanaDerecha.Location = new System.Drawing.Point(291, 463);
            this.btn_cerrarVentanaDerecha.Name = "btn_cerrarVentanaDerecha";
            this.btn_cerrarVentanaDerecha.Size = new System.Drawing.Size(81, 61);
            this.btn_cerrarVentanaDerecha.TabIndex = 3;
            this.btn_cerrarVentanaDerecha.UseVisualStyleBackColor = true;
            this.btn_cerrarVentanaDerecha.Visible = false;
            this.btn_cerrarVentanaDerecha.Click += new System.EventHandler(this.btn_cerrarVentanaDerecha_Click);
            this.btn_cerrarVentanaDerecha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cerrarVentanaDerecha_MouseDown);
            this.btn_cerrarVentanaDerecha.MouseEnter += new System.EventHandler(this.btn_cerrarVentanaDerecha_MouseEnter);
            this.btn_cerrarVentanaDerecha.MouseLeave += new System.EventHandler(this.btn_cerrarVentanaDerecha_MouseLeave);
            this.btn_cerrarVentanaDerecha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cerrarVentanaDerecha_MouseUp);
            // 
            // lbl_PalabraBuscada
            // 
            this.lbl_PalabraBuscada.AutoSize = true;
            this.lbl_PalabraBuscada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PalabraBuscada.Location = new System.Drawing.Point(181, 19);
            this.lbl_PalabraBuscada.Name = "lbl_PalabraBuscada";
            this.lbl_PalabraBuscada.Size = new System.Drawing.Size(0, 24);
            this.lbl_PalabraBuscada.TabIndex = 2;
            this.lbl_PalabraBuscada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_PalabraBuscada.Visible = false;
            // 
            // panel_navegador
            // 
            this.panel_navegador.Controls.Add(this.rtb_ResultadosWikipedia);
            this.panel_navegador.Location = new System.Drawing.Point(7, 63);
            this.panel_navegador.Name = "panel_navegador";
            this.panel_navegador.Size = new System.Drawing.Size(365, 393);
            this.panel_navegador.TabIndex = 5;
            // 
            // rtb_ResultadosWikipedia
            // 
            this.rtb_ResultadosWikipedia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ResultadosWikipedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_ResultadosWikipedia.Location = new System.Drawing.Point(0, 1);
            this.rtb_ResultadosWikipedia.Name = "rtb_ResultadosWikipedia";
            this.rtb_ResultadosWikipedia.Size = new System.Drawing.Size(365, 393);
            this.rtb_ResultadosWikipedia.TabIndex = 2;
            this.rtb_ResultadosWikipedia.Text = "";
            this.rtb_ResultadosWikipedia.Visible = false;
            // 
            // lbl_datoBuscado_trad_def
            // 
            this.lbl_datoBuscado_trad_def.AutoSize = true;
            this.lbl_datoBuscado_trad_def.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datoBuscado_trad_def.Location = new System.Drawing.Point(91, 97);
            this.lbl_datoBuscado_trad_def.Name = "lbl_datoBuscado_trad_def";
            this.lbl_datoBuscado_trad_def.Size = new System.Drawing.Size(60, 24);
            this.lbl_datoBuscado_trad_def.TabIndex = 1;
            this.lbl_datoBuscado_trad_def.Text = "label1";
            this.lbl_datoBuscado_trad_def.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_datoBuscado_trad_def.Visible = false;
            // 
            // rtb_result_definicion_traduccion
            // 
            this.rtb_result_definicion_traduccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_result_definicion_traduccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_result_definicion_traduccion.Location = new System.Drawing.Point(5, 138);
            this.rtb_result_definicion_traduccion.Name = "rtb_result_definicion_traduccion";
            this.rtb_result_definicion_traduccion.Size = new System.Drawing.Size(237, 230);
            this.rtb_result_definicion_traduccion.TabIndex = 0;
            this.rtb_result_definicion_traduccion.Text = "";
            this.rtb_result_definicion_traduccion.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_log
            // 
            this.panel_log.Controls.Add(this.gb_busquedasRecientes);
            this.panel_log.Location = new System.Drawing.Point(0, 83);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(278, 625);
            this.panel_log.TabIndex = 129;
            // 
            // gb_busquedasRecientes
            // 
            this.gb_busquedasRecientes.Controls.Add(this.groupBox1);
            this.gb_busquedasRecientes.Controls.Add(this.label1);
            this.gb_busquedasRecientes.Controls.Add(this.fl_busquedasRecientes);
            this.gb_busquedasRecientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_busquedasRecientes.Location = new System.Drawing.Point(3, 3);
            this.gb_busquedasRecientes.Name = "gb_busquedasRecientes";
            this.gb_busquedasRecientes.Size = new System.Drawing.Size(272, 619);
            this.gb_busquedasRecientes.TabIndex = 0;
            this.gb_busquedasRecientes.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEliminarComentario);
            this.groupBox1.Controls.Add(this.buttonEliminarMarcador);
            this.groupBox1.Controls.Add(this.comentariosPDF);
            this.groupBox1.Controls.Add(this.labelMarcadoresPDF);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 440);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contenido PDF";
            // 
            // buttonEliminarComentario
            // 
            this.buttonEliminarComentario.Enabled = false;
            this.buttonEliminarComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarComentario.Location = new System.Drawing.Point(139, 413);
            this.buttonEliminarComentario.Name = "buttonEliminarComentario";
            this.buttonEliminarComentario.Size = new System.Drawing.Size(107, 27);
            this.buttonEliminarComentario.TabIndex = 6;
            this.buttonEliminarComentario.Text = "Eliminar comentario";
            this.buttonEliminarComentario.UseVisualStyleBackColor = true;
            this.buttonEliminarComentario.Click += new System.EventHandler(this.buttonEliminarComentario_Click);
            // 
            // buttonEliminarMarcador
            // 
            this.buttonEliminarMarcador.Enabled = false;
            this.buttonEliminarMarcador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarMarcador.Location = new System.Drawing.Point(136, 219);
            this.buttonEliminarMarcador.Name = "buttonEliminarMarcador";
            this.buttonEliminarMarcador.Size = new System.Drawing.Size(107, 27);
            this.buttonEliminarMarcador.TabIndex = 5;
            this.buttonEliminarMarcador.Text = "Eliminar marcador";
            this.buttonEliminarMarcador.UseVisualStyleBackColor = true;
            this.buttonEliminarMarcador.Click += new System.EventHandler(this.buttonEliminarMarcador_Click);
            // 
            // comentariosPDF
            // 
            this.comentariosPDF.AutoSize = true;
            this.comentariosPDF.Location = new System.Drawing.Point(6, 253);
            this.comentariosPDF.Name = "comentariosPDF";
            this.comentariosPDF.Size = new System.Drawing.Size(104, 15);
            this.comentariosPDF.TabIndex = 4;
            this.comentariosPDF.Text = "Comentarios PDF";
            // 
            // labelMarcadoresPDF
            // 
            this.labelMarcadoresPDF.AutoSize = true;
            this.labelMarcadoresPDF.Location = new System.Drawing.Point(3, 60);
            this.labelMarcadoresPDF.Name = "labelMarcadoresPDF";
            this.labelMarcadoresPDF.Size = new System.Drawing.Size(100, 15);
            this.labelMarcadoresPDF.TabIndex = 3;
            this.labelMarcadoresPDF.Text = "Marcadores PDF";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(6, 271);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(240, 139);
            this.listBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 77);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(240, 139);
            this.listBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(9, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(177, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Mostrar/Esconder figuras";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busquedas recientes";
            // 
            // fl_busquedasRecientes
            // 
            this.fl_busquedasRecientes.AutoScroll = true;
            this.fl_busquedasRecientes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fl_busquedasRecientes.Location = new System.Drawing.Point(2, 19);
            this.fl_busquedasRecientes.Name = "fl_busquedasRecientes";
            this.fl_busquedasRecientes.Size = new System.Drawing.Size(269, 151);
            this.fl_busquedasRecientes.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 139;
            this.label2.Text = "2";
            // 
            // buttonComments
            // 
            this.buttonComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonComments.FlatAppearance.BorderSize = 0;
            this.buttonComments.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonComments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonComments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonComments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonComments.Image = global::AugmentedReadingApp.Properties.Resources.CommentsButtonImage;
            this.buttonComments.Location = new System.Drawing.Point(412, 606);
            this.buttonComments.Name = "buttonComments";
            this.buttonComments.Size = new System.Drawing.Size(81, 61);
            this.buttonComments.TabIndex = 134;
            this.buttonComments.UseVisualStyleBackColor = false;
            this.buttonComments.Visible = false;
            this.buttonComments.Click += new System.EventHandler(this.buttonComments_Click);
            this.buttonComments.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonComments_MouseDown);
            this.buttonComments.MouseEnter += new System.EventHandler(this.buttonComments_MouseEnter);
            this.buttonComments.MouseLeave += new System.EventHandler(this.buttonComments_MouseLeave);
            this.buttonComments.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonComments_MouseUp);
            // 
            // buttonMarker
            // 
            this.buttonMarker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonMarker.FlatAppearance.BorderSize = 0;
            this.buttonMarker.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonMarker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMarker.Image = global::AugmentedReadingApp.Properties.Resources.BookmarkButtonImage;
            this.buttonMarker.Location = new System.Drawing.Point(499, 606);
            this.buttonMarker.Name = "buttonMarker";
            this.buttonMarker.Size = new System.Drawing.Size(81, 61);
            this.buttonMarker.TabIndex = 133;
            this.buttonMarker.UseVisualStyleBackColor = false;
            this.buttonMarker.Visible = false;
            this.buttonMarker.Click += new System.EventHandler(this.buttonMarker_Click);
            this.buttonMarker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMarker_MouseDown);
            this.buttonMarker.MouseEnter += new System.EventHandler(this.buttonMarker_MouseEnter);
            this.buttonMarker.MouseLeave += new System.EventHandler(this.buttonMarker_MouseLeave);
            this.buttonMarker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonMarker_MouseUp);
            // 
            // buttonPDF
            // 
            this.buttonPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonPDF.FlatAppearance.BorderSize = 0;
            this.buttonPDF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPDF.Image = global::AugmentedReadingApp.Properties.Resources.ContentButtonImage;
            this.buttonPDF.Location = new System.Drawing.Point(673, 606);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(81, 61);
            this.buttonPDF.TabIndex = 132;
            this.buttonPDF.UseVisualStyleBackColor = false;
            this.buttonPDF.Visible = false;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            this.buttonPDF.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPDF_MouseDown);
            this.buttonPDF.MouseEnter += new System.EventHandler(this.buttonPDF_MouseEnter);
            this.buttonPDF.MouseLeave += new System.EventHandler(this.buttonPDF_MouseLeave);
            this.buttonPDF.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPDF_MouseUp);
            // 
            // buttonFiguresPD
            // 
            this.buttonFiguresPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.buttonFiguresPD.FlatAppearance.BorderSize = 0;
            this.buttonFiguresPD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonFiguresPD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonFiguresPD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonFiguresPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFiguresPD.Image = global::AugmentedReadingApp.Properties.Resources.FiguresButtonnImage;
            this.buttonFiguresPD.Location = new System.Drawing.Point(586, 606);
            this.buttonFiguresPD.Name = "buttonFiguresPD";
            this.buttonFiguresPD.Size = new System.Drawing.Size(81, 61);
            this.buttonFiguresPD.TabIndex = 131;
            this.buttonFiguresPD.UseVisualStyleBackColor = false;
            this.buttonFiguresPD.Visible = false;
            this.buttonFiguresPD.Click += new System.EventHandler(this.buttonFiguresPD_Click);
            this.buttonFiguresPD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonFiguresPD_MouseDown);
            this.buttonFiguresPD.MouseEnter += new System.EventHandler(this.buttonFiguresPD_MouseEnter);
            this.buttonFiguresPD.MouseLeave += new System.EventHandler(this.buttonFiguresPD_MouseLeave);
            this.buttonFiguresPD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonFiguresPD_MouseUp);
            // 
            // btn_drawMenu
            // 
            this.btn_drawMenu.FlatAppearance.BorderSize = 0;
            this.btn_drawMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_drawMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_drawMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_drawMenu.Image = global::AugmentedReadingApp.Properties.Resources.HistoryButtonImage;
            this.btn_drawMenu.Location = new System.Drawing.Point(12, 12);
            this.btn_drawMenu.Name = "btn_drawMenu";
            this.btn_drawMenu.Size = new System.Drawing.Size(81, 61);
            this.btn_drawMenu.TabIndex = 16;
            this.btn_drawMenu.UseVisualStyleBackColor = true;
            this.btn_drawMenu.Click += new System.EventHandler(this.btn_drawMenu_Click);
            this.btn_drawMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_drawMenu_MouseDown);
            this.btn_drawMenu.MouseEnter += new System.EventHandler(this.btn_drawMenu_MouseEnter);
            this.btn_drawMenu.MouseLeave += new System.EventHandler(this.btn_drawMenu_MouseLeave);
            this.btn_drawMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_drawMenu_MouseUp);
            // 
            // btn_diccionario
            // 
            this.btn_diccionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_diccionario.FlatAppearance.BorderSize = 0;
            this.btn_diccionario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_diccionario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_diccionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_diccionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diccionario.Image = global::AugmentedReadingApp.Properties.Resources.DiccionarioButtonImage;
            this.btn_diccionario.Location = new System.Drawing.Point(363, 581);
            this.btn_diccionario.Name = "btn_diccionario";
            this.btn_diccionario.Size = new System.Drawing.Size(81, 61);
            this.btn_diccionario.TabIndex = 123;
            this.btn_diccionario.UseVisualStyleBackColor = false;
            this.btn_diccionario.Visible = false;
            this.btn_diccionario.Click += new System.EventHandler(this.btn_diccionario_Click);
            this.btn_diccionario.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_diccionario_MouseDown);
            this.btn_diccionario.MouseEnter += new System.EventHandler(this.btn_diccionario_MouseEnter);
            this.btn_diccionario.MouseLeave += new System.EventHandler(this.btn_diccionario_MouseLeave);
            this.btn_diccionario.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_diccionario_MouseUp);
            // 
            // btn_imagen
            // 
            this.btn_imagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_imagen.FlatAppearance.BorderSize = 0;
            this.btn_imagen.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_imagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_imagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_imagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagen.Image = global::AugmentedReadingApp.Properties.Resources.ImagesButtonImage;
            this.btn_imagen.Location = new System.Drawing.Point(710, 581);
            this.btn_imagen.Name = "btn_imagen";
            this.btn_imagen.Size = new System.Drawing.Size(81, 61);
            this.btn_imagen.TabIndex = 122;
            this.btn_imagen.UseVisualStyleBackColor = false;
            this.btn_imagen.Visible = false;
            this.btn_imagen.Click += new System.EventHandler(this.btn_imagen_Click);
            this.btn_imagen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_imagen_MouseDown);
            this.btn_imagen.MouseEnter += new System.EventHandler(this.btn_imagen_MouseEnter);
            this.btn_imagen.MouseLeave += new System.EventHandler(this.btn_imagen_MouseLeave);
            this.btn_imagen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_imagen_MouseUp);
            // 
            // btn_video
            // 
            this.btn_video.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_video.FlatAppearance.BorderSize = 0;
            this.btn_video.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_video.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_video.Image = global::AugmentedReadingApp.Properties.Resources.VideoButtonImage;
            this.btn_video.Location = new System.Drawing.Point(624, 581);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(81, 61);
            this.btn_video.TabIndex = 121;
            this.btn_video.UseVisualStyleBackColor = false;
            this.btn_video.Visible = false;
            this.btn_video.Click += new System.EventHandler(this.btn_video_Click);
            this.btn_video.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_video_MouseDown);
            this.btn_video.MouseEnter += new System.EventHandler(this.btn_video_MouseEnter);
            this.btn_video.MouseLeave += new System.EventHandler(this.btn_video_MouseLeave);
            this.btn_video.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_video_MouseUp);
            // 
            // btn_enciclopedia
            // 
            this.btn_enciclopedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_enciclopedia.FlatAppearance.BorderSize = 0;
            this.btn_enciclopedia.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_enciclopedia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_enciclopedia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_enciclopedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enciclopedia.Image = global::AugmentedReadingApp.Properties.Resources.EncyclopediaButtonImage;
            this.btn_enciclopedia.Location = new System.Drawing.Point(450, 581);
            this.btn_enciclopedia.Name = "btn_enciclopedia";
            this.btn_enciclopedia.Size = new System.Drawing.Size(81, 61);
            this.btn_enciclopedia.TabIndex = 120;
            this.btn_enciclopedia.UseVisualStyleBackColor = false;
            this.btn_enciclopedia.Visible = false;
            this.btn_enciclopedia.Click += new System.EventHandler(this.btn_enciclopedia_Click);
            this.btn_enciclopedia.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_enciclopedia_MouseDown);
            this.btn_enciclopedia.MouseEnter += new System.EventHandler(this.btn_enciclopedia_MouseEnter);
            this.btn_enciclopedia.MouseLeave += new System.EventHandler(this.btn_enciclopedia_MouseLeave);
            this.btn_enciclopedia.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_enciclopedia_MouseUp);
            // 
            // btn_traductor
            // 
            this.btn_traductor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_traductor.FlatAppearance.BorderSize = 0;
            this.btn_traductor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_traductor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_traductor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_traductor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_traductor.Image = global::AugmentedReadingApp.Properties.Resources.TraductorButtonImage;
            this.btn_traductor.Location = new System.Drawing.Point(537, 581);
            this.btn_traductor.Name = "btn_traductor";
            this.btn_traductor.Size = new System.Drawing.Size(81, 61);
            this.btn_traductor.TabIndex = 119;
            this.btn_traductor.UseVisualStyleBackColor = false;
            this.btn_traductor.Visible = false;
            this.btn_traductor.Click += new System.EventHandler(this.btn_traductor_Click);
            this.btn_traductor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_traductor_MouseDown);
            this.btn_traductor.MouseEnter += new System.EventHandler(this.btn_traductor_MouseEnter);
            this.btn_traductor.MouseLeave += new System.EventHandler(this.btn_traductor_MouseLeave);
            this.btn_traductor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_traductor_MouseUp);
            // 
            // btn_buscarWeb
            // 
            this.btn_buscarWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_buscarWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarWeb.FlatAppearance.BorderSize = 0;
            this.btn_buscarWeb.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_buscarWeb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_buscarWeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_buscarWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarWeb.Image = global::AugmentedReadingApp.Properties.Resources.WebSearcherButtonOFFImage;
            this.btn_buscarWeb.Location = new System.Drawing.Point(466, 508);
            this.btn_buscarWeb.Name = "btn_buscarWeb";
            this.btn_buscarWeb.Size = new System.Drawing.Size(81, 65);
            this.btn_buscarWeb.TabIndex = 118;
            this.btn_buscarWeb.UseVisualStyleBackColor = false;
            this.btn_buscarWeb.Click += new System.EventHandler(this.btn_buscarWeb_Click);
            // 
            // btn_cerrarVentanaIzquierda
            // 
            this.btn_cerrarVentanaIzquierda.FlatAppearance.BorderSize = 0;
            this.btn_cerrarVentanaIzquierda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentanaIzquierda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_cerrarVentanaIzquierda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrarVentanaIzquierda.Image = global::AugmentedReadingApp.Properties.Resources.XButtonImage;
            this.btn_cerrarVentanaIzquierda.Location = new System.Drawing.Point(87, 374);
            this.btn_cerrarVentanaIzquierda.Name = "btn_cerrarVentanaIzquierda";
            this.btn_cerrarVentanaIzquierda.Size = new System.Drawing.Size(81, 61);
            this.btn_cerrarVentanaIzquierda.TabIndex = 4;
            this.btn_cerrarVentanaIzquierda.UseVisualStyleBackColor = true;
            this.btn_cerrarVentanaIzquierda.Visible = false;
            this.btn_cerrarVentanaIzquierda.Click += new System.EventHandler(this.btn_cerrarVentanaIzquierda_Click);
            this.btn_cerrarVentanaIzquierda.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cerrarVentanaIzquierda_MouseDown);
            this.btn_cerrarVentanaIzquierda.MouseEnter += new System.EventHandler(this.btn_cerrarVentanaIzquierda_MouseEnter);
            this.btn_cerrarVentanaIzquierda.MouseLeave += new System.EventHandler(this.btn_cerrarVentanaIzquierda_MouseLeave);
            this.btn_cerrarVentanaIzquierda.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cerrarVentanaIzquierda_MouseUp);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(297, 570);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 87;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(797, 570);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 60);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 88;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(298, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 86;
            this.pictureBox3.TabStop = false;
            // 
            // btn_leerDefinicionTraduccion
            // 
            this.btn_leerDefinicionTraduccion.FlatAppearance.BorderSize = 0;
            this.btn_leerDefinicionTraduccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_leerDefinicionTraduccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_leerDefinicionTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leerDefinicionTraduccion.Image = global::AugmentedReadingApp.Properties.Resources.ReadButtonImage;
            this.btn_leerDefinicionTraduccion.Location = new System.Drawing.Point(5, 374);
            this.btn_leerDefinicionTraduccion.Name = "btn_leerDefinicionTraduccion";
            this.btn_leerDefinicionTraduccion.Size = new System.Drawing.Size(81, 61);
            this.btn_leerDefinicionTraduccion.TabIndex = 130;
            this.btn_leerDefinicionTraduccion.UseVisualStyleBackColor = true;
            this.btn_leerDefinicionTraduccion.Visible = false;
            this.btn_leerDefinicionTraduccion.Click += new System.EventHandler(this.btn_leerDefinicionTraduccion_Click);
            this.btn_leerDefinicionTraduccion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_leerDefinicionTraduccion_MouseDown);
            this.btn_leerDefinicionTraduccion.MouseEnter += new System.EventHandler(this.btn_leerDefinicionTraduccion_MouseEnter);
            this.btn_leerDefinicionTraduccion.MouseLeave += new System.EventHandler(this.btn_leerDefinicionTraduccion_MouseLeave);
            this.btn_leerDefinicionTraduccion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_leerDefinicionTraduccion_MouseUp);
            // 
            // btn_sincronizadorPdf
            // 
            this.btn_sincronizadorPdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.btn_sincronizadorPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sincronizadorPdf.FlatAppearance.BorderSize = 0;
            this.btn_sincronizadorPdf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn_sincronizadorPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_sincronizadorPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_sincronizadorPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sincronizadorPdf.Image = global::AugmentedReadingApp.Properties.Resources.SynchonizerButtonOFFImage;
            this.btn_sincronizadorPdf.Location = new System.Drawing.Point(624, 508);
            this.btn_sincronizadorPdf.Name = "btn_sincronizadorPdf";
            this.btn_sincronizadorPdf.Size = new System.Drawing.Size(81, 65);
            this.btn_sincronizadorPdf.TabIndex = 140;
            this.btn_sincronizadorPdf.UseVisualStyleBackColor = false;
            this.btn_sincronizadorPdf.Click += new System.EventHandler(this.btn_sincronizadorPdf_Click);
            // 
            // ProjectionScreenActivity2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(245)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.btn_sincronizadorPdf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonComments);
            this.Controls.Add(this.buttonMarker);
            this.Controls.Add(this.buttonPDF);
            this.Controls.Add(this.buttonFiguresPD);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.btn_drawMenu);
            this.Controls.Add(this.btn_diccionario);
            this.Controls.Add(this.btn_imagen);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_enciclopedia);
            this.Controls.Add(this.btn_traductor);
            this.Controls.Add(this.btn_buscarWeb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textImageButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_datoBuscado_trad_def);
            this.Controls.Add(this.rtb_result_definicion_traduccion);
            this.Controls.Add(this.btn_cerrarVentanaIzquierda);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btn_leerDefinicionTraduccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectionScreenActivity2";
            this.Text = "AR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectionScreenActivity_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_navegador.ResumeLayout(false);
            this.panel_log.ResumeLayout(false);
            this.gb_busquedasRecientes.ResumeLayout(false);
            this.gb_busquedasRecientes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button markButton;
        private System.Windows.Forms.Button textImageButton;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.Panel panel2;
        private ModuloRastreoOcular.ButtonAlt btn_nav_adelante;
        private ModuloRastreoOcular.ButtonAlt btn_nav_atras;
        private ModuloRastreoOcular.ButtonAlt btn_cerrarVentanaDerecha;
        private System.Windows.Forms.Label lbl_PalabraBuscada;
        private System.Windows.Forms.Panel panel_navegador;
        private System.Windows.Forms.RichTextBox rtb_ResultadosWikipedia;
        private ModuloRastreoOcular.ButtonAlt btn_diccionario;
        private ModuloRastreoOcular.ButtonAlt btn_imagen;
        private ModuloRastreoOcular.ButtonAlt btn_video;
        private ModuloRastreoOcular.ButtonAlt btn_enciclopedia;
        private ModuloRastreoOcular.ButtonAlt btn_traductor;
        private ModuloRastreoOcular.ButtonAlt btn_buscarWeb;
        private ModuloRastreoOcular.ButtonAlt btn_drawMenu;
        private ModuloRastreoOcular.ButtonAlt btn_cerrarVentanaIzquierda;
        private System.Windows.Forms.Label lbl_datoBuscado_trad_def;
        private System.Windows.Forms.RichTextBox rtb_result_definicion_traduccion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_log;
        private System.Windows.Forms.GroupBox gb_busquedasRecientes;
        private System.Windows.Forms.FlowLayoutPanel fl_busquedasRecientes;
        private System.Windows.Forms.Label label1;
        private ModuloRastreoOcular.ButtonAlt btn_leerEnciclopedia;
        private ModuloRastreoOcular.ButtonAlt btn_leerDefinicionTraduccion;
        private System.Windows.Forms.Button nextPageButton;
        private System.Windows.Forms.Button backPagebutton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label Pages;
        private System.Windows.Forms.Label PagesLabel;
        private System.Windows.Forms.Button buttonFiguresPD;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonMarker;
        private System.Windows.Forms.Button buttonComments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonEliminarComentario;
        private System.Windows.Forms.Button buttonEliminarMarcador;
        private System.Windows.Forms.Label comentariosPDF;
        private System.Windows.Forms.Label labelMarcadoresPDF;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private ModuloRastreoOcular.ButtonAlt btn_sincronizadorPdf;
        private ModuloRastreoOcular.ButtonAlt btn_turnOFF;
    }
}
