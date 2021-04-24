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
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (textIdentificacion.Text == "" || textTipoId.Text == "" || textMonto.Text == "" || textLocalidad.Text == "" || textSalidaoEntrada.Text == "" || textTipoVehiculo.Text == "")
            {
                MessageBox.Show(this, "Ingrese en todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tblClientesTableAdapter adapter = new tblClientesTableAdapter();
                adapter.Connection.Open();
                adapter.ppInsertClientes(textIdentificacion.Text, textTipoId.Text, textMonto.Text, textLocalidad.Text, textSalidaoEntrada.Text, textTipoVehiculo.Text);
            }
        }
    }
}
