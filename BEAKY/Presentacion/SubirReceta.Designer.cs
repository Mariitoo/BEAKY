namespace BEAKY.Presentacion
{
    partial class SubirReceta
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubRec = new System.Windows.Forms.Label();
            this.txtNomRec = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lblSubRec);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 49);
            this.panel1.TabIndex = 0;
            // 
            // lblSubRec
            // 
            this.lblSubRec.AutoSize = true;
            this.lblSubRec.BackColor = System.Drawing.Color.Transparent;
            this.lblSubRec.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubRec.Location = new System.Drawing.Point(73, 10);
            this.lblSubRec.Name = "lblSubRec";
            this.lblSubRec.Size = new System.Drawing.Size(252, 24);
            this.lblSubRec.TabIndex = 0;
            this.lblSubRec.Text = "SUBIR UNA RECETA";
            // 
            // txtNomRec
            // 
            this.txtNomRec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNomRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomRec.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomRec.Location = new System.Drawing.Point(101, 80);
            this.txtNomRec.Name = "txtNomRec";
            this.txtNomRec.Size = new System.Drawing.Size(160, 13);
            this.txtNomRec.TabIndex = 1;
            this.txtNomRec.Text = "Escribe el nombre aquí";
            // 
            // SubirReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.txtNomRec);
            this.Controls.Add(this.panel1);
            this.Name = "SubirReceta";
            this.Size = new System.Drawing.Size(660, 527);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubRec;
        private System.Windows.Forms.TextBox txtNomRec;
    }
}
