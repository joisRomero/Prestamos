
namespace Prestamos
{
    partial class FrmDistrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistrito));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbDistrito = new System.Windows.Forms.GroupBox();
            this.BtnCancelarDistrito = new System.Windows.Forms.Button();
            this.BtnAceptarDistrito = new System.Windows.Forms.Button();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtDepartamento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtProvincia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombreDistrito = new System.Windows.Forms.Label();
            this.GbListadoDistritos = new System.Windows.Forms.GroupBox();
            this.BtnDarDeBajaDistrito = new System.Windows.Forms.Button();
            this.BtnModificarDistrito = new System.Windows.Forms.Button();
            this.BtnListarDistritos = new System.Windows.Forms.Button();
            this.BtnNuevoDistrito = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrarDistrito = new System.Windows.Forms.Button();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbDistrito.SuspendLayout();
            this.GbListadoDistritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDistrito
            // 
            this.GbDistrito.Controls.Add(this.BtnCancelarDistrito);
            this.GbDistrito.Controls.Add(this.BtnAceptarDistrito);
            this.GbDistrito.Controls.Add(this.ChkVigente);
            this.GbDistrito.Controls.Add(this.TxtDepartamento);
            this.GbDistrito.Controls.Add(this.label2);
            this.GbDistrito.Controls.Add(this.TxtProvincia);
            this.GbDistrito.Controls.Add(this.label1);
            this.GbDistrito.Controls.Add(this.TxtNombre);
            this.GbDistrito.Controls.Add(this.LblNombreDistrito);
            this.GbDistrito.Enabled = false;
            this.GbDistrito.Location = new System.Drawing.Point(9, 10);
            this.GbDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.GbDistrito.Name = "GbDistrito";
            this.GbDistrito.Padding = new System.Windows.Forms.Padding(2);
            this.GbDistrito.Size = new System.Drawing.Size(316, 228);
            this.GbDistrito.TabIndex = 0;
            this.GbDistrito.TabStop = false;
            this.GbDistrito.Text = "Distrito";
            // 
            // BtnCancelarDistrito
            // 
            this.BtnCancelarDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarDistrito.Image")));
            this.BtnCancelarDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarDistrito.Location = new System.Drawing.Point(192, 170);
            this.BtnCancelarDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelarDistrito.Name = "BtnCancelarDistrito";
            this.BtnCancelarDistrito.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelarDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelarDistrito.TabIndex = 5;
            this.BtnCancelarDistrito.Text = "Cancelar";
            this.BtnCancelarDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarDistrito.UseVisualStyleBackColor = true;
            this.BtnCancelarDistrito.Click += new System.EventHandler(this.BtnCancelarDistrito_Click);
            // 
            // BtnAceptarDistrito
            // 
            this.BtnAceptarDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptarDistrito.Image")));
            this.BtnAceptarDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptarDistrito.Location = new System.Drawing.Point(84, 170);
            this.BtnAceptarDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptarDistrito.Name = "BtnAceptarDistrito";
            this.BtnAceptarDistrito.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAceptarDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnAceptarDistrito.TabIndex = 4;
            this.BtnAceptarDistrito.Text = "Aceptar";
            this.BtnAceptarDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptarDistrito.UseVisualStyleBackColor = true;
            this.BtnAceptarDistrito.Click += new System.EventHandler(this.BtnAceptarDistrito_Click);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(84, 127);
            this.ChkVigente.Margin = new System.Windows.Forms.Padding(2);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(62, 17);
            this.ChkVigente.TabIndex = 3;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtDepartamento
            // 
            this.TxtDepartamento.Location = new System.Drawing.Point(84, 88);
            this.TxtDepartamento.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDepartamento.Name = "TxtDepartamento";
            this.TxtDepartamento.Size = new System.Drawing.Size(210, 20);
            this.TxtDepartamento.TabIndex = 2;
            this.TxtDepartamento.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Departamento";
            // 
            // TxtProvincia
            // 
            this.TxtProvincia.Location = new System.Drawing.Point(84, 57);
            this.TxtProvincia.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProvincia.Name = "TxtProvincia";
            this.TxtProvincia.Size = new System.Drawing.Size(210, 20);
            this.TxtProvincia.TabIndex = 1;
            this.TxtProvincia.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Provincia";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(84, 27);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(210, 20);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblNombreDistrito
            // 
            this.LblNombreDistrito.AutoSize = true;
            this.LblNombreDistrito.Location = new System.Drawing.Point(6, 29);
            this.LblNombreDistrito.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblNombreDistrito.Name = "LblNombreDistrito";
            this.LblNombreDistrito.Size = new System.Drawing.Size(44, 13);
            this.LblNombreDistrito.TabIndex = 0;
            this.LblNombreDistrito.Text = "Nombre";
            // 
            // GbListadoDistritos
            // 
            this.GbListadoDistritos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoDistritos.Controls.Add(this.BtnDarDeBajaDistrito);
            this.GbListadoDistritos.Controls.Add(this.BtnModificarDistrito);
            this.GbListadoDistritos.Controls.Add(this.BtnListarDistritos);
            this.GbListadoDistritos.Controls.Add(this.BtnNuevoDistrito);
            this.GbListadoDistritos.Controls.Add(this.DgvListado);
            this.GbListadoDistritos.Location = new System.Drawing.Point(329, 10);
            this.GbListadoDistritos.Margin = new System.Windows.Forms.Padding(2);
            this.GbListadoDistritos.Name = "GbListadoDistritos";
            this.GbListadoDistritos.Padding = new System.Windows.Forms.Padding(2);
            this.GbListadoDistritos.Size = new System.Drawing.Size(520, 447);
            this.GbListadoDistritos.TabIndex = 1;
            this.GbListadoDistritos.TabStop = false;
            this.GbListadoDistritos.Text = "Listado Distritos";
            // 
            // BtnDarDeBajaDistrito
            // 
            this.BtnDarDeBajaDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBajaDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnDarDeBajaDistrito.Image")));
            this.BtnDarDeBajaDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarDeBajaDistrito.Location = new System.Drawing.Point(404, 399);
            this.BtnDarDeBajaDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDarDeBajaDistrito.Name = "BtnDarDeBajaDistrito";
            this.BtnDarDeBajaDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnDarDeBajaDistrito.TabIndex = 4;
            this.BtnDarDeBajaDistrito.Text = "Dar de baja";
            this.BtnDarDeBajaDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarDeBajaDistrito.UseVisualStyleBackColor = true;
            this.BtnDarDeBajaDistrito.Click += new System.EventHandler(this.BtnDarDeBajaDistrito_Click);
            // 
            // BtnModificarDistrito
            // 
            this.BtnModificarDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificarDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarDistrito.Image")));
            this.BtnModificarDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarDistrito.Location = new System.Drawing.Point(121, 399);
            this.BtnModificarDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnModificarDistrito.Name = "BtnModificarDistrito";
            this.BtnModificarDistrito.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnModificarDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnModificarDistrito.TabIndex = 3;
            this.BtnModificarDistrito.Text = "Modificar";
            this.BtnModificarDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarDistrito.UseVisualStyleBackColor = true;
            this.BtnModificarDistrito.Click += new System.EventHandler(this.BtnModificarDistrito_Click);
            // 
            // BtnListarDistritos
            // 
            this.BtnListarDistritos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarDistritos.Image = ((System.Drawing.Image)(resources.GetObject("BtnListarDistritos.Image")));
            this.BtnListarDistritos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarDistritos.Location = new System.Drawing.Point(404, 16);
            this.BtnListarDistritos.Margin = new System.Windows.Forms.Padding(2);
            this.BtnListarDistritos.Name = "BtnListarDistritos";
            this.BtnListarDistritos.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListarDistritos.Size = new System.Drawing.Size(102, 40);
            this.BtnListarDistritos.TabIndex = 0;
            this.BtnListarDistritos.Text = "Listar";
            this.BtnListarDistritos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListarDistritos.UseVisualStyleBackColor = true;
            this.BtnListarDistritos.Click += new System.EventHandler(this.BtnListarDistritos_Click);
            // 
            // BtnNuevoDistrito
            // 
            this.BtnNuevoDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevoDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevoDistrito.Image")));
            this.BtnNuevoDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevoDistrito.Location = new System.Drawing.Point(15, 399);
            this.BtnNuevoDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnNuevoDistrito.Name = "BtnNuevoDistrito";
            this.BtnNuevoDistrito.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnNuevoDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnNuevoDistrito.TabIndex = 2;
            this.BtnNuevoDistrito.Text = "Nuevo";
            this.BtnNuevoDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevoDistrito.UseVisualStyleBackColor = true;
            this.BtnNuevoDistrito.Click += new System.EventHandler(this.BtnNuevoDistrito_Click);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cdDistrito});
            this.DgvListado.Location = new System.Drawing.Point(15, 60);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(491, 328);
            this.DgvListado.TabIndex = 1;
            // 
            // cdDistrito
            // 
            this.cdDistrito.DataPropertyName = "DistritoNombre";
            this.cdDistrito.HeaderText = "Distrito";
            this.cdDistrito.Name = "cdDistrito";
            this.cdDistrito.ReadOnly = true;
            // 
            // BtnCerrarDistrito
            // 
            this.BtnCerrarDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarDistrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarDistrito.Image")));
            this.BtnCerrarDistrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarDistrito.Location = new System.Drawing.Point(747, 461);
            this.BtnCerrarDistrito.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCerrarDistrito.Name = "BtnCerrarDistrito";
            this.BtnCerrarDistrito.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrarDistrito.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrarDistrito.TabIndex = 2;
            this.BtnCerrarDistrito.Text = "Cerrar";
            this.BtnCerrarDistrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarDistrito.UseVisualStyleBackColor = true;
            this.BtnCerrarDistrito.Click += new System.EventHandler(this.BtnCerrarDistrito_Click);
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmDistrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.BtnCerrarDistrito);
            this.Controls.Add(this.GbListadoDistritos);
            this.Controls.Add(this.GbDistrito);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmDistrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Distritos";
            this.GbDistrito.ResumeLayout(false);
            this.GbDistrito.PerformLayout();
            this.GbListadoDistritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbDistrito;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombreDistrito;
        private System.Windows.Forms.Button BtnCancelarDistrito;
        private System.Windows.Forms.Button BtnAceptarDistrito;
        private System.Windows.Forms.GroupBox GbListadoDistritos;
        private System.Windows.Forms.Button BtnListarDistritos;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnModificarDistrito;
        private System.Windows.Forms.Button BtnNuevoDistrito;
        private System.Windows.Forms.Button BtnDarDeBajaDistrito;
        private System.Windows.Forms.Button BtnCerrarDistrito;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.TextBox TxtDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtProvincia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDistrito;
    }
}