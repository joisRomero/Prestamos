
namespace Prestamos
{
    partial class FrmPrestamo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.LblTipoCliente = new System.Windows.Forms.Label();
            this.CboTipoCliente = new System.Windows.Forms.ComboBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.LblFecha = new System.Windows.Forms.Label();
            this.LblInteres = new System.Windows.Forms.Label();
            this.LblMontoPrestar = new System.Windows.Forms.Label();
            this.NudInteres = new System.Windows.Forms.NumericUpDown();
            this.NudMontoPrestar = new System.Windows.Forms.NumericUpDown();
            this.ChkDejaGarantia = new System.Windows.Forms.CheckBox();
            this.GbCuotas = new System.Windows.Forms.GroupBox();
            this.DgvCuotas = new System.Windows.Forms.DataGridView();
            this.cdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnGenerar = new System.Windows.Forms.Button();
            this.LblPeriodo = new System.Windows.Forms.Label();
            this.CboTipoPeriodo = new System.Windows.Forms.ComboBox();
            this.NudCantidadPeriodos = new System.Windows.Forms.NumericUpDown();
            this.LblCantidadPeriodo = new System.Windows.Forms.Label();
            this.TxtTotalPagar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.BtnBuscarAvanzada = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoPrestar)).BeginInit();
            this.GbCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidadPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTipoCliente
            // 
            this.LblTipoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTipoCliente.AutoSize = true;
            this.LblTipoCliente.Location = new System.Drawing.Point(12, 19);
            this.LblTipoCliente.Name = "LblTipoCliente";
            this.LblTipoCliente.Size = new System.Drawing.Size(62, 13);
            this.LblTipoCliente.TabIndex = 0;
            this.LblTipoCliente.Text = "Tipo cliente";
            // 
            // CboTipoCliente
            // 
            this.CboTipoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoCliente.FormattingEnabled = true;
            this.CboTipoCliente.Items.AddRange(new object[] {
            "Persona",
            "Empresa"});
            this.CboTipoCliente.Location = new System.Drawing.Point(89, 16);
            this.CboTipoCliente.Name = "CboTipoCliente";
            this.CboTipoCliente.Size = new System.Drawing.Size(148, 21);
            this.CboTipoCliente.TabIndex = 1;
            this.CboTipoCliente.SelectedIndexChanged += new System.EventHandler(this.CboTipoCliente_SelectedIndexChanged);
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(243, 16);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(148, 21);
            this.CboTipoDocumento.TabIndex = 2;
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(408, 16);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(194, 20);
            this.TxtNumeroDocumento.TabIndex = 3;
            this.TxtNumeroDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumeroDocumento_Validating);
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(89, 78);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.ReadOnly = true;
            this.TxtCliente.Size = new System.Drawing.Size(594, 20);
            this.TxtCliente.TabIndex = 7;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(12, 81);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 6;
            this.LblCliente.Text = "Cliente";
            // 
            // DtpFecha
            // 
            this.DtpFecha.Location = new System.Drawing.Point(89, 109);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(200, 20);
            this.DtpFecha.TabIndex = 9;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Location = new System.Drawing.Point(12, 112);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(37, 13);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "Fecha";
            // 
            // LblInteres
            // 
            this.LblInteres.AutoSize = true;
            this.LblInteres.Location = new System.Drawing.Point(12, 144);
            this.LblInteres.Name = "LblInteres";
            this.LblInteres.Size = new System.Drawing.Size(39, 13);
            this.LblInteres.TabIndex = 10;
            this.LblInteres.Text = "Interés";
            // 
            // LblMontoPrestar
            // 
            this.LblMontoPrestar.AutoSize = true;
            this.LblMontoPrestar.Location = new System.Drawing.Point(12, 176);
            this.LblMontoPrestar.Name = "LblMontoPrestar";
            this.LblMontoPrestar.Size = new System.Drawing.Size(72, 13);
            this.LblMontoPrestar.TabIndex = 12;
            this.LblMontoPrestar.Text = "Monto prestar";
            // 
            // NudInteres
            // 
            this.NudInteres.DecimalPlaces = 2;
            this.NudInteres.Location = new System.Drawing.Point(89, 142);
            this.NudInteres.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NudInteres.Name = "NudInteres";
            this.NudInteres.Size = new System.Drawing.Size(148, 20);
            this.NudInteres.TabIndex = 10;
            this.NudInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudInteres.Validating += new System.ComponentModel.CancelEventHandler(this.NudInteres_Validating);
            // 
            // NudMontoPrestar
            // 
            this.NudMontoPrestar.DecimalPlaces = 2;
            this.NudMontoPrestar.Location = new System.Drawing.Point(89, 174);
            this.NudMontoPrestar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NudMontoPrestar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMontoPrestar.Name = "NudMontoPrestar";
            this.NudMontoPrestar.Size = new System.Drawing.Size(148, 20);
            this.NudMontoPrestar.TabIndex = 13;
            this.NudMontoPrestar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NudMontoPrestar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ChkDejaGarantia
            // 
            this.ChkDejaGarantia.AutoSize = true;
            this.ChkDejaGarantia.Location = new System.Drawing.Point(288, 176);
            this.ChkDejaGarantia.Name = "ChkDejaGarantia";
            this.ChkDejaGarantia.Size = new System.Drawing.Size(91, 17);
            this.ChkDejaGarantia.TabIndex = 14;
            this.ChkDejaGarantia.Text = "Deja garantía";
            this.ChkDejaGarantia.UseVisualStyleBackColor = true;
            // 
            // GbCuotas
            // 
            this.GbCuotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbCuotas.Controls.Add(this.DgvCuotas);
            this.GbCuotas.Controls.Add(this.BtnGenerar);
            this.GbCuotas.Controls.Add(this.LblPeriodo);
            this.GbCuotas.Controls.Add(this.CboTipoPeriodo);
            this.GbCuotas.Controls.Add(this.NudCantidadPeriodos);
            this.GbCuotas.Controls.Add(this.LblCantidadPeriodo);
            this.GbCuotas.Location = new System.Drawing.Point(12, 211);
            this.GbCuotas.Name = "GbCuotas";
            this.GbCuotas.Size = new System.Drawing.Size(671, 276);
            this.GbCuotas.TabIndex = 15;
            this.GbCuotas.TabStop = false;
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
            this.cdNumero,
            this.CdFecha,
            this.CdMonto});
            this.DgvCuotas.Location = new System.Drawing.Point(14, 63);
            this.DgvCuotas.Name = "DgvCuotas";
            this.DgvCuotas.RowHeadersVisible = false;
            this.DgvCuotas.Size = new System.Drawing.Size(641, 196);
            this.DgvCuotas.TabIndex = 5;
            this.DgvCuotas.Validating += new System.ComponentModel.CancelEventHandler(this.DgvCuotas_Validating);
            // 
            // cdNumero
            // 
            this.cdNumero.DataPropertyName = "Numero";
            this.cdNumero.FillWeight = 20F;
            this.cdNumero.HeaderText = "N°";
            this.cdNumero.Name = "cdNumero";
            this.cdNumero.ReadOnly = true;
            // 
            // CdFecha
            // 
            this.CdFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle3;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // CdMonto
            // 
            this.CdMonto.DataPropertyName = "Monto";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.CdMonto.DefaultCellStyle = dataGridViewCellStyle4;
            this.CdMonto.HeaderText = "Monto";
            this.CdMonto.Name = "CdMonto";
            // 
            // BtnGenerar
            // 
            this.BtnGenerar.Image = ((System.Drawing.Image)(resources.GetObject("BtnGenerar.Image")));
            this.BtnGenerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGenerar.Location = new System.Drawing.Point(559, 18);
            this.BtnGenerar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGenerar.Name = "BtnGenerar";
            this.BtnGenerar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnGenerar.Size = new System.Drawing.Size(102, 40);
            this.BtnGenerar.TabIndex = 4;
            this.BtnGenerar.Text = "Generar";
            this.BtnGenerar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnGenerar.UseVisualStyleBackColor = true;
            this.BtnGenerar.Click += new System.EventHandler(this.BtnGenerar_Click);
            // 
            // LblPeriodo
            // 
            this.LblPeriodo.AutoSize = true;
            this.LblPeriodo.Location = new System.Drawing.Point(11, 32);
            this.LblPeriodo.Name = "LblPeriodo";
            this.LblPeriodo.Size = new System.Drawing.Size(43, 13);
            this.LblPeriodo.TabIndex = 0;
            this.LblPeriodo.Text = "Periodo";
            // 
            // CboTipoPeriodo
            // 
            this.CboTipoPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoPeriodo.FormattingEnabled = true;
            this.CboTipoPeriodo.Items.AddRange(new object[] {
            "Diario",
            "Semanal ",
            "Quincenal ",
            "Mensual"});
            this.CboTipoPeriodo.Location = new System.Drawing.Point(77, 29);
            this.CboTipoPeriodo.Name = "CboTipoPeriodo";
            this.CboTipoPeriodo.Size = new System.Drawing.Size(174, 21);
            this.CboTipoPeriodo.TabIndex = 1;
            this.CboTipoPeriodo.Validating += new System.ComponentModel.CancelEventHandler(this.CboTipoPeriodo_Validating);
            // 
            // NudCantidadPeriodos
            // 
            this.NudCantidadPeriodos.Location = new System.Drawing.Point(396, 30);
            this.NudCantidadPeriodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudCantidadPeriodos.Name = "NudCantidadPeriodos";
            this.NudCantidadPeriodos.Size = new System.Drawing.Size(117, 20);
            this.NudCantidadPeriodos.TabIndex = 3;
            this.NudCantidadPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LblCantidadPeriodo
            // 
            this.LblCantidadPeriodo.AutoSize = true;
            this.LblCantidadPeriodo.Location = new System.Drawing.Point(275, 32);
            this.LblCantidadPeriodo.Name = "LblCantidadPeriodo";
            this.LblCantidadPeriodo.Size = new System.Drawing.Size(92, 13);
            this.LblCantidadPeriodo.TabIndex = 2;
            this.LblCantidadPeriodo.Text = "Cantidad periodos";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Location = new System.Drawing.Point(547, 173);
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.ReadOnly = true;
            this.TxtTotalPagar.Size = new System.Drawing.Size(136, 20);
            this.TxtTotalPagar.TabIndex = 19;
            this.TxtTotalPagar.Validating += new System.ComponentModel.CancelEventHandler(this.TxtTotalPagar_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(468, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total a pagar";
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(581, 492);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(473, 492);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptar.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptar.TabIndex = 16;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // BtnBuscarAvanzada
            // 
            this.BtnBuscarAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAvanzada.Image")));
            this.BtnBuscarAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarAvanzada.Location = new System.Drawing.Point(408, 45);
            this.BtnBuscarAvanzada.Name = "BtnBuscarAvanzada";
            this.BtnBuscarAvanzada.Padding = new System.Windows.Forms.Padding(70, 0, 70, 0);
            this.BtnBuscarAvanzada.Size = new System.Drawing.Size(275, 23);
            this.BtnBuscarAvanzada.TabIndex = 5;
            this.BtnBuscarAvanzada.Text = "Búsqueda avanzada";
            this.BtnBuscarAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarAvanzada.UseVisualStyleBackColor = true;
            this.BtnBuscarAvanzada.Click += new System.EventHandler(this.BtnBuscarAvanzada_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(608, 14);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(707, 543);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.GbCuotas);
            this.Controls.Add(this.ChkDejaGarantia);
            this.Controls.Add(this.NudMontoPrestar);
            this.Controls.Add(this.NudInteres);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.BtnBuscarAvanzada);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.TxtCliente);
            this.Controls.Add(this.TxtNumeroDocumento);
            this.Controls.Add(this.CboTipoDocumento);
            this.Controls.Add(this.CboTipoCliente);
            this.Controls.Add(this.LblMontoPrestar);
            this.Controls.Add(this.LblInteres);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblTipoCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Préstamo";
            ((System.ComponentModel.ISupportInitialize)(this.NudInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMontoPrestar)).EndInit();
            this.GbCuotas.ResumeLayout(false);
            this.GbCuotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudCantidadPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTipoCliente;
        private System.Windows.Forms.ComboBox CboTipoCliente;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnBuscarAvanzada;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Label LblInteres;
        private System.Windows.Forms.Label LblMontoPrestar;
        private System.Windows.Forms.NumericUpDown NudInteres;
        private System.Windows.Forms.NumericUpDown NudMontoPrestar;
        private System.Windows.Forms.CheckBox ChkDejaGarantia;
        private System.Windows.Forms.GroupBox GbCuotas;
        private System.Windows.Forms.DataGridView DgvCuotas;
        private System.Windows.Forms.Label LblPeriodo;
        private System.Windows.Forms.ComboBox CboTipoPeriodo;
        private System.Windows.Forms.NumericUpDown NudCantidadPeriodos;
        private System.Windows.Forms.Label LblCantidadPeriodo;
        private System.Windows.Forms.Button BtnGenerar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtTotalPagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdMonto;
    }
}