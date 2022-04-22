
namespace Prestamos
{
    partial class FrmPago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPago));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnBuscarAvanzada = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.GbCuotas = new System.Windows.Forms.GroupBox();
            this.DgvCuotas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DgvPrestamos = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnBuscarPrestamo = new System.Windows.Forms.Button();
            this.cdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.CdFechaVencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdSaldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnPagar = new System.Windows.Forms.Button();
            this.CboFormaPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GbCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarAvanzada
            // 
            this.BtnBuscarAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAvanzada.Image")));
            this.BtnBuscarAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarAvanzada.Location = new System.Drawing.Point(404, 44);
            this.BtnBuscarAvanzada.Name = "BtnBuscarAvanzada";
            this.BtnBuscarAvanzada.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.BtnBuscarAvanzada.Size = new System.Drawing.Size(275, 23);
            this.BtnBuscarAvanzada.TabIndex = 4;
            this.BtnBuscarAvanzada.Text = "Búsqueda avanzada";
            this.BtnBuscarAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarAvanzada.UseVisualStyleBackColor = true;
            this.BtnBuscarAvanzada.Click += new System.EventHandler(this.BtnBuscarAvanzada_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(604, 13);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 3;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(85, 77);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(415, 20);
            this.TxtCliente.TabIndex = 5;
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(404, 15);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(194, 20);
            this.TxtNumeroDocumento.TabIndex = 2;
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(239, 15);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(148, 21);
            this.CboTipoDocumento.TabIndex = 1;
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.CboTipoCliente.Location = new System.Drawing.Point(85, 15);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(148, 21);
            this.CboTipoCliente.TabIndex = 0;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(8, 80);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 14;
            this.LblCliente.Text = "Cliente";
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.Location = new System.Drawing.Point(8, 18);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(62, 13);
            this.LblTipoCliente.TabIndex = 8;
            this.LblTipoCliente.Text = "Tipo cliente";
            // 
            // GbCuotas
            // 
            this.GbCuotas.Controls.Add(this.CboFormaPago);
            this.GbCuotas.Controls.Add(this.label1);
            this.GbCuotas.Controls.Add(this.BtnPagar);
            this.GbCuotas.Controls.Add(this.DgvCuotas);
            this.GbCuotas.Location = new System.Drawing.Point(428, 104);
            this.GbCuotas.Name = "GbCuotas";
            this.GbCuotas.Size = new System.Drawing.Size(470, 400);
            this.GbCuotas.TabIndex = 16;
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
            this.DgvCuotas.RowHeadersVisible = false;
            this.DgvCuotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCuotas.Size = new System.Drawing.Size(440, 321);
            this.DgvCuotas.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnSeleccionar);
            this.groupBox1.Controls.Add(this.DgvPrestamos);
            this.groupBox1.Location = new System.Drawing.Point(11, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 400);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listado de préstamos";
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
            this.DgvPrestamos.Size = new System.Drawing.Size(381, 321);
            this.DgvPrestamos.TabIndex = 0;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(293, 354);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSeleccionar.Size = new System.Drawing.Size(102, 40);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(797, 522);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(689, 522);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptar.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptar.TabIndex = 7;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscarPrestamo
            // 
            this.BtnBuscarPrestamo.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarPrestamo.Image")));
            this.BtnBuscarPrestamo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarPrestamo.Location = new System.Drawing.Point(506, 75);
            this.BtnBuscarPrestamo.Name = "BtnBuscarPrestamo";
            this.BtnBuscarPrestamo.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.BtnBuscarPrestamo.Size = new System.Drawing.Size(173, 23);
            this.BtnBuscarPrestamo.TabIndex = 6;
            this.BtnBuscarPrestamo.Text = "Buscar préstamo";
            this.BtnBuscarPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarPrestamo.UseVisualStyleBackColor = true;
            this.BtnBuscarPrestamo.Click += new System.EventHandler(this.BtnBuscarPrestamo_Click);
            this.BtnBuscarPrestamo.Validating += new System.ComponentModel.CancelEventHandler(this.BtnBuscarPrestamo_Validating);
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
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle1;
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
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
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
            // BtnPagar
            // 
            this.BtnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPagar.Image = ((System.Drawing.Image)(resources.GetObject("BtnPagar.Image")));
            this.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagar.Location = new System.Drawing.Point(352, 354);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Padding = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.BtnPagar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnPagar.Size = new System.Drawing.Size(102, 40);
            this.BtnPagar.TabIndex = 1;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagar.UseVisualStyleBackColor = true;
            this.BtnPagar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // CboFormaPago
            // 
            this.CboFormaPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboFormaPago.FormattingEnabled = true;
            this.CboFormaPago.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.CboFormaPago.Location = new System.Drawing.Point(103, 365);
            this.CboFormaPago.Name = "CboFormaPago";
            this.CboFormaPago.Size = new System.Drawing.Size(193, 21);
            this.CboFormaPago.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Forma de pago";
            // 
            // FrmPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(910, 573);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GbCuotas);
            this.Controls.Add(this.BtnBuscarPrestamo);
            this.Controls.Add(this.BtnBuscarAvanzada);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.CboTipoCliente);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblTipoCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.FrmPago_Load);
            this.GbCuotas.ResumeLayout(false);
            this.GbCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarAvanzada;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.GroupBox GbCuotas;
        private System.Windows.Forms.DataGridView DgvCuotas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvPrestamos;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button BtnBuscarPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMontoPagado;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFechaVencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdSaldo;
        private System.Windows.Forms.ComboBox CboFormaPago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnPagar;
    }
}