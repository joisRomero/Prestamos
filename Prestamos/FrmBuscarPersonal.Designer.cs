
namespace Prestamos
{
    partial class FrmBuscarPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuscarPersonal));
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCorreoLaboral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.TxtPersonal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
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
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
            this.cdDNI,
            this.cdDireccion,
            this.cdCorreo,
            this.cdCorreoLaboral,
            this.cdCelular});
            this.DgvListado.Location = new System.Drawing.Point(11, 57);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(586, 365);
            this.DgvListado.TabIndex = 0;
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombres";
            this.cdNombre.HeaderText = "Nombres";
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            this.cdNombre.Width = 74;
            // 
            // cdApellidos
            // 
            this.cdApellidos.DataPropertyName = "Apellidos";
            this.cdApellidos.HeaderText = "Apellidos";
            this.cdApellidos.Name = "cdApellidos";
            this.cdApellidos.ReadOnly = true;
            this.cdApellidos.Width = 74;
            // 
            // cdDNI
            // 
            this.cdDNI.DataPropertyName = "DNI";
            this.cdDNI.HeaderText = "DNI";
            this.cdDNI.Name = "cdDNI";
            this.cdDNI.ReadOnly = true;
            this.cdDNI.Width = 51;
            // 
            // cdDireccion
            // 
            this.cdDireccion.DataPropertyName = "Direccion";
            this.cdDireccion.HeaderText = "Dirección";
            this.cdDireccion.Name = "cdDireccion";
            this.cdDireccion.ReadOnly = true;
            this.cdDireccion.Width = 77;
            // 
            // cdCorreo
            // 
            this.cdCorreo.DataPropertyName = "CorreoPersonal";
            this.cdCorreo.HeaderText = "Correo personal";
            this.cdCorreo.Name = "cdCorreo";
            this.cdCorreo.ReadOnly = true;
            this.cdCorreo.Width = 97;
            // 
            // cdCorreoLaboral
            // 
            this.cdCorreoLaboral.DataPropertyName = "CorreoLaboral";
            this.cdCorreoLaboral.HeaderText = "Correo laboral";
            this.cdCorreoLaboral.Name = "cdCorreoLaboral";
            this.cdCorreoLaboral.ReadOnly = true;
            this.cdCorreoLaboral.Width = 89;
            // 
            // cdCelular
            // 
            this.cdCelular.DataPropertyName = "Celular";
            this.cdCelular.HeaderText = "Celular";
            this.cdCelular.Name = "cdCelular";
            this.cdCelular.ReadOnly = true;
            this.cdCelular.Width = 64;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(494, 12);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
            this.BtnListar.TabIndex = 3;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSeleccionar.Image")));
            this.BtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeleccionar.Location = new System.Drawing.Point(387, 428);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnSeleccionar.Size = new System.Drawing.Size(102, 40);
            this.BtnSeleccionar.TabIndex = 1;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // TxtPersonal
            // 
            this.TxtPersonal.Location = new System.Drawing.Point(82, 23);
            this.TxtPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPersonal.Name = "TxtPersonal";
            this.TxtPersonal.Size = new System.Drawing.Size(367, 20);
            this.TxtPersonal.TabIndex = 2;
            this.TxtPersonal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPersonal_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Personal";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelar.Image")));
            this.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelar.Location = new System.Drawing.Point(494, 428);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancelar.Size = new System.Drawing.Size(102, 40);
            this.BtnCancelar.TabIndex = 20;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmBuscarPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 479);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtPersonal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBuscarPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar personal";
            this.Load += new System.EventHandler(this.FrmBuscarPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCorreoLaboral;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdCelular;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtPersonal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnCancelar;
    }
}