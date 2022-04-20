
namespace Prestamos
{
    partial class FrmEntidadBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntidadBancaria));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GbEntidadBancaria = new System.Windows.Forms.GroupBox();
            this.BtnCancelarEntidadB = new System.Windows.Forms.Button();
            this.BtnAceptarEntidadB = new System.Windows.Forms.Button();
            this.ChkVigente = new System.Windows.Forms.CheckBox();
            this.TxtSiglas = new System.Windows.Forms.TextBox();
            this.LblSiglas = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.LblNombreEntidadBancaria = new System.Windows.Forms.Label();
            this.BtnCerrarEntidadB = new System.Windows.Forms.Button();
            this.GbListadoEntidadesB = new System.Windows.Forms.GroupBox();
            this.BtnDarDeBajaEntidad = new System.Windows.Forms.Button();
            this.BtnModificarEntidad = new System.Windows.Forms.Button();
            this.BtnListarEntidadesB = new System.Windows.Forms.Button();
            this.BtnNuevaEntidadB = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.cdEntidadesB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrNotificador = new System.Windows.Forms.ErrorProvider(this.components);
            this.GbEntidadBancaria.SuspendLayout();
            this.GbListadoEntidadesB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).BeginInit();
            this.SuspendLayout();
            // 
            // GbEntidadBancaria
            // 
            this.GbEntidadBancaria.Controls.Add(this.BtnCancelarEntidadB);
            this.GbEntidadBancaria.Controls.Add(this.BtnAceptarEntidadB);
            this.GbEntidadBancaria.Controls.Add(this.ChkVigente);
            this.GbEntidadBancaria.Controls.Add(this.TxtSiglas);
            this.GbEntidadBancaria.Controls.Add(this.LblSiglas);
            this.GbEntidadBancaria.Controls.Add(this.TxtNombre);
            this.GbEntidadBancaria.Controls.Add(this.LblNombreEntidadBancaria);
            this.GbEntidadBancaria.Enabled = false;
            this.GbEntidadBancaria.Location = new System.Drawing.Point(12, 11);
            this.GbEntidadBancaria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbEntidadBancaria.Name = "GbEntidadBancaria";
            this.GbEntidadBancaria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbEntidadBancaria.Size = new System.Drawing.Size(412, 242);
            this.GbEntidadBancaria.TabIndex = 1;
            this.GbEntidadBancaria.TabStop = false;
            this.GbEntidadBancaria.Text = "Entidad Bancaria";
            // 
            // BtnCancelarEntidadB
            // 
            this.BtnCancelarEntidadB.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancelarEntidadB.Image")));
            this.BtnCancelarEntidadB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarEntidadB.Location = new System.Drawing.Point(256, 175);
            this.BtnCancelarEntidadB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelarEntidadB.Name = "BtnCancelarEntidadB";
            this.BtnCancelarEntidadB.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnCancelarEntidadB.Size = new System.Drawing.Size(136, 49);
            this.BtnCancelarEntidadB.TabIndex = 5;
            this.BtnCancelarEntidadB.Text = "Cancelar";
            this.BtnCancelarEntidadB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCancelarEntidadB.UseVisualStyleBackColor = true;
            this.BtnCancelarEntidadB.Click += new System.EventHandler(this.BtnCancelarEntidadB_Click);
            // 
            // BtnAceptarEntidadB
            // 
            this.BtnAceptarEntidadB.Image = ((System.Drawing.Image)(resources.GetObject("BtnAceptarEntidadB.Image")));
            this.BtnAceptarEntidadB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAceptarEntidadB.Location = new System.Drawing.Point(112, 175);
            this.BtnAceptarEntidadB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAceptarEntidadB.Name = "BtnAceptarEntidadB";
            this.BtnAceptarEntidadB.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnAceptarEntidadB.Size = new System.Drawing.Size(136, 49);
            this.BtnAceptarEntidadB.TabIndex = 4;
            this.BtnAceptarEntidadB.Text = "Aceptar";
            this.BtnAceptarEntidadB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptarEntidadB.UseVisualStyleBackColor = true;
            this.BtnAceptarEntidadB.Click += new System.EventHandler(this.BtnAceptarEntidadB_Click);
            // 
            // ChkVigente
            // 
            this.ChkVigente.AutoSize = true;
            this.ChkVigente.Location = new System.Drawing.Point(112, 122);
            this.ChkVigente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ChkVigente.Name = "ChkVigente";
            this.ChkVigente.Size = new System.Drawing.Size(78, 21);
            this.ChkVigente.TabIndex = 3;
            this.ChkVigente.Text = "Vigente";
            this.ChkVigente.UseVisualStyleBackColor = true;
            // 
            // TxtSiglas
            // 
            this.TxtSiglas.Location = new System.Drawing.Point(112, 70);
            this.TxtSiglas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSiglas.Name = "TxtSiglas";
            this.TxtSiglas.Size = new System.Drawing.Size(279, 22);
            this.TxtSiglas.TabIndex = 1;
            this.TxtSiglas.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblSiglas
            // 
            this.LblSiglas.AutoSize = true;
            this.LblSiglas.Location = new System.Drawing.Point(8, 73);
            this.LblSiglas.Name = "LblSiglas";
            this.LblSiglas.Size = new System.Drawing.Size(46, 17);
            this.LblSiglas.TabIndex = 0;
            this.LblSiglas.Text = "Siglas";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(112, 33);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(279, 22);
            this.TxtNombre.TabIndex = 0;
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.Control_Validating);
            // 
            // LblNombreEntidadBancaria
            // 
            this.LblNombreEntidadBancaria.AutoSize = true;
            this.LblNombreEntidadBancaria.Location = new System.Drawing.Point(8, 36);
            this.LblNombreEntidadBancaria.Name = "LblNombreEntidadBancaria";
            this.LblNombreEntidadBancaria.Size = new System.Drawing.Size(58, 17);
            this.LblNombreEntidadBancaria.TabIndex = 0;
            this.LblNombreEntidadBancaria.Text = "Nombre";
            // 
            // BtnCerrarEntidadB
            // 
            this.BtnCerrarEntidadB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrarEntidadB.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrarEntidadB.Image")));
            this.BtnCerrarEntidadB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrarEntidadB.Location = new System.Drawing.Point(987, 566);
            this.BtnCerrarEntidadB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCerrarEntidadB.Name = "BtnCerrarEntidadB";
            this.BtnCerrarEntidadB.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnCerrarEntidadB.Size = new System.Drawing.Size(136, 49);
            this.BtnCerrarEntidadB.TabIndex = 4;
            this.BtnCerrarEntidadB.Text = "Cerrar";
            this.BtnCerrarEntidadB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrarEntidadB.UseVisualStyleBackColor = true;
            this.BtnCerrarEntidadB.Click += new System.EventHandler(this.BtnCerrarEntidadB_Click);
            // 
            // GbListadoEntidadesB
            // 
            this.GbListadoEntidadesB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbListadoEntidadesB.Controls.Add(this.BtnDarDeBajaEntidad);
            this.GbListadoEntidadesB.Controls.Add(this.BtnModificarEntidad);
            this.GbListadoEntidadesB.Controls.Add(this.BtnListarEntidadesB);
            this.GbListadoEntidadesB.Controls.Add(this.BtnNuevaEntidadB);
            this.GbListadoEntidadesB.Controls.Add(this.DgvListado);
            this.GbListadoEntidadesB.Location = new System.Drawing.Point(430, 11);
            this.GbListadoEntidadesB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbListadoEntidadesB.Name = "GbListadoEntidadesB";
            this.GbListadoEntidadesB.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GbListadoEntidadesB.Size = new System.Drawing.Size(693, 550);
            this.GbListadoEntidadesB.TabIndex = 3;
            this.GbListadoEntidadesB.TabStop = false;
            this.GbListadoEntidadesB.Text = "Listado Entidades Bancarias";
            // 
            // BtnDarDeBajaEntidad
            // 
            this.BtnDarDeBajaEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDarDeBajaEntidad.Image = ((System.Drawing.Image)(resources.GetObject("BtnDarDeBajaEntidad.Image")));
            this.BtnDarDeBajaEntidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDarDeBajaEntidad.Location = new System.Drawing.Point(539, 491);
            this.BtnDarDeBajaEntidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDarDeBajaEntidad.Name = "BtnDarDeBajaEntidad";
            this.BtnDarDeBajaEntidad.Size = new System.Drawing.Size(136, 49);
            this.BtnDarDeBajaEntidad.TabIndex = 4;
            this.BtnDarDeBajaEntidad.Text = "Dar de baja";
            this.BtnDarDeBajaEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDarDeBajaEntidad.UseVisualStyleBackColor = true;
            this.BtnDarDeBajaEntidad.Click += new System.EventHandler(this.BtnDarDeBajaEntidad_Click);
            // 
            // BtnModificarEntidad
            // 
            this.BtnModificarEntidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnModificarEntidad.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificarEntidad.Image")));
            this.BtnModificarEntidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarEntidad.Location = new System.Drawing.Point(161, 491);
            this.BtnModificarEntidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnModificarEntidad.Name = "BtnModificarEntidad";
            this.BtnModificarEntidad.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnModificarEntidad.Size = new System.Drawing.Size(136, 49);
            this.BtnModificarEntidad.TabIndex = 3;
            this.BtnModificarEntidad.Text = "Modificar";
            this.BtnModificarEntidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarEntidad.UseVisualStyleBackColor = true;
            this.BtnModificarEntidad.Click += new System.EventHandler(this.BtnModificarEntidad_Click);
            // 
            // BtnListarEntidadesB
            // 
            this.BtnListarEntidadesB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListarEntidadesB.Image = ((System.Drawing.Image)(resources.GetObject("BtnListarEntidadesB.Image")));
            this.BtnListarEntidadesB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListarEntidadesB.Location = new System.Drawing.Point(539, 20);
            this.BtnListarEntidadesB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnListarEntidadesB.Name = "BtnListarEntidadesB";
            this.BtnListarEntidadesB.Padding = new System.Windows.Forms.Padding(13, 0, 20, 0);
            this.BtnListarEntidadesB.Size = new System.Drawing.Size(136, 49);
            this.BtnListarEntidadesB.TabIndex = 0;
            this.BtnListarEntidadesB.Text = "Listar";
            this.BtnListarEntidadesB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListarEntidadesB.UseVisualStyleBackColor = true;
            this.BtnListarEntidadesB.Click += new System.EventHandler(this.BtnListarEntidadesB_Click);
            // 
            // BtnNuevaEntidadB
            // 
            this.BtnNuevaEntidadB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnNuevaEntidadB.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevaEntidadB.Image")));
            this.BtnNuevaEntidadB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNuevaEntidadB.Location = new System.Drawing.Point(20, 491);
            this.BtnNuevaEntidadB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnNuevaEntidadB.Name = "BtnNuevaEntidadB";
            this.BtnNuevaEntidadB.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnNuevaEntidadB.Size = new System.Drawing.Size(136, 49);
            this.BtnNuevaEntidadB.TabIndex = 2;
            this.BtnNuevaEntidadB.Text = "Nuevo";
            this.BtnNuevaEntidadB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNuevaEntidadB.UseVisualStyleBackColor = true;
            this.BtnNuevaEntidadB.Click += new System.EventHandler(this.BtnNuevaEntidadB_Click);
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
            this.cdEntidadesB});
            this.DgvListado.Location = new System.Drawing.Point(20, 74);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(655, 404);
            this.DgvListado.TabIndex = 1;
            // 
            // cdEntidadesB
            // 
            this.cdEntidadesB.DataPropertyName = "Nombre";
            this.cdEntidadesB.HeaderText = "Entidades Bancarias";
            this.cdEntidadesB.MinimumWidth = 6;
            this.cdEntidadesB.Name = "cdEntidadesB";
            this.cdEntidadesB.ReadOnly = true;
            // 
            // ErrNotificador
            // 
            this.ErrNotificador.ContainerControl = this;
            // 
            // FrmEntidadBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1144, 634);
            this.Controls.Add(this.BtnCerrarEntidadB);
            this.Controls.Add(this.GbListadoEntidadesB);
            this.Controls.Add(this.GbEntidadBancaria);
            this.Name = "FrmEntidadBancaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entidad Bancaria";
            this.GbEntidadBancaria.ResumeLayout(false);
            this.GbEntidadBancaria.PerformLayout();
            this.GbListadoEntidadesB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrNotificador)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GbEntidadBancaria;
        private System.Windows.Forms.Button BtnCancelarEntidadB;
        private System.Windows.Forms.Button BtnAceptarEntidadB;
        private System.Windows.Forms.CheckBox ChkVigente;
        private System.Windows.Forms.TextBox TxtSiglas;
        private System.Windows.Forms.Label LblSiglas;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label LblNombreEntidadBancaria;
        private System.Windows.Forms.Button BtnCerrarEntidadB;
        private System.Windows.Forms.GroupBox GbListadoEntidadesB;
        private System.Windows.Forms.Button BtnDarDeBajaEntidad;
        private System.Windows.Forms.Button BtnModificarEntidad;
        private System.Windows.Forms.Button BtnListarEntidadesB;
        private System.Windows.Forms.Button BtnNuevaEntidadB;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.ErrorProvider ErrNotificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdEntidadesB;
    }
}