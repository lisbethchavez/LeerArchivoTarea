
namespace tareaAbirArchivo
{
    partial class frmBuscar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lstArchivos = new System.Windows.Forms.ListBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CARGAR";
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.Location = new System.Drawing.Point(95, 26);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(311, 20);
            this.txtCarpeta.TabIndex = 1;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(432, 25);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(95, 20);
            this.btnCargar.TabIndex = 2;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lstArchivos
            // 
            this.lstArchivos.FormattingEnabled = true;
            this.lstArchivos.Location = new System.Drawing.Point(24, 77);
            this.lstArchivos.Name = "lstArchivos";
            this.lstArchivos.ScrollAlwaysVisible = true;
            this.lstArchivos.Size = new System.Drawing.Size(306, 212);
            this.lstArchivos.TabIndex = 3;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(373, 81);
            this.txtContenido.Multiline = true;
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContenido.Size = new System.Drawing.Size(384, 208);
            this.txtContenido.TabIndex = 4;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(567, 25);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(95, 23);
            this.btnLeer.TabIndex = 6;
            this.btnLeer.Text = "LEER";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 395);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtContenido);
            this.Controls.Add(this.lstArchivos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtCarpeta);
            this.Controls.Add(this.label1);
            this.Name = "frmBuscar";
            this.Text = "BUSCAR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.ListBox lstArchivos;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Button btnLeer;
    }
}

