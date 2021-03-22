using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Drawing.Text;
//Se agrega
using Emgu.CV;

namespace AugmentedReadingApp
{
    public partial class MenuSettings : Form
    {
        //Se Instancias los formularios con cada configuracion de cada módulo
        InteractionsSettings InteractionsForm = new InteractionsSettings();
        WebSearchServicesSettings WebSearchServicesForm = new WebSearchServicesSettings();
        SeleccionInteraccionPorVoz2 seleccionInteraccionPorVoz = new SeleccionInteraccionPorVoz2();
        SeleccionApis seleccionApis = new SeleccionApis();
        EyeTrackingConfiguration eyeTrackingConfig = new EyeTrackingConfiguration();
        TextRecognitionSettings textRecognitionSettings = new TextRecognitionSettings();
        GestureRecognitionSettings gestureRecognitionSettings = new GestureRecognitionSettings();
        //InteractionCoordinator interactionCoordinator = new InteractionCoordinator();
        //SeleccionApis seleccionapis1 = new SeleccionApis();
        ProjectionScreen projectionScreenForm = new ProjectionScreen();
        public PageDetectionSettings pageDetectionSettings;
        public ProjectionScreenActivity2 projectionScreenActivity2;
        int posY = 0;//Variables para mover el formulario con el mouse presionan el panel superior
        int posX = 0;
        public MenuSettings()
        {
            InitializeComponent();
            pageDetectionSettings = new PageDetectionSettings();
            projectionScreenActivity2 = new ProjectionScreenActivity2(pageDetectionSettings, textRecognitionSettings, gestureRecognitionSettings);
            
            //projectionScreenActivity2 = new ProjectionScreenActivity2();
            //seleccionInteraccionPorVoz.btn_guardar.Visible = false;
            seleccionApis.btn_guardarConfiguraciones.Visible = false;
            //ProjectionScreenForm.Show();
        }
        


        private void MenuSettings_Load(object sender, EventArgs e)
        {
            /*
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(".../Fonts/IBMPlexSans-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Bold);
            }*/
            //LoadingPictureBox.Visible = false;//Gif de carga parte invisible PUEDE SER OPTIMIZADO
        }
        private void ContenidoNavBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics gOject = ContenidoNavBar.CreateGraphics();//Código para dibujar la linea bajo del label Settings
            Brush separador = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(separador, 1);
            gOject.DrawLine(blackPen, 0, 47, 213, 47);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExitIconPictureBox(object sender, EventArgs e)
        {

        }

        private void ExitIconPictureBox_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar?", "Mensaje de Alerta", MessageBoxButtons.YesNo) == DialogResult.Yes)//Mensaje de alerta tras presionar la X para cerrar
            {
                //Acá debe venir el código que mantiene guardado los ajustes antes de cerrar
                Application.Exit();
            }

        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Evento para mover la ventana al mantener el click derecho en el panel superior
        private void PanelBarraSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;

            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        //Método para abrir un form en el PanelContenido
        private void AbrirFormEnPanel(Form formHijo)//OPTIMIZAR ESTO
        {
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.PanelContenido.Controls.Add(formHijo);
            this.PanelContenido.Tag = formHijo;
            formHijo.Show();
            formHijo.BringToFront();
        }
        //A Continuación los eventos click de los botones del navBar vertical
        private void InteractionsButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            InteractionsButton.Font = new Font(InteractionsButton.Font, FontStyle.Bold);
            //AbrirFormEnPanel(InteractionsForm);
            AbrirFormEnPanel(seleccionInteraccionPorVoz);
            /*
            //Método para abrir el form InteractionsSettings
            InteractionsSettings fm = new InteractionsSettings();
            //fm.FormClosed += new FormClosedEventHandler();
            //AbrirFormEnPanel(fm);
            */
        }

        private void WebSearchServicesButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            WebSearchServicesButton.Font = new Font(WebSearchServicesButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(seleccionApis);

            /*
            //Método para abrir el form WebSearchServicesSettings
            WebSearchServicesSettings fm = new WebSearchServicesSettings();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
            */
        }

        private void EyeTrackingButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            EyeTrackingButton.Font = new Font(EyeTrackingButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(eyeTrackingConfig);  
        }
        private void TextRecognitiionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            TextRecognitiionButton.Font = new Font(TextRecognitiionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(textRecognitionSettings);
        }
        private void GestureRecognitionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            GestureRecognitionButton.Font = new Font(GestureRecognitionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(gestureRecognitionSettings);
        }
        private void PageDetectionButton_Click(object sender, EventArgs e)
        {
            changeAllToLightFont();
            PageDetectionButton.Font = new Font(PageDetectionButton.Font, FontStyle.Bold);
            AbrirFormEnPanel(pageDetectionSettings);
        }
        //Evento para desplegar la interfaz de realidad aumentada
        private async void StartProjectionButton_Click(object sender, EventArgs e)
        {
            mostrarLoading();
            Task task = new Task(dummySleep);//Se simula un estado de cargando
            task.Start();
            await task;
            projectionScreenActivity2.Show();
            //ProjectionScreenForm.Show();
            ocultarLoading();
            
        }
        private void dummySleep()//Función para simular carga
        {
            Thread.Sleep(1000);
        }
        private void mostrarLoading()
        {
            LoadingPictureBox.Visible = true;
        }
        private void ocultarLoading()
        {
            LoadingPictureBox.Visible = false;
        }
        private void changeAllToLightFont()//Función para quitar el Bold a todos los botones del navbar
        {
            InteractionsButton.Font = new Font(InteractionsButton.Font, FontStyle.Regular);
            WebSearchServicesButton.Font = new Font(WebSearchServicesButton.Font, FontStyle.Regular);
            EyeTrackingButton.Font = new Font(EyeTrackingButton.Font, FontStyle.Regular);
            TextRecognitiionButton.Font = new Font(TextRecognitiionButton.Font, FontStyle.Regular);
            GestureRecognitionButton.Font = new Font(GestureRecognitionButton.Font, FontStyle.Regular);
            PageDetectionButton.Font = new Font(PageDetectionButton.Font, FontStyle.Regular);
        }

        private async void StartProjectionButtonModified_Click(object sender, EventArgs e)//Evento que muestra la interfaz de RA
        {
            mostrarLoading();
            Task task = new Task(dummySleep);
            task.Start();
            await task;
            //ProjectionScreenForm.Show();
            ocultarLoading();
        }

        private async void StartProjectionButtonModified_Click_1(object sender, EventArgs e)
        {
            //mostrarLoading();
            //Task task = new Task(dummySleep);
            //task.Start();
            //await task;
            //ProjectionScreenForm.Show();
            projectionScreenActivity2.Show();
            //Configuraciones de Text Recognition Settings
            var CameraNumber = textRecognitionSettings._CameraTextIndex;
            if (textRecognitionSettings.captureText == null)
            {
                textRecognitionSettings.captureText = new VideoCapture(CameraNumber);
                textRecognitionSettings.captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, (double)textRecognitionSettings.numericUpDownResXText.Value);
                textRecognitionSettings.captureText.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, (double)textRecognitionSettings.numericUpDownResYText.Value);

                textRecognitionSettings.imageBox1.Image = textRecognitionSettings.recTxt.Recognition(textRecognitionSettings.captureText);
            }
            //ocultarLoading();
        }

        private void SaveSettingsButtonModified_Click(object sender, EventArgs e)
        {
            //Codigo de guardado de SeleccionInteraccionPorVoz
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_Si_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_Si_botones.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_si.Checked && seleccionInteraccionPorVoz.rbtn_no_botones.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_si.Text;
                SeleccionInteraccionPorVoz2.mostrarBotonesconVoz = seleccionInteraccionPorVoz.rbtn_no_botones.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por voz");
                //this.Hide();
            }
            if (seleccionInteraccionPorVoz.rbtn_voz_no.Checked)
            {
                SeleccionInteraccionPorVoz2.activarBusquedaVoz = seleccionInteraccionPorVoz.rbtn_voz_no.Text;
                MessageBox.Show("Ha seleccionado la opción de interacción por botones");
                //this.Hide();
            }
            //Codigo de boton de guardado de SeleccionApis
            SeleccionApis.apiSeleccionadaEnciclopedia = seleccionApis.cbx_apisEnciclopedia.GetItemText(seleccionApis.cbx_apisEnciclopedia.SelectedItem);
            SeleccionApis.apiSeleccionadaDefinicion = seleccionApis.cbx_apisDefiniciones.GetItemText(seleccionApis.cbx_apisDefiniciones.SelectedItem);
            SeleccionApis.apiSeleccionadaTraduccion = seleccionApis.cbx_apisTraducciones.GetItemText(seleccionApis.cbx_apisTraducciones.SelectedItem);
            SeleccionApis.apiSeleccionadaVideo = seleccionApis.cbx_apisVideos.GetItemText(seleccionApis.cbx_apisVideos.SelectedItem);
            SeleccionApis.apiSeleccionadaImagen = seleccionApis.cbx_apisImagenes.GetItemText(seleccionApis.cbx_apisImagenes.SelectedItem);
            SeleccionApis.idiomaSeleccionadoTraduccion = seleccionApis.cbx_idiomaTraducir.GetItemText(seleccionApis.cbx_idiomaTraducir.SelectedValue);
            MessageBox.Show("Apis seleccionadas con éxito");
            //this.WindowState = FormWindowState.Minimized;
        }
    }
}
