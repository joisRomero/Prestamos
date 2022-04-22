
namespace Prestamos
{
    partial class FrmEstadoPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstadoPrestamo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBuscarPrestamo = new System.Windows.Forms.Button();
            this.BtnBuscarAvanzada = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.DgvPrestamos = new System.Windows.Forms.DataGridView();
            this.cdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.GbCuotas = new System.Windows.Forms.GroupBox();
            this.DgvCuotas = new System.Windows.Forms.DataGridView();
            this.CdFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblCliente = new System.Windows.Forms.Label();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.GbCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarPrestamo
            // 
            this.BtnBuscarPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarPrestamo.Image")));
            this.BtnBuscarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarPrestamo.Location = new System.Drawing.Point(508, 78);
            this.BtnBuscarPrestamo.Name = "BtnBuscarPrestamo";
            this.BtnBuscarPrestamo.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.BtnBuscarPrestamo.Size = new System.Drawing.Size(173, 23);
            this.BtnBuscarPrestamo.TabIndex = 24;
            this.BtnBuscarPrestamo.Text = "Buscar préstamo";
            this.BtnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.BtnBuscarPrestamo.Click += new System.EventHandler(this.BtnBuscarPrestamo_Click);
            this.BtnBuscarPrestamo.Validating += new System.ComponentModel.CancelEventHandler(this.BtnBuscarPrestamo_Validating);
            // 
            // BtnBuscarAvanzada
            // 
            this.BtnBuscarAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAvanzada.Image")));
            this.BtnBuscarAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarAvanzada.Location = new System.Drawing.Point(406, 47);
            this.BtnBuscarAvanzada.Name = "BtnBuscarAvanzada";
            this.BtnBuscarAvanzada.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.BtnBuscarAvanzada.Size = new System.Drawing.Size(275, 23);
            this.BtnBuscarAvanzada.TabIndex = 22;
            this.BtnBuscarAvanzada.Text = "Búsqueda avanzada";
            this.BtnBuscarAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarAvanzada.UseVisualStyleBackColor = true;
            this.BtnBuscarAvanzada.Click += new System.EventHandler(this.BtnBuscarAvanzada_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(606, 16);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 21;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(87, 80);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(415, 20);
            this.TxtCliente.TabIndex = 23;
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(406, 18);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(194, 20);
            this.TxtNumeroDocumento.TabIndex = 20;
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(241, 18);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(148, 21);
            this.CboTipoDocumento.TabIndex = 19;
            this.CboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CboTipoDocumento_SelectedIndexChanged);
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.CboTipoCliente.Location = new System.Drawing.Point(87, 18);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(148, 21);
            this.CboTipoCliente.TabIndex = 18;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.Location = new System.Drawing.Point(10, 21);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(62, 13);
            this.LblTipoCliente.TabIndex = 25;
            this.LblTipoCliente.Text = "Tipo cliente";
            // 
            // DgvPrestamos
            // 
            this.DgvPrestamos.AllowUserToAddRows = false;
            this.DgvPrestamos.AllowUserToDeleteRows = false;
            this.DgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPrestamos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdCodigo,
            this.cdMonto,
            this.CdFecha,
            this.cdMontoPagado});
            this.DgvPrestamos.Location = new System.Drawing.Point(14, 27);
            this.DgvPrestamos.Name = "DgvPrestamos";
            this.DgvPrestamos.ReadOnly = true;
            this.DgvPrestamos.RowHeadersVisible = false;
            this.DgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrestamos.Size = new System.Drawing.Size(391, 304);
            this.DgvPrestamos.TabIndex = 0;
            // 
            // cdCodigo
            // 
            this.cdCodigo.DataPropertyName = "Codigo";
            this.cdCodigo.FillWeight = 60.9137F;
            this.cdCodigo.HeaderText = "Cdg.";
            this.cdCodigo.Name = "cdCodigo";
            this.cdCodigo.ReadOnly = true;
            // 
            // cdMonto
            // 
            this.cdMonto.DataPropertyName = "Monto";
            this.cdMonto.FillWeight = 113.0288F;
            this.cdMonto.HeaderText = "Monto";
            this.cdMonto.Name = "cdMonto";
            this.cdMonto.ReadOnly = true;
            // 
            // CdFecha
            // 
            this.CdFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle5;
            this.CdFecha.FillWeight = 113.0288F;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // cdMontoPagado
            // 
            this.cdMontoPagado.DataPropertyName = "MontoPagado";
            this.cdMontoPagado.FillWeight = 113.0288F;
            this.cdMontoPagado.HeaderText = "Monto pagado";
            this.cdMontoPagado.Name = "cdMontoPagado";
            this.cdMontoPagado.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSeleccionar);
            this.groupBox1.Controls.Add(this.DgvPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 383);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de préstamos";
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(303, 337);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSeleccionar.Size = new System.Drawing.Size(102, 40);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // GbCuotas
            // 
            this.GbCuotas.Controls.Add(this.DgvCuotas);
            this.GbCuotas.Location = new System.Drawing.Point(430, 107);
            this.GbCuotas.Name = "GbCuotas";
            this.GbCuotas.Size = new System.Drawing.Size(470, 383);
            this.GbCuotas.TabIndex = 26;
            this.GbCuotas.TabStop = false;
            this.GbCuotas.Text = "Listado de cuotas";
            // 
            // DgvCuotas
            // 
            this.DgvCuotas.AllowUserToAddRows = false;
            this.DgvCuotas.AllowUserToDeleteRows = false;
            this.DgvCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvCuotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCuotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCuotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdFechaVencimiento,
            this.CdSaldo});
            this.DgvCuotas.Location = new System.Drawing.Point(14, 27);
            this.DgvCuotas.Name = "DgvCuotas";
            this.DgvCuotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DgvCuotas.RowHeadersVisible = false;
            this.DgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCuotas.Size = new System.Drawing.Size(440, 350);
            this.DgvCuotas.TabIndex = 0;
            // 
            // CdFechaVencimiento
            // 
            this.CdFechaVencimiento.DataPropertyName = "FechaVencimiento";
            this.CdFechaVencimiento.HeaderText = "Fecha vencimiento";
            this.CdFechaVencimiento.Name = "CdFechaVencimiento";
            this.CdFechaVencimiento.ReadOnly = true;
            // 
            // CdSaldo
            // 
            this.CdSaldo.DataPropertyName = "Monto";
            this.CdSaldo.HeaderText = "Saldo";
            this.CdSaldo.Name = "CdSaldo";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(12, 83);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 28;
            this.LblCliente.Text = "Cliente";
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarExcel.Image")));
            this.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportarExcel.Location = new System.Drawing.Point(674, 496);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(102, 40);
            this.BtnExportarExcel.TabIndex = 29;
            this.BtnExportarExcel.Text = "Exportar";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(782, 496);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrrar.TabIndex = 30;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // Notificacion
            // 
            this.Notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion.Icon")));
            this.Notificacion.Text = "notifyIcon1";
            this.Notificacion.Visible = true;
            this.Notificacion.BalloonTipClicked += new System.EventHandler(this.Notificacion_BalloonTipClicked);
            this.Notificacion.BalloonTipClosed += new System.EventHandler(this.Notificacion_BalloonTipClosed);
            // 
            // FrmEstadoPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 543);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.BtnBuscarPrestamo);
            this.Controls.Add(this.BtnBuscarAvanzada);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.CboTipoCliente);
            this.Controls.Add(this.LblTipoCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbCuotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstadoPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado préstamo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstadoPrestamo_FormClosing);
            this.Load += new System.EventHandler(this.FrmEstadoPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.GbCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarPrestamo;
        private System.Windows.Forms.Button BtnBuscarAvanzada;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.DataGridView DgvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMontoPagado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.GroupBox GbCuotas;
        private System.Windows.Forms.DataGridView DgvCuotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdSaldo;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
    }
}