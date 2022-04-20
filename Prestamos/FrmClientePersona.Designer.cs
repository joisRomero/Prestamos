
namespace Prestamos
{
    partial class FrmClientePersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientePersona));
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.TxtPersona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.GbPersona = new System.Windows.Forms.GroupBox();
            this.DtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.LblFechaNacimiento = new System.Windows.Forms.Label();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.CboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.CboDepartamento = new System.Windows.Forms.ComboBox();
            this.CboProvincia = new System.Windows.Forms.ComboBox();
            this.CboPersonalCartera = new System.Windows.Forms.ComboBox();
            this.CboDistrito = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtNumDocumento = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtCorreoPersonal = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(902, 532);
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
            this.GbListado.Controls.Add(this.TxtPersona);
            this.GbListado.Controls.Add(this.label9);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Location = new System.Drawing.Point(363, 9);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(641, 517);
            this.GbListado.TabIndex = 1;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // TxtPersona
            // 
            this.TxtPersona.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPersona.Location = new System.Drawing.Point(83, 32);
            this.TxtPersona.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPersona.Name = "TxtPersona";
            this.TxtPersona.Size = new System.Drawing.Size(412, 20);
            this.TxtPersona.TabIndex = 0;
            this.TxtPersona.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPersona_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Persona";
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
            this.cdNombres,
            this.cdApellidos,
            this.cdNumDocumento,
            this.cdDistrito,
            this.cdCelular});
            this.DgvListado.Location = new System.Drawing.Point(9, 64);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(626, 402);
            this.DgvListado.TabIndex = 2;
            // 
            // cdCategoria
            // 
            this.cdCategoria.DataPropertyName = "NombreCategoria";
            this.cdCategoria.HeaderText = "Categoría";
            this.cdCategoria.MinimumWidth = 6;
            this.cdCategoria.Name = "cdCategoria";
            this.cdCategoria.ReadOnly = true;
            // 
            // cdNombres
            // 
            this.cdNombres.DataPropertyName = "Nombres";
            this.cdNombres.HeaderText = "Nombres";
            this.cdNombres.MinimumWidth = 6;
            this.cdNombres.Name = "cdNombres";
            this.cdNombres.ReadOnly = true;
            // 
            // cdApellidos
            // 
            this.cdApellidos.DataPropertyName = "Apellidos";
            this.cdApellidos.HeaderText = "Apellidos";
            this.cdApellidos.MinimumWidth = 6;
            this.cdApellidos.Name = "cdApellidos";
            this.cdApellidos.ReadOnly = true;
            // 
            // cdNumDocumento
            // 
            this.cdNumDocumento.DataPropertyName = "NumeroDocumento";
            this.cdNumDocumento.HeaderText = "Num. Documento";
            this.cdNumDocumento.MinimumWidth = 6;
            this.cdNumDocumento.Name = "cdNumDocumento";
            this.cdNumDocumento.ReadOnly = true;
            // 
            // cdDistrito
            // 
            this.cdDistrito.DataPropertyName = "NombreDistrito";
            this.cdDistrito.HeaderText = "Distrito";
            this.cdDistrito.MinimumWidth = 6;
            this.cdDistrito.Name = "cdDistrito";
            this.cdDistrito.ReadOnly = true;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "Celular";
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.MinimumWidth = 6;
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(533, 19);
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
            this.BtnModificar.Location = new System.Drawing.Point(117, 471);
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
            this.BtnNuevo.Location = new System.Drawing.Point(9, 471);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnNuevo.Size = new System.Drawing.Size(102, 40);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // GbPersona
            // 
            this.GbPersona.Controls.Add(this.DtpFechaNacimiento);
            this.GbPersona.Controls.Add(this.LblFechaNacimiento);
            this.GbPersona.Controls.Add(this.ChkVigente);
            this.GbPersona.Controls.Add(this.CboCategoria);
            this.GbPersona.Controls.Add(this.CboTipoDocumento);
            this.GbPersona.Controls.Add(this.CboDepartamento);
            this.GbPersona.Controls.Add(this.CboProvincia);
            this.GbPersona.Controls.Add(this.CboPersonalCartera);
            this.GbPersona.Controls.Add(this.CboDistrito);
            this.GbPersona.Controls.Add(this.label8);
            this.GbPersona.Controls.Add(this.TxtNumDocumento);
            this.GbPersona.Controls.Add(this.TxtApellidos);
            this.GbPersona.Controls.Add(this.label7);
            this.GbPersona.Controls.Add(this.label2);
            this.GbPersona.Controls.Add(this.label10);
            this.GbPersona.Controls.Add(this.label5);
            this.GbPersona.Controls.Add(this.label4);
            this.GbPersona.Controls.Add(this.TxtCelular);
            this.GbPersona.Controls.Add(this.TxtCorreoPersonal);
            this.GbPersona.Controls.Add(this.TxtDireccion);
            this.GbPersona.Controls.Add(this.label11);
            this.GbPersona.Controls.Add(this.label12);
            this.GbPersona.Controls.Add(this.label13);
            this.GbPersona.Controls.Add(this.TxtNombres);
            this.GbPersona.Controls.Add(this.label6);
            this.GbPersona.Controls.Add(this.label1);
            this.GbPersona.Controls.Add(this.label3);
            this.GbPersona.Controls.Add(this.BtnCancelar);
            this.GbPersona.Controls.Add(this.BtnAceptar);
            this.GbPersona.Enabled = false;
            this.GbPersona.Location = new System.Drawing.Point(10, 8);
            this.GbPersona.Name = "GbPersona";
            this.GbPersona.Size = new System.Drawing.Size(347, 512);
            this.GbPersona.TabIndex = 0;
            this.GbPersona.TabStop = false;
            this.GbPersona.Text = "Persona";
            // 
            // DtpFechaNacimiento
            // 
            this.DtpFechaNacimiento.Location = new System.Drawing.Point(104, 176);
            this.DtpFechaNacimiento.Name = "DtpFechaNacimiento";
            this.DtpFechaNacimiento.Size = new System.Drawing.Size(210, 20);
            this.DtpFechaNacimiento.TabIndex = 11;
            // 
            // LblFechaNacimiento
            // 
            this.LblFechaNacimiento.AutoSize = true;
            this.LblFechaNacimiento.Location = new System.Drawing.Point(7, 180);
            this.LblFechaNacimiento.Name = "LblFechaNacimiento";
            this.LblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.LblFechaNacimiento.TabIndex = 10;
            this.LblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(104, 425);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 26;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // CboCategoria
            // 
            this.CboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(104, 30);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(210, 21);
            this.CboCategoria.TabIndex = 1;
            this.CboCategoria.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboTipoDocumento
            // 
            this.CboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoDocumento.FormattingEnabled = true;
            this.CboTipoDocumento.Location = new System.Drawing.Point(104, 117);
            this.CboTipoDocumento.Name = "CboTipoDocumento";
            this.CboTipoDocumento.Size = new System.Drawing.Size(210, 21);
            this.CboTipoDocumento.TabIndex = 7;
            this.CboTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CboTipoDocumento_SelectedIndexChanged);
            this.CboTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboDepartamento
            // 
            this.CboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDepartamento.FormattingEnabled = true;
            this.CboDepartamento.Location = new System.Drawing.Point(104, 205);
            this.CboDepartamento.Name = "CboDepartamento";
            this.CboDepartamento.Size = new System.Drawing.Size(210, 21);
            this.CboDepartamento.TabIndex = 13;
            this.CboDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboProvincia
            // 
            this.CboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProvincia.FormattingEnabled = true;
            this.CboProvincia.Location = new System.Drawing.Point(104, 235);
            this.CboProvincia.Name = "CboProvincia";
            this.CboProvincia.Size = new System.Drawing.Size(210, 21);
            this.CboProvincia.TabIndex = 15;
            this.CboProvincia.SelectedIndexChanged += new System.EventHandler(this.CboProvincia_SelectedIndexChanged);
            this.CboProvincia.Enter += new System.EventHandler(this.CboProvincia_Enter);
            this.CboProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // CboPersonalCartera
            // 
            this.CboPersonalCartera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPersonalCartera.FormattingEnabled = true;
            this.CboPersonalCartera.Location = new System.Drawing.Point(104, 386);
            this.CboPersonalCartera.Name = "CboPersonalCartera";
            this.CboPersonalCartera.Size = new System.Drawing.Size(210, 21);
            this.CboPersonalCartera.TabIndex = 25;
            // 
            // CboDistrito
            // 
            this.CboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDistrito.FormattingEnabled = true;
            this.CboDistrito.Location = new System.Drawing.Point(104, 265);
            this.CboDistrito.Name = "CboDistrito";
            this.CboDistrito.Size = new System.Drawing.Size(210, 21);
            this.CboDistrito.TabIndex = 17;
            this.CboDistrito.Enter += new System.EventHandler(this.CboDistrito_Enter);
            this.CboDistrito.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBox_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Categoría";
            // 
            // TxtNumDocumento
            // 
            this.TxtNumDocumento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNumDocumento.Location = new System.Drawing.Point(104, 146);
            this.TxtNumDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNumDocumento.Name = "TxtNumDocumento";
            this.TxtNumDocumento.Size = new System.Drawing.Size(210, 20);
            this.TxtNumDocumento.TabIndex = 9;
            this.TxtNumDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumDocumento_KeyPress);
            this.TxtNumDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumDocumento_Validating);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(104, 88);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(210, 20);
            this.TxtApellidos.TabIndex = 5;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Num. Documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Celular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Correo personal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dirección";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(104, 356);
            this.TxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCelular.MaxLength = 9;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(210, 20);
            this.TxtCelular.TabIndex = 23;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            this.TxtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // TxtCorreoPersonal
            // 
            this.TxtCorreoPersonal.Location = new System.Drawing.Point(104, 326);
            this.TxtCorreoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreoPersonal.Name = "TxtCorreoPersonal";
            this.TxtCorreoPersonal.Size = new System.Drawing.Size(210, 20);
            this.TxtCorreoPersonal.TabIndex = 21;
            this.TxtCorreoPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(104, 296);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(210, 20);
            this.TxtDireccion.TabIndex = 19;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 208);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Departamento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 238);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Provincia";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 389);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Personal";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(104, 59);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(210, 20);
            this.TxtNombres.TabIndex = 3;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 268);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Distrito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo documento";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(212, 456);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 28;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(104, 456);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptar.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptar.TabIndex = 27;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmClientePersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1014, 581);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbPersona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmClientePersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de personas";
            this.Load += new System.EventHandler(this.FrmClientePersona_Load);
            this.GbListado.ResumeLayout(false);
            this.GbListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbPersona.ResumeLayout(false);
            this.GbPersona.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.TextBox TxtPersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.GroupBox GbPersona;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.ComboBox CboDistrito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtNumDocumento;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtCorreoPersonal;
        private System.Windows.Forms.ComboBox CboTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.ComboBox CboDepartamento;
        private System.Windows.Forms.ComboBox CboProvincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker DtpFechaNacimiento;
        private System.Windows.Forms.Label LblFechaNacimiento;
        private System.Windows.Forms.ComboBox CboPersonalCartera;
        private System.Windows.Forms.Label label13;
    }
}