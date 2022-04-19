
namespace Prestamos
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.GbUsuario = new System.Windows.Forms.GroupBox();
            this.BtnBuscarAvanzada = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.ChkContineAlMenosUnSimbolo = new System.Windows.Forms.CheckBox();
            this.ChkContineAlMenosUnaMinuscula = new System.Windows.Forms.CheckBox();
            this.ChkContineAlMenosUnaMayuscula = new System.Windows.Forms.CheckBox();
            this.ChkMinimo8Caracteres = new System.Windows.Forms.CheckBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtConfirmar = new System.Windows.Forms.TextBox();
            this.LblConfirmar = new System.Windows.Forms.Label();
            this.TxtClave = new System.Windows.Forms.TextBox();
            this.LblClave = new System.Windows.Forms.Label();
            this.TxtNombrePersonal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtPersonal = new System.Windows.Forms.TextBox();
            this.LblPersonal = new System.Windows.Forms.Label();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.CboTipoUsuario = new System.Windows.Forms.ComboBox();
            this.CdPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GbListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.GbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrar.Location = new System.Drawing.Point(811, 462);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrar.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // GbListado
            // 
            this.GbListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListado.Controls.Add(this.BtnDarDeBaja);
            this.GbListado.Controls.Add(this.BtnModificar);
            this.GbListado.Controls.Add(this.BtnListar);
            this.GbListado.Controls.Add(this.BtnNuevo);
            this.GbListado.Controls.Add(this.DgvListado);
            this.GbListado.Location = new System.Drawing.Point(379, 11);
            this.GbListado.Margin = new System.Windows.Forms.Padding(2);
            this.GbListado.Name = "GbListado";
            this.GbListado.Padding = new System.Windows.Forms.Padding(2);
            this.GbListado.Size = new System.Drawing.Size(534, 447);
            this.GbListado.TabIndex = 1;
            this.GbListado.TabStop = false;
            this.GbListado.Text = "Listado";
            // 
            // BtnDarDeBaja
            // 
            this.BtnDarDeBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBaja.Image = ((System.Drawing.Image)(resources.GetObject("BtnDarDeBaja.Image")));
            this.BtnDarDeBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarDeBaja.Location = new System.Drawing.Point(418, 399);
            this.BtnDarDeBaja.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDarDeBaja.Name = "BtnDarDeBaja";
            this.BtnDarDeBaja.Size = new System.Drawing.Size(102, 40);
            this.BtnDarDeBaja.TabIndex = 5;
            this.BtnDarDeBaja.Text = "Dar de baja";
            this.BtnDarDeBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarDeBaja.UseVisualStyleBackColor = true;
            this.BtnDarDeBaja.Click += new System.EventHandler(this.BtnDarDeBaja_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificar.Location = new System.Drawing.Point(121, 399);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnModificar.Size = new System.Drawing.Size(102, 40);
            this.BtnModificar.TabIndex = 4;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(418, 16);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevo.Location = new System.Drawing.Point(15, 399);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnNuevo.Size = new System.Drawing.Size(102, 40);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevoDistrito_Click);
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
            this.CdPersonal,
            this.CdNombre});
            this.DgvListado.Location = new System.Drawing.Point(15, 60);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(505, 328);
            this.DgvListado.TabIndex = 2;
            // 
            // GbUsuario
            // 
            this.GbUsuario.Controls.Add(this.CboTipoUsuario);
            this.GbUsuario.Controls.Add(this.BtnBuscarAvanzada);
            this.GbUsuario.Controls.Add(this.BtnBuscar);
            this.GbUsuario.Controls.Add(this.ChkContineAlMenosUnSimbolo);
            this.GbUsuario.Controls.Add(this.ChkContineAlMenosUnaMinuscula);
            this.GbUsuario.Controls.Add(this.ChkContineAlMenosUnaMayuscula);
            this.GbUsuario.Controls.Add(this.ChkMinimo8Caracteres);
            this.GbUsuario.Controls.Add(this.BtnCancelar);
            this.GbUsuario.Controls.Add(this.BtnAceptar);
            this.GbUsuario.Controls.Add(this.ChkVigente);
            this.GbUsuario.Controls.Add(this.TxtConfirmar);
            this.GbUsuario.Controls.Add(this.LblConfirmar);
            this.GbUsuario.Controls.Add(this.TxtClave);
            this.GbUsuario.Controls.Add(this.LblClave);
            this.GbUsuario.Controls.Add(this.label2);
            this.GbUsuario.Controls.Add(this.TxtNombrePersonal);
            this.GbUsuario.Controls.Add(this.label1);
            this.GbUsuario.Controls.Add(this.TxtNombre);
            this.GbUsuario.Controls.Add(this.LblNombre);
            this.GbUsuario.Controls.Add(this.TxtPersonal);
            this.GbUsuario.Controls.Add(this.LblPersonal);
            this.GbUsuario.Enabled = false;
            this.GbUsuario.Location = new System.Drawing.Point(10, 11);
            this.GbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.GbUsuario.Name = "GbUsuario";
            this.GbUsuario.Padding = new System.Windows.Forms.Padding(2);
            this.GbUsuario.Size = new System.Drawing.Size(365, 400);
            this.GbUsuario.TabIndex = 0;
            this.GbUsuario.TabStop = false;
            this.GbUsuario.Text = "Usuario";
            // 
            // BtnBuscarAvanzada
            // 
            this.BtnBuscarAvanzada.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscarAvanzada.Image")));
            this.BtnBuscarAvanzada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscarAvanzada.Location = new System.Drawing.Point(94, 56);
            this.BtnBuscarAvanzada.Name = "BtnBuscarAvanzada";
            this.BtnBuscarAvanzada.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.BtnBuscarAvanzada.Size = new System.Drawing.Size(240, 23);
            this.BtnBuscarAvanzada.TabIndex = 16;
            this.BtnBuscarAvanzada.Text = "Búsqueda avanzada";
            this.BtnBuscarAvanzada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscarAvanzada.UseVisualStyleBackColor = true;
            this.BtnBuscarAvanzada.Click += new System.EventHandler(this.BtnBuscarAvanzada_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBuscar.Image")));
            this.BtnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBuscar.Location = new System.Drawing.Point(259, 25);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 15;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ChkContineAlMenosUnSimbolo
            // 
            this.ChkContineAlMenosUnSimbolo.AutoCheck = false;
            this.ChkContineAlMenosUnSimbolo.AutoSize = true;
            this.ChkContineAlMenosUnSimbolo.Location = new System.Drawing.Point(94, 249);
            this.ChkContineAlMenosUnSimbolo.Name = "ChkContineAlMenosUnSimbolo";
            this.ChkContineAlMenosUnSimbolo.Size = new System.Drawing.Size(162, 17);
            this.ChkContineAlMenosUnSimbolo.TabIndex = 11;
            this.ChkContineAlMenosUnSimbolo.Text = "Contine al menos un símbolo";
            this.ChkContineAlMenosUnSimbolo.UseVisualStyleBackColor = true;
            this.ChkContineAlMenosUnSimbolo.Validating += new System.ComponentModel.CancelEventHandler(this.CheckBoxClave_Validating);
            // 
            // ChkContineAlMenosUnaMinuscula
            // 
            this.ChkContineAlMenosUnaMinuscula.AutoCheck = false;
            this.ChkContineAlMenosUnaMinuscula.AutoSize = true;
            this.ChkContineAlMenosUnaMinuscula.Location = new System.Drawing.Point(94, 233);
            this.ChkContineAlMenosUnaMinuscula.Name = "ChkContineAlMenosUnaMinuscula";
            this.ChkContineAlMenosUnaMinuscula.Size = new System.Drawing.Size(184, 17);
            this.ChkContineAlMenosUnaMinuscula.TabIndex = 12;
            this.ChkContineAlMenosUnaMinuscula.Text = "Contiene al menos una minúscula";
            this.ChkContineAlMenosUnaMinuscula.UseVisualStyleBackColor = true;
            this.ChkContineAlMenosUnaMinuscula.Validating += new System.ComponentModel.CancelEventHandler(this.CheckBoxClave_Validating);
            // 
            // ChkContineAlMenosUnaMayuscula
            // 
            this.ChkContineAlMenosUnaMayuscula.AutoCheck = false;
            this.ChkContineAlMenosUnaMayuscula.AutoSize = true;
            this.ChkContineAlMenosUnaMayuscula.Location = new System.Drawing.Point(94, 217);
            this.ChkContineAlMenosUnaMayuscula.Name = "ChkContineAlMenosUnaMayuscula";
            this.ChkContineAlMenosUnaMayuscula.Size = new System.Drawing.Size(187, 17);
            this.ChkContineAlMenosUnaMayuscula.TabIndex = 13;
            this.ChkContineAlMenosUnaMayuscula.Text = "Contiene al menos una mayúscula";
            this.ChkContineAlMenosUnaMayuscula.UseVisualStyleBackColor = true;
            this.ChkContineAlMenosUnaMayuscula.Validating += new System.ComponentModel.CancelEventHandler(this.CheckBoxClave_Validating);
            // 
            // ChkMinimo8Caracteres
            // 
            this.ChkMinimo8Caracteres.AutoCheck = false;
            this.ChkMinimo8Caracteres.AutoSize = true;
            this.ChkMinimo8Caracteres.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.ChkMinimo8Caracteres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ChkMinimo8Caracteres.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ChkMinimo8Caracteres.Location = new System.Drawing.Point(94, 201);
            this.ChkMinimo8Caracteres.Name = "ChkMinimo8Caracteres";
            this.ChkMinimo8Caracteres.Size = new System.Drawing.Size(123, 17);
            this.ChkMinimo8Caracteres.TabIndex = 14;
            this.ChkMinimo8Caracteres.Text = "Mínimo 8 caracteres";
            this.ChkMinimo8Caracteres.UseVisualStyleBackColor = true;
            this.ChkMinimo8Caracteres.Validating += new System.ComponentModel.CancelEventHandler(this.CheckBoxClave_Validating);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(232, 349);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelarDistrito_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptar.Image")));
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(124, 349);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptar.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptar.TabIndex = 5;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(94, 317);
            this.ChkVigente.Margin = new System.Windows.Forms.Padding(2);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 4;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtConfirmar
            // 
            this.TxtConfirmar.Location = new System.Drawing.Point(94, 281);
            this.TxtConfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.TxtConfirmar.Name = "TxtConfirmar";
            this.TxtConfirmar.PasswordChar = '*';
            this.TxtConfirmar.Size = new System.Drawing.Size(240, 20);
            this.TxtConfirmar.TabIndex = 3;
            this.TxtConfirmar.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmar_Validating);
            // 
            // LblConfirmar
            // 
            this.LblConfirmar.AutoSize = true;
            this.LblConfirmar.Location = new System.Drawing.Point(4, 283);
            this.LblConfirmar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblConfirmar.Name = "LblConfirmar";
            this.LblConfirmar.Size = new System.Drawing.Size(51, 13);
            this.LblConfirmar.TabIndex = 0;
            this.LblConfirmar.Text = "Confirmar";
            // 
            // TxtClave
            // 
            this.TxtClave.Location = new System.Drawing.Point(94, 176);
            this.TxtClave.Margin = new System.Windows.Forms.Padding(2);
            this.TxtClave.Name = "TxtClave";
            this.TxtClave.PasswordChar = '*';
            this.TxtClave.Size = new System.Drawing.Size(240, 20);
            this.TxtClave.TabIndex = 2;
            this.TxtClave.TextChanged += new System.EventHandler(this.TxtClave_TextChanged);
            this.TxtClave.Validating += new System.ComponentModel.CancelEventHandler(this.TxtClave_Validating);
            // 
            // LblClave
            // 
            this.LblClave.AutoSize = true;
            this.LblClave.Location = new System.Drawing.Point(4, 178);
            this.LblClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblClave.Name = "LblClave";
            this.LblClave.Size = new System.Drawing.Size(34, 13);
            this.LblClave.TabIndex = 0;
            this.LblClave.Text = "Clave";
            // 
            // TxtNombrePersonal
            // 
            this.TxtNombrePersonal.Enabled = false;
            this.TxtNombrePersonal.Location = new System.Drawing.Point(94, 88);
            this.TxtNombrePersonal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombrePersonal.Name = "TxtNombrePersonal";
            this.TxtNombrePersonal.Size = new System.Drawing.Size(240, 20);
            this.TxtNombrePersonal.TabIndex = 1;
            this.TxtNombrePersonal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nmb. personal";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(94, 147);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(240, 20);
            this.TxtNombre.TabIndex = 1;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(4, 149);
            this.LblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(84, 13);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nmb. de usuario";
            // 
            // TxtPersonal
            // 
            this.TxtPersonal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtPersonal.Location = new System.Drawing.Point(94, 27);
            this.TxtPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPersonal.MaxLength = 8;
            this.TxtPersonal.Name = "TxtPersonal";
            this.TxtPersonal.Size = new System.Drawing.Size(161, 20);
            this.TxtPersonal.TabIndex = 0;
            this.TxtPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPersonal_Validating);
            // 
            // LblPersonal
            // 
            this.LblPersonal.AutoSize = true;
            this.LblPersonal.Location = new System.Drawing.Point(4, 29);
            this.LblPersonal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblPersonal.Name = "LblPersonal";
            this.LblPersonal.Size = new System.Drawing.Size(48, 13);
            this.LblPersonal.TabIndex = 0;
            this.LblPersonal.Text = "Personal";
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo";
            // 
            // CboTipoUsuario
            // 
            this.CboTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTipoUsuario.FormattingEnabled = true;
            this.CboTipoUsuario.Items.AddRange(new object[] {
            "Limitado",
            "Administrador"});
            this.CboTipoUsuario.Location = new System.Drawing.Point(94, 116);
            this.CboTipoUsuario.Name = "CboTipoUsuario";
            this.CboTipoUsuario.Size = new System.Drawing.Size(240, 21);
            this.CboTipoUsuario.TabIndex = 17;
            // 
            // CdPersonal
            // 
            this.CdPersonal.DataPropertyName = "NombrePersonal";
            this.CdPersonal.HeaderText = "Personal";
            this.CdPersonal.Name = "CdPersonal";
            this.CdPersonal.ReadOnly = true;
            // 
            // CdNombre
            // 
            this.CdNombre.DataPropertyName = "Nombre";
            this.CdNombre.HeaderText = "Nombre de usuario";
            this.CdNombre.Name = "CdNombre";
            this.CdNombre.ReadOnly = true;
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(923, 512);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.GbListado);
            this.Controls.Add(this.GbUsuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de usuarios";
            this.GbListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.GbUsuario.ResumeLayout(false);
            this.GbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.GroupBox GbListado;
        private System.Windows.Forms.Button BtnDarDeBaja;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.GroupBox GbUsuario;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtClave;
        private System.Windows.Forms.Label LblClave;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtPersonal;
        private System.Windows.Forms.Label LblPersonal;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.TextBox TxtConfirmar;
        private System.Windows.Forms.Label LblConfirmar;
        private System.Windows.Forms.CheckBox ChkContineAlMenosUnSimbolo;
        private System.Windows.Forms.CheckBox ChkContineAlMenosUnaMinuscula;
        private System.Windows.Forms.CheckBox ChkContineAlMenosUnaMayuscula;
        private System.Windows.Forms.CheckBox ChkMinimo8Caracteres;
        private System.Windows.Forms.Button BtnBuscarAvanzada;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtNombrePersonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboTipoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombre;
    }
}