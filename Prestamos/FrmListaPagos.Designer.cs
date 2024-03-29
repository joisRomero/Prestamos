﻿
namespace Prestamos
{
    partial class FrmListaPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListaPagos));
            this.BtnExportarExcel = new System.Windows.Forms.Button();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.BtnCerrrar = new System.Windows.Forms.Button();
            this.BtnListar = new System.Windows.Forms.Button();
            this.GuardarArchivoDialogo = new System.Windows.Forms.SaveFileDialog();
            this.Notificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.cdNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdMontoPagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnExportarExcel
            // 
            this.BtnExportarExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("BtnExportarExcel.Image")));
            this.BtnExportarExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExportarExcel.Location = new System.Drawing.Point(772, 553);
            this.BtnExportarExcel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnExportarExcel.Name = "BtnExportarExcel";
            this.BtnExportarExcel.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.BtnExportarExcel.Size = new System.Drawing.Size(136, 49);
            this.BtnExportarExcel.TabIndex = 7;
            this.BtnExportarExcel.Text = "Exportar";
            this.BtnExportarExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnExportarExcel.UseVisualStyleBackColor = true;
            this.BtnExportarExcel.Click += new System.EventHandler(this.BtnExportarExcel_Click);
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
            this.cdNombreCliente,
            this.cdFecha,
            this.cdMontoPagado,
            this.cdFormaPago});
            this.DgvListado.Location = new System.Drawing.Point(16, 94);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DgvListado.MultiSelect = false;
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowHeadersVisible = false;
            this.DgvListado.RowHeadersWidth = 51;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(1036, 438);
            this.DgvListado.TabIndex = 9;
            // 
            // BtnCerrrar
            // 
            this.BtnCerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrrar.Image")));
            this.BtnCerrrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCerrrar.Location = new System.Drawing.Point(916, 553);
            this.BtnCerrrar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCerrrar.Name = "BtnCerrrar";
            this.BtnCerrrar.Padding = new System.Windows.Forms.Padding(13, 0, 13, 0);
            this.BtnCerrrar.Size = new System.Drawing.Size(136, 49);
            this.BtnCerrrar.TabIndex = 8;
            this.BtnCerrrar.Text = "Cerrar";
            this.BtnCerrrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCerrrar.UseVisualStyleBackColor = true;
            // 
            // BtnListar
            // 
            this.BtnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListar.Image = ((System.Drawing.Image)(resources.GetObject("BtnListar.Image")));
            this.BtnListar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnListar.Location = new System.Drawing.Point(916, 25);
            this.BtnListar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListar.Name = "BtnListar";
            this.BtnListar.Padding = new System.Windows.Forms.Padding(13, 0, 20, 0);
            this.BtnListar.Size = new System.Drawing.Size(136, 49);
            this.BtnListar.TabIndex = 6;
            this.BtnListar.Text = "Listar";
            this.BtnListar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnListar.UseVisualStyleBackColor = true;
            this.BtnListar.Click += new System.EventHandler(this.BtnListar_Click);
            // 
            // Notificacion
            // 
            this.Notificacion.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Notificacion.Icon = ((System.Drawing.Icon)(resources.GetObject("Notificacion.Icon")));
            this.Notificacion.Text = "Gestión de Préstamos";
            this.Notificacion.Visible = true;
            this.Notificacion.BalloonTipClicked += new System.EventHandler(this.Notificacion_BalloonTipClicked);
            this.Notificacion.BalloonTipClosed += new System.EventHandler(this.Notificacion_BalloonTipClosed);
            // 
            // cdNombreCliente
            // 
            this.cdNombreCliente.DataPropertyName = "NombreCliente";
            this.cdNombreCliente.HeaderText = "Cliente";
            this.cdNombreCliente.MinimumWidth = 6;
            this.cdNombreCliente.Name = "cdNombreCliente";
            this.cdNombreCliente.ReadOnly = true;
            // 
            // cdFecha
            // 
            this.cdFecha.DataPropertyName = "Fecha";
            this.cdFecha.HeaderText = "Fecha";
            this.cdFecha.MinimumWidth = 6;
            this.cdFecha.Name = "cdFecha";
            this.cdFecha.ReadOnly = true;
            // 
            // cdMontoPagado
            // 
            this.cdMontoPagado.DataPropertyName = "MontoPagado";
            this.cdMontoPagado.HeaderText = "Monto Pagado";
            this.cdMontoPagado.MinimumWidth = 6;
            this.cdMontoPagado.Name = "cdMontoPagado";
            this.cdMontoPagado.ReadOnly = true;
            // 
            // cdFormaPago
            // 
            this.cdFormaPago.DataPropertyName = "FormaPago";
            this.cdFormaPago.HeaderText = "Forma Pago";
            this.cdFormaPago.MinimumWidth = 6;
            this.cdFormaPago.Name = "cdFormaPago";
            this.cdFormaPago.ReadOnly = true;
            // 
            // FrmListaPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 627);
            this.Controls.Add(this.BtnExportarExcel);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.BtnCerrrar);
            this.Controls.Add(this.BtnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListaPagos";
            this.Text = "Lista Pagos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListaPagos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExportarExcel;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.Button BtnCerrrar;
        private System.Windows.Forms.Button BtnListar;
        private System.Windows.Forms.SaveFileDialog GuardarArchivoDialogo;
        private System.Windows.Forms.NotifyIcon Notificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdMontoPagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdFormaPago;
    }
}