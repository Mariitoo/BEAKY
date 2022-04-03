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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelinfoRece = new System.Windows.Forms.Panel();
            this.txtNomRec = new System.Windows.Forms.TextBox();
            this.lblBarraAzul = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panelinfoRece.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblSubRec);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 49);
            this.panel1.TabIndex = 0;
            // 
            // lblSubRec
            // 
            this.lblSubRec.AutoSize = true;
            this.lblSubRec.BackColor = System.Drawing.Color.Transparent;
            this.lblSubRec.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubRec.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSubRec.Location = new System.Drawing.Point(217, 9);
            this.lblSubRec.Name = "lblSubRec";
            this.lblSubRec.Size = new System.Drawing.Size(281, 24);
            this.lblSubRec.TabIndex = 0;
            this.lblSubRec.Text = "COMPARTE TU RECETA";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(83, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // panelinfoRece
            // 
            this.panelinfoRece.BackColor = System.Drawing.Color.Black;
            this.panelinfoRece.Controls.Add(this.richTextBox1);
            this.panelinfoRece.Controls.Add(this.lblBarraAzul);
            this.panelinfoRece.Controls.Add(this.txtNomRec);
            this.panelinfoRece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelinfoRece.Location = new System.Drawing.Point(0, 55);
            this.panelinfoRece.Name = "panelinfoRece";
            this.panelinfoRece.Size = new System.Drawing.Size(958, 193);
            this.panelinfoRece.TabIndex = 5;
            // 
            // txtNomRec
            // 
            this.txtNomRec.BackColor = System.Drawing.Color.Black;
            this.txtNomRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomRec.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNomRec.Location = new System.Drawing.Point(179, 31);
            this.txtNomRec.Name = "txtNomRec";
            this.txtNomRec.Size = new System.Drawing.Size(190, 13);
            this.txtNomRec.TabIndex = 1;
            this.txtNomRec.Text = "Escribe el nombre aquí";
            // 
            // lblBarraAzul
            // 
            this.lblBarraAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBarraAzul.Location = new System.Drawing.Point(180, 48);
            this.lblBarraAzul.Name = "lblBarraAzul";
            this.lblBarraAzul.Size = new System.Drawing.Size(199, 2);
            this.lblBarraAzul.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox1.Location = new System.Drawing.Point(345, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(183, 96);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "Platica un poco sobre tu receta";
            // 
            // SubirReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelinfoRece);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "SubirReceta";
            this.Size = new System.Drawing.Size(958, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelinfoRece.ResumeLayout(false);
            this.panelinfoRece.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubRec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelinfoRece;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblBarraAzul;
        private System.Windows.Forms.TextBox txtNomRec;
    }
}
