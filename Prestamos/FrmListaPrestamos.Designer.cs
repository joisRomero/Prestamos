
namespace Prestamos
{
    partial class FrmListaPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPrestamos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.cdTipoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdMontoPrestado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdPeriodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCantidadCuotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(915, 543);
            this.BtnCerrrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(136, 49);
            this.BtnCerrrar.TabIndex = 2;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            this.BtnCerrrar.Click += new System.EventHandler(this.BtnCerrrar_Click);
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(915, 15);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(13, 0, 20, 0);
            this.BtnListar.Size = new System.Drawing.Size(136, 49);
            this.BtnListar.TabIndex = 0;
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
            this.cdTipoC,
            this.cdNombre,
            this.CdFecha,
            this.CdMontoPrestado,
            this.Interes,
            this.CdPeriodo,
            this.CdCantidadCuotas});
            this.DgvListado.Location = new System.Drawing.Point(15, 84);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1036, 438);
            this.DgvListado.TabIndex = 5;
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarExcel.Image")));
            this.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportarExcel.Location = new System.Drawing.Point(771, 543);
            this.BtnExportarExcel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(136, 49);
            this.BtnExportarExcel.TabIndex = 1;
            this.BtnExportarExcel.Text = "Exportar";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
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
            // cdTipoC
            // 
            this.cdTipoC.DataPropertyName = "TipoCliente";
            this.cdTipoC.HeaderText = "Tipo Cliente";
            this.cdTipoC.MinimumWidth = 6;
            this.cdTipoC.Name = "cdTipoC";
            this.cdTipoC.ReadOnly = true;
            // 
            // cdNombre
            // 
            this.cdNombre.DataPropertyName = "Nombre";
            this.cdNombre.HeaderText = "Nombre";
            this.cdNombre.MinimumWidth = 6;
            this.cdNombre.Name = "cdNombre";
            this.cdNombre.ReadOnly = true;
            // 
            // CdFecha
            // 
            this.CdFecha.DataPropertyName = "Fecha";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.CdFecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.CdFecha.HeaderText = "Fecha";
            this.CdFecha.MinimumWidth = 6;
            this.CdFecha.Name = "CdFecha";
            this.CdFecha.ReadOnly = true;
            // 
            // CdMontoPrestado
            // 
            this.CdMontoPrestado.DataPropertyName = "MontoPrestado";
            dataGridViewCellStyle2.Format = "N2";
            this.CdMontoPrestado.DefaultCellStyle = dataGridViewCellStyle2;
            this.CdMontoPrestado.HeaderText = "Monto Prestado";
            this.CdMontoPrestado.MinimumWidth = 6;
            this.CdMontoPrestado.Name = "CdMontoPrestado";
            this.CdMontoPrestado.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "Interes";
            this.Interes.HeaderText = "Interes";
            this.Interes.MinimumWidth = 6;
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // CdPeriodo
            // 
            this.CdPeriodo.DataPropertyName = "Periodo";
            this.CdPeriodo.HeaderText = "Periodo";
            this.CdPeriodo.MinimumWidth = 6;
            this.CdPeriodo.Name = "CdPeriodo";
            this.CdPeriodo.ReadOnly = true;
            // 
            // CdCantidadCuotas
            // 
            this.CdCantidadCuotas.DataPropertyName = "CantidadCuotas";
            this.CdCantidadCuotas.HeaderText = "Cantidad de cuotas";
            this.CdCantidadCuotas.MinimumWidth = 6;
            this.CdCantidadCuotas.Name = "CdCantidadCuotas";
            this.CdCantidadCuotas.ReadOnly = true;
            // 
            // FrmListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.BtnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListaPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Préstamos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaPrestamos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdTipoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdMontoPrestado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdPeriodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCantidadCuotas;
    }
}