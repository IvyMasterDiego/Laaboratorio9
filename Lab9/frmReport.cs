using Laboratorio9_WinApp_.DataReportDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio9_WinApp_
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataReportDataSet.tblClientes' table. You can move, or remove it, as needed.
            //this.tblClientesTableAdapter.Fill(this.DataReportDataSet.tblClientes);

            //this.reportViewer1.RefreshReport();
        }

        private void btnAceptarrp_Click(object sender, EventArgs e)
        {
            this.DataReportDataSet.tblClientes.Clear();
            this.tblClientesTableAdapter.FillByIndentificacion(this.DataReportDataSet.tblClientes, txtIdentificacion.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from tblClientes", connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            ReportDataSource reportData = new ReportDataSource("DataSetRP", (DataTable)data.Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportData);
            reportViewer1.RefreshReport();
        }
    }
}
