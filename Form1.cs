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

namespace pryChaconSP1
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            StreamWriter swCrearArchivo = new StreamWriter("MiArchivo", false);

            if (swCrearArchivo != null)
            {
                MessageBox.Show("Archivo creado");
            };
        }
    }
}
