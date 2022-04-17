
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.GbListado = new System.Windows.Forms.GroupBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreoLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnDarDeBaja = new System.Windows.Forms.Button();
            this.GbPersonal = new System.Windows.Forms.GroupBox();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtCorreoLaboral = new System.Windows.Forms.TextBox();
            this.TxtCorreoPersonal = new System.Windows.Forms.TextBox();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCelular = new System.Windows.Forms.TextBox();
            this.TxtApellidos = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.GbListado.Location = new System.Drawing.Point(356, 9);
            this.GbListado.Name = "GbListado";
            this.GbListado.Size = new System.Drawing.Size(648, 457);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdNombre,
            this.cdApellidos,
            this.cdDNI,
            this.cdDireccion,
            this.cdCorreo,
            this.cdCorreoLaboral,
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
            this.DgvListado.Size = new System.Drawing.Size(633, 342);
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
            // cdDNI
            // 
            this.cdDNI.DataPropertyName = "DNI";
            this.cdDNI.HeaderText = "DNI";
            this.cdDNI.Name = "cdDNI";
            this.cdDNI.ReadOnly = true;
            // 
            // cdDireccion
            // 
            this.cdDireccion.DataPropertyName = "Direccion";
            this.cdDireccion.HeaderText = "Dirección";
            this.cdDireccion.Name = "cdDireccion";
            this.cdDireccion.ReadOnly = true;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "CorreoPersonal";
            this.cdCorreo.HeaderText = "Correo personal";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            // 
            // cdCorreoLaboral
            // 
            this.cdCorreoLaboral.DataPropertyName = "CorreoLaboral";
            this.cdCorreoLaboral.HeaderText = "Correo laboral";
            this.cdCorreoLaboral.Name = "cdCorreoLaboral";
            this.cdCorreoLaboral.ReadOnly = true;
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
            this.BtnListar.Location = new System.Drawing.Point(540, 19);
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
            this.BtnDarDeBaja.Location = new System.Drawing.Point(540, 411);
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
            this.GbPersonal.Controls.Add(this.ChkVigente);
            this.GbPersonal.Controls.Add(this.TxtCorreoLaboral);
            this.GbPersonal.Controls.Add(this.TxtCorreoPersonal);
            this.GbPersonal.Controls.Add(this.TxtDNI);
            this.GbPersonal.Controls.Add(this.label4);
            this.GbPersonal.Controls.Add(this.label7);
            this.GbPersonal.Controls.Add(this.label2);
            this.GbPersonal.Controls.Add(this.TxtCelular);
            this.GbPersonal.Controls.Add(this.TxtApellidos);
            this.GbPersonal.Controls.Add(this.TxtDireccion);
            this.GbPersonal.Controls.Add(this.label6);
            this.GbPersonal.Controls.Add(this.label1);
            this.GbPersonal.Controls.Add(this.label3);
            this.GbPersonal.Controls.Add(this.TxtNombres);
            this.GbPersonal.Controls.Add(this.LblNombre);
            this.GbPersonal.Controls.Add(this.BtnCancelar);
            this.GbPersonal.Controls.Add(this.BtnAceptar);
            this.GbPersonal.Enabled = false;
            this.GbPersonal.Location = new System.Drawing.Point(10, 8);
            this.GbPersonal.Name = "GbPersonal";
            this.GbPersonal.Size = new System.Drawing.Size(340, 333);
            this.GbPersonal.TabIndex = 0;
            this.GbPersonal.TabStop = false;
            this.GbPersonal.Text = "Personal";
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(99, 239);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 7;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtCorreoLaboral
            // 
            this.TxtCorreoLaboral.Location = new System.Drawing.Point(99, 176);
            this.TxtCorreoLaboral.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreoLaboral.Name = "TxtCorreoLaboral";
            this.TxtCorreoLaboral.Size = new System.Drawing.Size(210, 20);
            this.TxtCorreoLaboral.TabIndex = 5;
            this.TxtCorreoLaboral.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtCorreoPersonal
            // 
            this.TxtCorreoPersonal.Location = new System.Drawing.Point(99, 147);
            this.TxtCorreoPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCorreoPersonal.Name = "TxtCorreoPersonal";
            this.TxtCorreoPersonal.Size = new System.Drawing.Size(210, 20);
            this.TxtCorreoPersonal.TabIndex = 4;
            this.TxtCorreoPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(99, 89);
            this.TxtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDNI.MaxLength = 8;
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(210, 20);
            this.TxtDNI.TabIndex = 2;
            this.TxtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CelularDNI_KeyPress);
            this.TxtDNI.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Correo laboral";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 150);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo personal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "DNI";
            // 
            // TxtCelular
            // 
            this.TxtCelular.Location = new System.Drawing.Point(99, 205);
            this.TxtCelular.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCelular.MaxLength = 9;
            this.TxtCelular.Name = "TxtCelular";
            this.TxtCelular.Size = new System.Drawing.Size(210, 20);
            this.TxtCelular.TabIndex = 6;
            this.TxtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CelularDNI_KeyPress);
            this.TxtCelular.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtApellidos
            // 
            this.TxtApellidos.Location = new System.Drawing.Point(99, 60);
            this.TxtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.TxtApellidos.Name = "TxtApellidos";
            this.TxtApellidos.Size = new System.Drawing.Size(210, 20);
            this.TxtApellidos.TabIndex = 1;
            this.TxtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(99, 118);
            this.TxtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.Size = new System.Drawing.Size(210, 20);
            this.TxtDireccion.TabIndex = 3;
            this.TxtDireccion.Validating += new System.ComponentModel.CancelEventHandler(this.Controles_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 208);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Celular";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dirección";
            // 
            // TxtNombres
            // 
            this.TxtNombres.Location = new System.Drawing.Point(99, 31);
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
            this.BtnCancelar.Location = new System.Drawing.Point(207, 278);
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
            this.BtnAceptar.Location = new System.Drawing.Point(92, 278);
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
        private System.Windows.Forms.TextBox TxtCorreoPersonal;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCelular;
        private System.Windows.Forms.TextBox TxtApellidos;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNombres;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox TxtCorreoLaboral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreoLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
    }
}