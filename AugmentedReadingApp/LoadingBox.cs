using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AugmentedReadingApp
{
    public partial class LoadingBox : Form
    {
        public LoadingBox()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            
        }

        public LoadingBox(Form parent)
        {
            InitializeComponent();
            if (parent != null )
            {
                this.StartPosition = FormStartPosition.Manual;
                if (parent.Name == "MenuSettings")
                {
                    this.Location = new Point(parent.Location.X + 17, parent.Location.Y + 420);
                }
            }
            else
                this.StartPosition = FormStartPosition.CenterScreen;
        }

        public LoadingBox(Form parent, String tipoBusqueda)
        {
            InitializeComponent();
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.Manual;
                if (parent.Name == "ProjectionScreenActivity2" && tipoBusqueda == "izquierda")
                {
                    
                    this.Location = new Point(parent.Location.X + 12, parent.Location.Y + 67);
                }
                if (parent.Name == "ProjectionScreenActivity2" && tipoBusqueda == "derecha")
                {
                    this.Location = new Point(parent.Location.X + 880, parent.Location.Y + 67);
                }
            }
            else
                this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void CloseLoadingBox()
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            if (label1.Image != null)
            {
                label1.Image.Dispose();
            }

        }
    }
}
