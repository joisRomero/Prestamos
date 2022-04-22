
namespace Prestamos
{
    partial class FrmCuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCuentaBancaria));
            this.GbCuentaBancaria = new System.Windows.Forms.GroupBox();
            this.CboEntidadesB = new System.Windows.Forms.ComboBox();
            this.LblEntidadB = new System.Windows.Forms.Label();
            this.BtnCancelarCuentaB = new System.Windows.Forms.Button();
            this.BtnAceptarCuentaB = new System.Windows.Forms.Button();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtCCI = new System.Windows.Forms.TextBox();
            this.LblCCI = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.TxtEntidadB = new System.Windows.Forms.TextBox();
            this.LblEntidadBancaria = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.cdEntidadB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbCuentaBancaria.SuspendLayout();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // GbCuentaBancaria
            // 
            this.GbCuentaBancaria.Controls.Add(this.CboEntidadesB);
            this.GbCuentaBancaria.Controls.Add(this.LblEntidadB);
            this.GbCuentaBancaria.Controls.Add(this.BtnCancelarCuentaB);
            this.GbCuentaBancaria.Controls.Add(this.BtnAceptarCuentaB);
            this.GbCuentaBancaria.Controls.Add(this.ChkVigente);
            this.GbCuentaBancaria.Controls.Add(this.TxtCCI);
            this.GbCuentaBancaria.Controls.Add(this.LblCCI);
            this.GbCuentaBancaria.Controls.Add(this.TxtNumero);
            this.GbCuentaBancaria.Controls.Add(this.LblNumero);
            this.GbCuentaBancaria.Enabled = false;
            this.GbCuentaBancaria.Location = new System.Drawing.Point(12, 11);
            this.GbCuentaBancaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbCuentaBancaria.Name = "GbCuentaBancaria";
            this.GbCuentaBancaria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbCuentaBancaria.Size = new System.Drawing.Size(442, 270);
            this.GbCuentaBancaria.TabIndex = 2;
            this.GbCuentaBancaria.TabStop = false;
            this.GbCuentaBancaria.Text = "Cuenta Bancaria";
            // 
            // CboEntidadesB
            // 
            this.CboEntidadesB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEntidadesB.FormattingEnabled = true;
            this.CboEntidadesB.Location = new System.Drawing.Point(133, 32);
            this.CboEntidadesB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboEntidadesB.Name = "CboEntidadesB";
            this.CboEntidadesB.Size = new System.Drawing.Size(279, 24);
            this.CboEntidadesB.TabIndex = 17;
            this.CboEntidadesB.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // LblEntidadB
            // 
            this.LblEntidadB.AutoSize = true;
            this.LblEntidadB.Location = new System.Drawing.Point(13, 34);
            this.LblEntidadB.Name = "LblEntidadB";
            this.LblEntidadB.Size = new System.Drawing.Size(116, 17);
            this.LblEntidadB.TabIndex = 16;
            this.LblEntidadB.Text = "Entidad Bancaria";
            // 
            // BtnCancelarCuentaB
            // 
            this.BtnCancelarCuentaB.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarCuentaB.Image")));
            this.BtnCancelarCuentaB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarCuentaB.Location = new System.Drawing.Point(277, 199);
            this.BtnCancelarCuentaB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelarCuentaB.Name = "BtnCancelarCuentaB";
            this.BtnCancelarCuentaB.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnCancelarCuentaB.Size = new System.Drawing.Size(136, 49);
            this.BtnCancelarCuentaB.TabIndex = 5;
            this.BtnCancelarCuentaB.Text = "Cancelar";
            this.BtnCancelarCuentaB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarCuentaB.UseVisualStyleBackColor = true;
            this.BtnCancelarCuentaB.Click += new System.EventHandler(this.BtnCancelarCuentaB_Click);
            // 
            // BtnAceptarCuentaB
            // 
            this.BtnAceptarCuentaB.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptarCuentaB.Image")));
            this.BtnAceptarCuentaB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptarCuentaB.Location = new System.Drawing.Point(133, 199);
            this.BtnAceptarCuentaB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAceptarCuentaB.Name = "BtnAceptarCuentaB";
            this.BtnAceptarCuentaB.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnAceptarCuentaB.Size = new System.Drawing.Size(136, 49);
            this.BtnAceptarCuentaB.TabIndex = 4;
            this.BtnAceptarCuentaB.Text = "Aceptar";
            this.BtnAceptarCuentaB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptarCuentaB.UseVisualStyleBackColor = true;
            this.BtnAceptarCuentaB.Click += new System.EventHandler(this.BtnAceptarCuentaB_Click);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(109, 155);
            this.ChkVigente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(78, 21);
            this.ChkVigente.TabIndex = 3;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtCCI
            // 
            this.TxtCCI.Location = new System.Drawing.Point(133, 110);
            this.TxtCCI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCCI.MaxLength = 20;
            this.TxtCCI.Name = "TxtCCI";
            this.TxtCCI.Size = new System.Drawing.Size(279, 22);
            this.TxtCCI.TabIndex = 1;
            this.TxtCCI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCCI_KeyPress);
            this.TxtCCI.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblCCI
            // 
            this.LblCCI.AutoSize = true;
            this.LblCCI.Location = new System.Drawing.Point(13, 112);
            this.LblCCI.Name = "LblCCI";
            this.LblCCI.Size = new System.Drawing.Size(29, 17);
            this.LblCCI.TabIndex = 0;
            this.LblCCI.Text = "CCI";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(133, 73);
            this.TxtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNumero.MaxLength = 20;
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(279, 22);
            this.TxtNumero.TabIndex = 0;
            this.TxtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumero_KeyPress);
            this.TxtNumero.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(13, 75);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(58, 17);
            this.LblNumero.TabIndex = 0;
            this.LblNumero.Text = "Número";
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.BtnDarDeBaja);
            this.GbListado.Controls.Add(this.TxtEntidadB);
            this.GbListado.Controls.Add(this.LblEntidadBancaria);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(461, 11);
            this.GbListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbListado.Name = "GbListado";
            this.GbListado.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GbListado.Size = new System.Drawing.Size(695, 562);
            this.GbListado.TabIndex = 3;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBaja.Image = ((System.Drawing.Image)(resources.GetObject("BtnDarDeBaja.Image")));
            this.BtnDarDeBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarDeBaja.Location = new System.Drawing.Point(551, 506);
            this.BtnDarDeBaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(136, 49);
            this.BtnDarDeBaja.TabIndex = 16;
            this.BtnDarDeBaja.Text = "Dar de baja";
            this.BtnDarDeBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
            // 
            // TxtEntidadB
            // 
            this.TxtEntidadB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEntidadB.Location = new System.Drawing.Point(139, 39);
            this.TxtEntidadB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtEntidadB.Name = "TxtEntidadB";
            this.TxtEntidadB.Size = new System.Drawing.Size(385, 22);
            this.TxtEntidadB.TabIndex = 0;
            // 
            // LblEntidadBancaria
            // 
            this.LblEntidadBancaria.AutoSize = true;
            this.LblEntidadBancaria.Location = new System.Drawing.Point(16, 43);
            this.LblEntidadBancaria.Name = "LblEntidadBancaria";
            this.LblEntidadBancaria.Size = new System.Drawing.Size(116, 17);
            this.LblEntidadBancaria.TabIndex = 15;
            this.LblEntidadBancaria.Text = "Entidad Bancaria";
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToResizeColumns = false;
            this.DgvListado.AllowUserToResizeRows = false;
            this.DgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdEntidadB,
            this.cdNumero,
            this.cdCCI});
            this.DgvListado.Location = new System.Drawing.Point(12, 79);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(675, 421);
            this.DgvListado.TabIndex = 2;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(551, 23);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(13, 0, 20, 0);
            this.BtnListar.Size = new System.Drawing.Size(136, 49);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(156, 506);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnModificar.Size = new System.Drawing.Size(136, 49);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(12, 506);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnNuevo.Size = new System.Drawing.Size(136, 49);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(1020, 585);
            this.BtnCerrrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(136, 49);
            this.BtnCerrrar.TabIndex = 4;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // cdEntidadB
            // 
            this.cdEntidadB.DataPropertyName = "NombreEntidadB";
            this.cdEntidadB.HeaderText = "Entidad";
            this.cdEntidadB.MinimumWidth = 6;
            this.cdEntidadB.Name = "cdEntidadB";
            this.cdEntidadB.ReadOnly = true;
            // 
            // cdNumero
            // 
            this.cdNumero.DataPropertyName = "Numero";
            this.cdNumero.HeaderText = "N° de Cuenta";
            this.cdNumero.MinimumWidth = 6;
            this.cdNumero.Name = "cdNumero";
            this.cdNumero.ReadOnly = true;
            // 
            // cdCCI
            // 
            this.cdCCI.DataPropertyName = "CCI";
            this.cdCCI.HeaderText = "CCI";
            this.cdCCI.MinimumWidth = 6;
            this.cdCCI.Name = "cdCCI";
            this.cdCCI.ReadOnly = true;
            // 
            // FrmCuentaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1163, 647);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbCuentaBancaria);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCuentaBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuenta Bancaria";
            this.Load += new System.EventHandler(this.FrmCuentaBancaria_Load);
            this.GbCuentaBancaria.ResumeLayout(false);
            this.GbCuentaBancaria.PerformLayout();
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbCuentaBancaria;
        private System.Windows.Forms.Button BtnCancelarCuentaB;
        private System.Windows.Forms.Button BtnAceptarCuentaB;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtCCI;
        private System.Windows.Forms.Label LblCCI;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.ComboBox CboEntidadesB;
        private System.Windows.Forms.Label LblEntidadB;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.TextBox TxtEntidadB;
        private System.Windows.Forms.Label LblEntidadBancaria;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdEntidadB;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCCI;
    }
}