
namespace Prestamos
{
    partial class FrmClienteEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClienteEmpresa));
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.TxtEmpresa = new System.Windows.Forms.TextBox();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdRUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbEmpresa = new System.Windows.Forms.GroupBox();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.CboDistrito = new System.Windows.Forms.ComboBox();
            this.LblCategoria = new System.Windows.Forms.Label();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtRUC = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblRUC = new System.Windows.Forms.Label();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtRazonSocial = new System.Windows.Forms.TextBox();
            this.LblDistrito = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(902, 472);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrrar.TabIndex = 2;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.TxtEmpresa);
            this.GbListado.Controls.Add(this.LblEmpresa);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(334, 9);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(670, 457);
            this.GbListado.TabIndex = 1;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // TxtEmpresa
            // 
            this.TxtEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmpresa.Location = new System.Drawing.Point(83, 32);
            this.TxtEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmpresa.Name = "TxtEmpresa";
            this.TxtEmpresa.Size = new System.Drawing.Size(438, 20);
            this.TxtEmpresa.TabIndex = 0;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Location = new System.Drawing.Point(12, 35);
            this.LblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(48, 13);
            this.LblEmpresa.TabIndex = 15;
            this.LblEmpresa.Text = "Empresa";
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
            this.cdCategoria,
            this.cdNombre,
            this.cdRUC,
            this.cdDistrito});
            this.DgvListado.Location = new System.Drawing.Point(9, 64);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(655, 342);
            this.DgvListado.TabIndex = 2;
            // 
            // cdCategoria
            // 
            this.cdCategoria.DataPropertyName = "NombreCategoria";
            this.cdCategoria.HeaderText = "Categoría";
            this.cdCategoria.Name = "cdCategoria";
            this.cdCategoria.ReadOnly = true;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "RazonSocial";
            this.cdNombre.HeaderText = "Empresa";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            // 
            // cdRUC
            // 
            this.cdRUC.DataPropertyName = "RUC";
            this.cdRUC.HeaderText = "RUC";
            this.cdRUC.Name = "cdRUC";
            this.cdRUC.ReadOnly = true;
            // 
            // cdDistrito
            // 
            this.cdDistrito.DataPropertyName = "NombreDistrito";
            this.cdDistrito.HeaderText = "Distrito";
            this.cdDistrito.Name = "cdDistrito";
            this.cdDistrito.ReadOnly = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(562, 19);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
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
            this.BtnModificar.Location = new System.Drawing.Point(117, 411);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnModificar.Size = new System.Drawing.Size(102, 40);
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
            this.BtnNuevo.Location = new System.Drawing.Point(9, 411);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnNuevo.Size = new System.Drawing.Size(102, 40);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GbEmpresa
            // 
            this.GbEmpresa.Controls.Add(this.CboProvincia);
            this.GbEmpresa.Controls.Add(this.CboDepartamento);
            this.GbEmpresa.Controls.Add(this.label1);
            this.GbEmpresa.Controls.Add(this.label2);
            this.GbEmpresa.Controls.Add(this.ChkVigente);
            this.GbEmpresa.Controls.Add(this.CboCategoria);
            this.GbEmpresa.Controls.Add(this.CboDistrito);
            this.GbEmpresa.Controls.Add(this.LblCategoria);
            this.GbEmpresa.Controls.Add(this.TxtTelefono);
            this.GbEmpresa.Controls.Add(this.TxtCorreo);
            this.GbEmpresa.Controls.Add(this.TxtRUC);
            this.GbEmpresa.Controls.Add(this.LblCorreo);
            this.GbEmpresa.Controls.Add(this.LblRUC);
            this.GbEmpresa.Controls.Add(this.LblDireccion);
            this.GbEmpresa.Controls.Add(this.TxtDireccion);
            this.GbEmpresa.Controls.Add(this.TxtRazonSocial);
            this.GbEmpresa.Controls.Add(this.LblDistrito);
            this.GbEmpresa.Controls.Add(this.LblRazonSocial);
            this.GbEmpresa.Controls.Add(this.LblTelefono);
            this.GbEmpresa.Controls.Add(this.BtnCancelar);
            this.GbEmpresa.Controls.Add(this.BtnAceptar);
            this.GbEmpresa.Enabled = false;
            this.GbEmpresa.Location = new System.Drawing.Point(10, 8);
            this.GbEmpresa.Name = "GbEmpresa";
            this.GbEmpresa.Size = new System.Drawing.Size(318, 407);
            this.GbEmpresa.TabIndex = 0;
            this.GbEmpresa.TabStop = false;
            this.GbEmpresa.Text = "Empresa";
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(86, 204);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(210, 21);
            this.CboProvincia.TabIndex = 18;
            this.CboProvincia.SelectedIndexChanged += new System.EventHandler(this.CboProvincia_SelectedIndexChanged);
            this.CboProvincia.Enter += new System.EventHandler(this.CboProvincia_Enter);
            this.CboProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(86, 175);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(210, 21);
            this.CboDepartamento.TabIndex = 15;
            this.CboDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 208);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Distrito";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(86, 306);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 7;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(86, 30);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(210, 21);
            this.CboCategoria.TabIndex = 0;
            this.CboCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboDistrito
            // 
            this.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDistrito.FormattingEnabled = true;
            this.CboDistrito.Location = new System.Drawing.Point(86, 234);
            this.CboDistrito.Name = "CboDistrito";
            this.CboDistrito.Size = new System.Drawing.Size(210, 21);
            this.CboDistrito.TabIndex = 5;
            this.CboDistrito.Enter += new System.EventHandler(this.CboDistrito_Enter);
            this.CboDistrito.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // LblCategoria
            // 
            this.LblCategoria.AutoSize = true;
            this.LblCategoria.Location = new System.Drawing.Point(7, 33);
            this.LblCategoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCategoria.Name = "LblCategoria";
            this.LblCategoria.Size = new System.Drawing.Size(54, 13);
            this.LblCategoria.TabIndex = 13;
            this.LblCategoria.Text = "Categoría";
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(86, 117);
            this.TxtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTelefono.MaxLength = 9;
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(210, 20);
            this.TxtTelefono.TabIndex = 3;
            this.TxtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUC_KeyPress);
            this.TxtTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(86, 146);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(210, 20);
            this.TxtCorreo.TabIndex = 4;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // TxtRUC
            // 
            this.TxtRUC.Location = new System.Drawing.Point(86, 88);
            this.TxtRUC.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRUC.MaxLength = 11;
            this.TxtRUC.Name = "TxtRUC";
            this.TxtRUC.Size = new System.Drawing.Size(210, 20);
            this.TxtRUC.TabIndex = 2;
            this.TxtRUC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRUC_KeyPress);
            this.TxtRUC.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(7, 149);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(38, 13);
            this.LblCorreo.TabIndex = 13;
            this.LblCorreo.Text = "Correo";
            // 
            // LblRUC
            // 
            this.LblRUC.AutoSize = true;
            this.LblRUC.Location = new System.Drawing.Point(7, 91);
            this.LblRUC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRUC.Name = "LblRUC";
            this.LblRUC.Size = new System.Drawing.Size(30, 13);
            this.LblRUC.TabIndex = 13;
            this.LblRUC.Text = "RUC";
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(7, 267);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 13;
            this.LblDireccion.Text = "Dirección";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(86, 264);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(210, 20);
            this.TxtDireccion.TabIndex = 6;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // TxtRazonSocial
            // 
            this.TxtRazonSocial.Location = new System.Drawing.Point(86, 59);
            this.TxtRazonSocial.Margin = new System.Windows.Forms.Padding(2);
            this.TxtRazonSocial.Name = "TxtRazonSocial";
            this.TxtRazonSocial.Size = new System.Drawing.Size(210, 20);
            this.TxtRazonSocial.TabIndex = 1;
            this.TxtRazonSocial.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblDistrito
            // 
            this.LblDistrito.AutoSize = true;
            this.LblDistrito.Location = new System.Drawing.Point(7, 178);
            this.LblDistrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDistrito.Name = "LblDistrito";
            this.LblDistrito.Size = new System.Drawing.Size(74, 13);
            this.LblDistrito.TabIndex = 13;
            this.LblDistrito.Text = "Departamento";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Location = new System.Drawing.Point(7, 62);
            this.LblRazonSocial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(68, 13);
            this.LblRazonSocial.TabIndex = 13;
            this.LblRazonSocial.Text = "Razón social";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Location = new System.Drawing.Point(7, 120);
            this.LblTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(49, 13);
            this.LblTelefono.TabIndex = 13;
            this.LblTelefono.Text = "Teléfono";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(194, 358);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(79, 358);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptar.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptar.TabIndex = 8;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmClienteEmpersa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1014, 521);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbEmpresa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClienteEmpersa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de empresas";
            this.Load += new System.EventHandler(this.FrmClienteEmpersa_Load);
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbEmpresa.ResumeLayout(false);
            this.GbEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbEmpresa;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.ComboBox CboDistrito;
        private System.Windows.Forms.Label LblCategoria;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtRUC;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblRUC;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.TextBox TxtRazonSocial;
        private System.Windows.Forms.Label LblDistrito;
        private System.Windows.Forms.Label LblRazonSocial;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtEmpresa;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdRUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDistrito;
        private System.Windows.Forms.ComboBox CboProvincia;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}