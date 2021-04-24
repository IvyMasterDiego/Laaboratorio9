
namespace Laboratorio9_WinApp_
{
    partial class frmClient
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
            this.textTipoVehiculo = new System.Windows.Forms.TextBox();
            this.textSalidaoEntrada = new System.Windows.Forms.TextBox();
            this.textLocalidad = new System.Windows.Forms.TextBox();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.textTipoId = new System.Windows.Forms.TextBox();
            this.textIdentificacion = new System.Windows.Forms.TextBox();
            this.btnTipoVehiculo = new System.Windows.Forms.Label();
            this.btnSalidaoEntrada = new System.Windows.Forms.Label();
            this.btnLocalidad = new System.Windows.Forms.Label();
            this.btnMonto = new System.Windows.Forms.Label();
            this.btnTipoID = new System.Windows.Forms.Label();
            this.btnIdentificacion = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textTipoVehiculo
            // 
            this.textTipoVehiculo.Location = new System.Drawing.Point(104, 175);
            this.textTipoVehiculo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTipoVehiculo.Name = "textTipoVehiculo";
            this.textTipoVehiculo.Size = new System.Drawing.Size(155, 20);
            this.textTipoVehiculo.TabIndex = 27;
            // 
            // textSalidaoEntrada
            // 
            this.textSalidaoEntrada.Location = new System.Drawing.Point(104, 145);
            this.textSalidaoEntrada.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textSalidaoEntrada.Name = "textSalidaoEntrada";
            this.textSalidaoEntrada.Size = new System.Drawing.Size(155, 20);
            this.textSalidaoEntrada.TabIndex = 26;
            // 
            // textLocalidad
            // 
            this.textLocalidad.Location = new System.Drawing.Point(104, 108);
            this.textLocalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textLocalidad.Name = "textLocalidad";
            this.textLocalidad.ReadOnly = true;
            this.textLocalidad.Size = new System.Drawing.Size(155, 20);
            this.textLocalidad.TabIndex = 25;
            this.textLocalidad.Text = "Jarabacoa";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(104, 81);
            this.textMonto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(155, 20);
            this.textMonto.TabIndex = 24;
            // 
            // textTipoId
            // 
            this.textTipoId.Location = new System.Drawing.Point(104, 51);
            this.textTipoId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textTipoId.Name = "textTipoId";
            this.textTipoId.Size = new System.Drawing.Size(155, 20);
            this.textTipoId.TabIndex = 23;
            // 
            // textIdentificacion
            // 
            this.textIdentificacion.Location = new System.Drawing.Point(104, 21);
            this.textIdentificacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textIdentificacion.Name = "textIdentificacion";
            this.textIdentificacion.Size = new System.Drawing.Size(155, 20);
            this.textIdentificacion.TabIndex = 22;
            // 
            // btnTipoVehiculo
            // 
            this.btnTipoVehiculo.AutoSize = true;
            this.btnTipoVehiculo.Location = new System.Drawing.Point(17, 175);
            this.btnTipoVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTipoVehiculo.Name = "btnTipoVehiculo";
            this.btnTipoVehiculo.Size = new System.Drawing.Size(69, 13);
            this.btnTipoVehiculo.TabIndex = 21;
            this.btnTipoVehiculo.Text = "TipoVehiculo";
            // 
            // btnSalidaoEntrada
            // 
            this.btnSalidaoEntrada.AutoSize = true;
            this.btnSalidaoEntrada.Location = new System.Drawing.Point(17, 145);
            this.btnSalidaoEntrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSalidaoEntrada.Name = "btnSalidaoEntrada";
            this.btnSalidaoEntrada.Size = new System.Drawing.Size(78, 13);
            this.btnSalidaoEntrada.TabIndex = 20;
            this.btnSalidaoEntrada.Text = "Salida/Entrada";
            // 
            // btnLocalidad
            // 
            this.btnLocalidad.AutoSize = true;
            this.btnLocalidad.Location = new System.Drawing.Point(17, 111);
            this.btnLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnLocalidad.Name = "btnLocalidad";
            this.btnLocalidad.Size = new System.Drawing.Size(53, 13);
            this.btnLocalidad.TabIndex = 19;
            this.btnLocalidad.Text = "Localidad";
            // 
            // btnMonto
            // 
            this.btnMonto.AutoSize = true;
            this.btnMonto.Location = new System.Drawing.Point(17, 81);
            this.btnMonto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnMonto.Name = "btnMonto";
            this.btnMonto.Size = new System.Drawing.Size(37, 13);
            this.btnMonto.TabIndex = 18;
            this.btnMonto.Text = "Monto";
            // 
            // btnTipoID
            // 
            this.btnTipoID.AutoSize = true;
            this.btnTipoID.Location = new System.Drawing.Point(17, 51);
            this.btnTipoID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTipoID.Name = "btnTipoID";
            this.btnTipoID.Size = new System.Drawing.Size(37, 13);
            this.btnTipoID.TabIndex = 17;
            this.btnTipoID.Text = "TipoId";
            // 
            // btnIdentificacion
            // 
            this.btnIdentificacion.AutoSize = true;
            this.btnIdentificacion.Location = new System.Drawing.Point(17, 21);
            this.btnIdentificacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnIdentificacion.Name = "btnIdentificacion";
            this.btnIdentificacion.Size = new System.Drawing.Size(76, 13);
            this.btnIdentificacion.TabIndex = 16;
            this.btnIdentificacion.Text = "Indentificacion";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(176, 212);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(82, 30);
            this.btnGuardar.TabIndex = 28;
            this.btnGuardar.Text = "Aceptar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.textTipoVehiculo);
            this.Controls.Add(this.textSalidaoEntrada);
            this.Controls.Add(this.textLocalidad);
            this.Controls.Add(this.textMonto);
            this.Controls.Add(this.textTipoId);
            this.Controls.Add(this.textIdentificacion);
            this.Controls.Add(this.btnTipoVehiculo);
            this.Controls.Add(this.btnSalidaoEntrada);
            this.Controls.Add(this.btnLocalidad);
            this.Controls.Add(this.btnMonto);
            this.Controls.Add(this.btnTipoID);
            this.Controls.Add(this.btnIdentificacion);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textTipoVehiculo;
        private System.Windows.Forms.TextBox textSalidaoEntrada;
        private System.Windows.Forms.TextBox textLocalidad;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.TextBox textTipoId;
        private System.Windows.Forms.TextBox textIdentificacion;
        private System.Windows.Forms.Label btnTipoVehiculo;
        private System.Windows.Forms.Label btnSalidaoEntrada;
        private System.Windows.Forms.Label btnLocalidad;
        private System.Windows.Forms.Label btnMonto;
        private System.Windows.Forms.Label btnTipoID;
        private System.Windows.Forms.Label btnIdentificacion;
        private System.Windows.Forms.Button btnGuardar;
    }
}