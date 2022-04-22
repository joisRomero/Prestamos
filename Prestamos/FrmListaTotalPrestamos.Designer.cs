namespace Prestamos
{
    partial class FrmListaTotalPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaTotalPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.CdNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdMontoPrestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdMontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(743, 12);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
            this.BtnListar.TabIndex = 1;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
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
            this.CdNombres,
            this.CdFecha,
            this.CdMontoPrestado,
            this.CdMontoPagado});
            this.DgvListado.Location = new System.Drawing.Point(12, 57);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(833, 360);
            this.DgvListado.TabIndex = 6;
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarExcel.Image")));
            this.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportarExcel.Location = new System.Drawing.Point(635, 432);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(102, 40);
            this.BtnExportarExcel.TabIndex = 7;
            this.BtnExportarExcel.Text = "Exportar";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(743, 432);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrrar.TabIndex = 8;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // Notificacion
            // 
            this.Notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion.Icon")));
            this.Notificacion.Text = "Gestión de préstamos";
            this.Notificacion.Visible = true;
            this.Notificacion.BalloonTipClicked += new System.EventHandler(this.Notificacion_BalloonTipClicked);
            this.Notificacion.BalloonTipClosed += new System.EventHandler(this.Notificacion_BalloonTipClosed);
            // 
            // CdNombres
            // 
            this.CdNombres.DataPropertyName = "Nombres";
            this.CdNombres.HeaderText = "Nombres";
            this.CdNombres.Name = "CdNombres";
            this.CdNombres.ReadOnly = true;
            // 
            // CdFecha
            // 
            this.CdFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // CdMontoPrestado
            // 
            this.CdMontoPrestado.DataPropertyName = "MontoPrestado";
            dataGridViewCellStyle2.Format = "N2";
            this.CdMontoPrestado.DefaultCellStyle = dataGridViewCellStyle2;
            this.CdMontoPrestado.HeaderText = "Monto Prestado";
            this.CdMontoPrestado.Name = "CdMontoPrestado";
            this.CdMontoPrestado.ReadOnly = true;
            // 
            // CdMontoPagado
            // 
            this.CdMontoPagado.DataPropertyName = "MontoPagado";
            this.CdMontoPagado.HeaderText = "Monto Pagado";
            this.CdMontoPagado.Name = "CdMontoPagado";
            this.CdMontoPagado.ReadOnly = true;
            // 
            // FrmListaTotalPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 484);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnListar);
            this.Name = "FrmListaTotalPrestamos";
            this.Text = "Lista Total de Préstamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaTotalPrestamos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdMontoPrestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdMontoPagado;
    }
}