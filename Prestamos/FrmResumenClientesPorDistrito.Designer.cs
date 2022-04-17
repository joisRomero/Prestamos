
namespace Prestamos
{
    partial class FrmResumenClientesPorDistrito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmResumenClientesPorDistrito));
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.CdDistrito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCantidadEmpresas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdCantidadPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
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
            this.DgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvListado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdDistrito,
            this.CdCantidadEmpresas,
            this.CdCantidadPersonas,
            this.CdTotal});
            this.DgvListado.Location = new System.Drawing.Point(12, 68);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(777, 356);
            this.DgvListado.TabIndex = 8;
            // 
            // CdDistrito
            // 
            this.CdDistrito.DataPropertyName = "Distrito";
            this.CdDistrito.HeaderText = "Distrito";
            this.CdDistrito.Name = "CdDistrito";
            this.CdDistrito.ReadOnly = true;
            // 
            // CdCantidadEmpresas
            // 
            this.CdCantidadEmpresas.DataPropertyName = "CantidadEmpresas";
            this.CdCantidadEmpresas.HeaderText = "Cantidad de empresas";
            this.CdCantidadEmpresas.Name = "CdCantidadEmpresas";
            this.CdCantidadEmpresas.ReadOnly = true;
            // 
            // CdCantidadPersonas
            // 
            this.CdCantidadPersonas.DataPropertyName = "CantidadPersonas";
            this.CdCantidadPersonas.HeaderText = "Cantidad de personas";
            this.CdCantidadPersonas.Name = "CdCantidadPersonas";
            this.CdCantidadPersonas.ReadOnly = true;
            // 
            // CdTotal
            // 
            this.CdTotal.DataPropertyName = "CantidadTotal";
            this.CdTotal.HeaderText = "Total";
            this.CdTotal.Name = "CdTotal";
            this.CdTotal.ReadOnly = true;
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(687, 441);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(102, 40);
            this.BtnCerrrar.TabIndex = 7;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(687, 12);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.BtnListar.Size = new System.Drawing.Size(102, 40);
            this.BtnListar.TabIndex = 6;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarExcel.Image")));
            this.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportarExcel.Location = new System.Drawing.Point(579, 441);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(102, 40);
            this.BtnExportarExcel.TabIndex = 7;
            this.BtnExportarExcel.Text = "Exportar";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
            // 
            // Notificacion
            // 
            this.Notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion.Icon")));
            this.Notificacion.Text = "Gestión de préstamos";
            this.Notificacion.BalloonTipClicked += new System.EventHandler(this.Notificacion_BalloonTipClicked);
            this.Notificacion.BalloonTipClosed += new System.EventHandler(this.Notificacion_BalloonTipClosed);
            // 
            // FrmResumenClientesPorDistrito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.BtnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmResumenClientesPorDistrito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resumen de clientes por distrito";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmResumenClientesPorDistrito_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdDistrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCantidadEmpresas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCantidadPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdTotal;
        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
        private System.Windows.Forms.NotifyIcon Notificacion;
    }
}