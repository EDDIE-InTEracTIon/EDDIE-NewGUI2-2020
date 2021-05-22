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
            if (parent != null)
            {
                this.StartPosition = FormStartPosition.CenterScreen;

            }
            else
                this.StartPosition = FormStartPosition.CenterParent;
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
