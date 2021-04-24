using Laboratorio9_WinApp_.DataReportDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio9_WinApp_
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReport reportes = new frmReport();
            reportes.MdiParent = this;
            reportes.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void textIdentificacion_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient clientes = new frmClient();
            clientes.MdiParent = this;
            clientes.Show();
        }
    }
}
