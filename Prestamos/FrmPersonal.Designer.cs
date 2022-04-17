
namespace Prestamos
{
    partial class FrmPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersonal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdTipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNumDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.GbPersonal = new System.Windows.Forms.GroupBox();
            this.CmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.LblCelular = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.LblTipoDocumento = new System.Windows.Forms.Label();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.LblDireccion = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNumeroDocumento = new System.Windows.Forms.Label();
            this.TxtNombres = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbPersonal.SuspendLayout();
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
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Controls.Add(this.BtnDarDeBaja);
            this.GbListado.Location = new System.Drawing.Point(368, 9);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(636, 457);
            this.GbListado.TabIndex = 1;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombre,
            this.cdApellidos,
            this.cdTipoDocumento,
            this.cdNumDocumento,
            this.cdCorreo,
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
            this.DgvListado.Size = new System.Drawing.Size(621, 342);
            this.DgvListado.TabIndex = 1;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombres";
            this.cdNombre.HeaderText = "Nombres";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            // 
            // cdApellidos
            // 
            this.cdApellidos.DataPropertyName = "Apellidos";
            this.cdApellidos.HeaderText = "Apellidos";
            this.cdApellidos.Name = "cdApellidos";
            this.cdApellidos.ReadOnly = true;
            // 
            // cdTipoDocumento
            // 
            this.cdTipoDocumento.DataPropertyName = "TipoDocumento";
            this.cdTipoDocumento.HeaderText = "Tipo Documento";
            this.cdTipoDocumento.Name = "cdTipoDocumento";
            this.cdTipoDocumento.ReadOnly = true;
            // 
            // cdNumDocumento
            // 
            this.cdNumDocumento.DataPropertyName = "NumDocumento";
            this.cdNumDocumento.HeaderText = "Num. Documento";
            this.cdNumDocumento.Name = "cdNumDocumento";
            this.cdNumDocumento.ReadOnly = true;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "Correo";
            this.cdCorreo.HeaderText = "Correo";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "Celular";
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(528, 19);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
            this.BtnListar.TabIndex = 0;
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
            this.BtnModificar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnModificar.Size = new System.Drawing.Size(102, 40);
            this.BtnModificar.TabIndex = 3;
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
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBaja.Image = ((System.Drawing.Image)(resources.GetObject("BtnDarDeBaja.Image")));
            this.BtnDarDeBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarDeBaja.Location = new System.Drawing.Point(528, 411);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(102, 40);
            this.BtnDarDeBaja.TabIndex = 4;
            this.BtnDarDeBaja.Text = "Dar de baja";
            this.BtnDarDeBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
            this.BtnDarDeBaja.Click += new System.EventHandler(this.BtnDarDeBaja_Click);
            // 
            // GbPersonal
            // 
            this.GbPersonal.Controls.Add(this.CmbTipoDocumento);
            this.GbPersonal.Controls.Add(this.ChkVigente);
            this.GbPersonal.Controls.Add(this.TxtCelular);
            this.GbPersonal.Controls.Add(this.TxtCorreo);
            this.GbPersonal.Controls.Add(this.LblCelular);
            this.GbPersonal.Controls.Add(this.LblCorreo);
            this.GbPersonal.Controls.Add(this.LblTipoDocumento);
            this.GbPersonal.Controls.Add(this.TxtDireccion);
            this.GbPersonal.Controls.Add(this.TxtApellidos);
            this.GbPersonal.Controls.Add(this.TxtNumeroDocumento);
            this.GbPersonal.Controls.Add(this.LblDireccion);
            this.GbPersonal.Controls.Add(this.LblApellidos);
            this.GbPersonal.Controls.Add(this.LblNumeroDocumento);
            this.GbPersonal.Controls.Add(this.TxtNombres);
            this.GbPersonal.Controls.Add(this.LblNombre);
            this.GbPersonal.Controls.Add(this.BtnCancelar);
            this.GbPersonal.Controls.Add(this.BtnAceptar);
            this.GbPersonal.Enabled = false;
            this.GbPersonal.Location = new System.Drawing.Point(10, 8);
            this.GbPersonal.Name = "GbPersonal";
            this.GbPersonal.Size = new System.Drawing.Size(352, 333);
            this.GbPersonal.TabIndex = 0;
            this.GbPersonal.TabStop = false;
            this.GbPersonal.Text = "Personal";
            // 
            // CmbTipoDocumento
            // 
            this.CmbTipoDocumento.FormattingEnabled = true;
            this.CmbTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Carnet de extranjería"});
            this.CmbTipoDocumento.Location = new System.Drawing.Point(125, 92);
            this.CmbTipoDocumento.Name = "CmbTipoDocumento";
            this.CmbTipoDocumento.Size = new System.Drawing.Size(209, 21);
            this.CmbTipoDocumento.TabIndex = 2;
            this.CmbTipoDocumento.SelectedIndexChanged += new System.EventHandler(this.CmbTipoDocumento_SelectedIndexChanged);
            this.CmbTipoDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.CmbTipoDocumento_Validating);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(125, 239);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 7;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(125, 176);
            this.TxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(210, 20);
            this.TxtCelular.TabIndex = 5;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCelular_KeyPress);
            this.TxtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(125, 147);
            this.TxtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(210, 20);
            this.TxtCorreo.TabIndex = 4;
            this.TxtCorreo.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // LblCelular
            // 
            this.LblCelular.AutoSize = true;
            this.LblCelular.Location = new System.Drawing.Point(8, 179);
            this.LblCelular.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCelular.Name = "LblCelular";
            this.LblCelular.Size = new System.Drawing.Size(39, 13);
            this.LblCelular.TabIndex = 13;
            this.LblCelular.Text = "Celular";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(8, 150);
            this.LblCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(38, 13);
            this.LblCorreo.TabIndex = 13;
            this.LblCorreo.Text = "Correo";
            // 
            // LblTipoDocumento
            // 
            this.LblTipoDocumento.AutoSize = true;
            this.LblTipoDocumento.Location = new System.Drawing.Point(7, 92);
            this.LblTipoDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTipoDocumento.Name = "LblTipoDocumento";
            this.LblTipoDocumento.Size = new System.Drawing.Size(84, 13);
            this.LblTipoDocumento.TabIndex = 13;
            this.LblTipoDocumento.Text = "Tipo documento";
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(125, 205);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(210, 20);
            this.TxtDireccion.TabIndex = 6;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(125, 60);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(210, 20);
            this.TxtApellidos.TabIndex = 1;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtNumeroDocumento
            // 
            this.TxtNumeroDocumento.Location = new System.Drawing.Point(125, 118);
            this.TxtNumeroDocumento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNumeroDocumento.Name = "TxtNumeroDocumento";
            this.TxtNumeroDocumento.Size = new System.Drawing.Size(210, 20);
            this.TxtNumeroDocumento.TabIndex = 3;
            this.TxtNumeroDocumento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNumeroDocumento_KeyPress);
            this.TxtNumeroDocumento.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNumeroDocumento_Validating);
            // 
            // LblDireccion
            // 
            this.LblDireccion.AutoSize = true;
            this.LblDireccion.Location = new System.Drawing.Point(7, 208);
            this.LblDireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDireccion.Name = "LblDireccion";
            this.LblDireccion.Size = new System.Drawing.Size(52, 13);
            this.LblDireccion.TabIndex = 13;
            this.LblDireccion.Text = "Direccion";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Location = new System.Drawing.Point(7, 63);
            this.LblApellidos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(49, 13);
            this.LblApellidos.TabIndex = 13;
            this.LblApellidos.Text = "Apellidos";
            // 
            // LblNumeroDocumento
            // 
            this.LblNumeroDocumento.AutoSize = true;
            this.LblNumeroDocumento.Location = new System.Drawing.Point(7, 121);
            this.LblNumeroDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNumeroDocumento.Name = "LblNumeroDocumento";
            this.LblNumeroDocumento.Size = new System.Drawing.Size(88, 13);
            this.LblNumeroDocumento.TabIndex = 13;
            this.LblNumeroDocumento.Text = "Num. documento";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(125, 31);
            this.TxtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombres.Name = "TxtNombres";
            this.TxtNombres.Size = new System.Drawing.Size(210, 20);
            this.TxtNombres.TabIndex = 0;
            this.TxtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(7, 34);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(49, 13);
            this.LblNombre.TabIndex = 13;
            this.LblNombre.Text = "Nombres";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(233, 278);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.BtnAceptar.Location = new System.Drawing.Point(118, 278);
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
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1014, 521);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbPersonal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de personal";
            this.Load += new System.EventHandler(this.FrmPersonal_Load);
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbPersonal.ResumeLayout(false);
            this.GbPersonal.PerformLayout();
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
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.GroupBox GbPersonal;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Label LblTipoDocumento;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtNumeroDocumento;
        private System.Windows.Forms.Label LblDireccion;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNumeroDocumento;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.Label LblCelular;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.ComboBox CmbTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNumDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
    }
}