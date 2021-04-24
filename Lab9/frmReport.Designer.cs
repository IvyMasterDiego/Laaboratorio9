
namespace Laboratorio9_WinApp_
{
    partial class frmReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataReportDataSet = new Laboratorio9_WinApp_.DataReportDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptarrp = new System.Windows.Forms.Button();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.tblClientesTableAdapter = new Laboratorio9_WinApp_.DataReportDataSetTableAdapters.tblClientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblClientesBindingSource
            // 
            this.tblClientesBindingSource.DataMember = "tblClientes";
            this.tblClientesBindingSource.DataSource = this.DataReportDataSet;
            // 
            // DataReportDataSet
            // 
            this.DataReportDataSet.DataSetName = "DataReportDataSet";
            this.DataReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetRP";
            reportDataSource1.Value = this.tblClientesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Laboratorio9_WinApp_.rptClientes.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-2, 41);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1164, 522);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Indentificacion";
            // 
            // btnAceptarrp
            // 
            this.btnAceptarrp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarrp.Location = new System.Drawing.Point(268, 12);
            this.btnAceptarrp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptarrp.Name = "btnAceptarrp";
            this.btnAceptarrp.Size = new System.Drawing.Size(56, 19);
            this.btnAceptarrp.TabIndex = 2;
            this.btnAceptarrp.Text = "Aceptar";
            this.btnAceptarrp.UseVisualStyleBackColor = true;
            this.btnAceptarrp.Click += new System.EventHandler(this.btnAceptarrp_Click);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(87, 13);
            this.txtIdentificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(167, 20);
            this.txtIdentificacion.TabIndex = 3;
            // 
            // btnListar
            // 
            this.btnListar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListar.Location = new System.Drawing.Point(337, 12);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(85, 19);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Todos";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tblClientesTableAdapter
            // 
            this.tblClientesTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 573);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtIdentificacion);
            this.Controls.Add(this.btnAceptarrp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReportDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tblClientesBindingSource;
        private DataReportDataSet DataReportDataSet;
        private DataReportDataSetTableAdapters.tblClientesTableAdapter tblClientesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptarrp;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Button btnListar;
    }
}