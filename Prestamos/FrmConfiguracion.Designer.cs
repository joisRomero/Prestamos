
namespace Prestamos
{
    partial class FrmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfiguracion));
            this.label1 = new System.Windows.Forms.Label();
            this.CboBarraMenu = new System.Windows.Forms.ComboBox();
            this.ChkAgregarBarraHerramienta = new System.Windows.Forms.CheckBox();
            this.BtnAplicar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barra de menú";
            // 
            // CboBarraMenu
            // 
            this.CboBarraMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboBarraMenu.FormattingEnabled = true;
            this.CboBarraMenu.Items.AddRange(new object[] {
            "Predeterminado",
            "Ribbon"});
            this.CboBarraMenu.Location = new System.Drawing.Point(92, 12);
            this.CboBarraMenu.Name = "CboBarraMenu";
            this.CboBarraMenu.Size = new System.Drawing.Size(121, 21);
            this.CboBarraMenu.TabIndex = 1;
            this.CboBarraMenu.SelectedIndexChanged += new System.EventHandler(this.CboBarraMenu_SelectedIndexChanged);
            // 
            // ChkAgregarBarraHerramienta
            // 
            this.ChkAgregarBarraHerramienta.AutoSize = true;
            this.ChkAgregarBarraHerramienta.Location = new System.Drawing.Point(13, 50);
            this.ChkAgregarBarraHerramienta.Name = "ChkAgregarBarraHerramienta";
            this.ChkAgregarBarraHerramienta.Size = new System.Drawing.Size(168, 17);
            this.ChkAgregarBarraHerramienta.TabIndex = 3;
            this.ChkAgregarBarraHerramienta.Text = "Agregar barra de herramientas";
            this.ChkAgregarBarraHerramienta.UseVisualStyleBackColor = true;
            // 
            // BtnAplicar
            // 
            this.BtnAplicar.Location = new System.Drawing.Point(29, 114);
            this.BtnAplicar.Name = "BtnAplicar";
            this.BtnAplicar.Size = new System.Drawing.Size(89, 31);
            this.BtnAplicar.TabIndex = 4;
            this.BtnAplicar.Text = "Aplicar";
            this.BtnAplicar.UseVisualStyleBackColor = true;
            this.BtnAplicar.Click += new System.EventHandler(this.BtnAplicar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(122, 114);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(89, 31);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 157);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAplicar);
            this.Controls.Add(this.ChkAgregarBarraHerramienta);
            this.Controls.Add(this.CboBarraMenu);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfiguracion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboBarraMenu;
        private System.Windows.Forms.CheckBox ChkAgregarBarraHerramienta;
        private System.Windows.Forms.Button BtnAplicar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}