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
            this.txtIDesc = new System.Windows.Forms.TextBox();
            this.lblBarraAzul = new System.Windows.Forms.Label();
            this.txtNomRec = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.txtIngre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelinfoRece.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelinfoRece.Controls.Add(this.txtIDesc);
            this.panelinfoRece.Controls.Add(this.lblBarraAzul);
            this.panelinfoRece.Controls.Add(this.txtNomRec);
            this.panelinfoRece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelinfoRece.Location = new System.Drawing.Point(0, 55);
            this.panelinfoRece.Name = "panelinfoRece";
            this.panelinfoRece.Size = new System.Drawing.Size(958, 193);
            this.panelinfoRece.TabIndex = 5;
            // 
            // txtIDesc
            // 
            this.txtIDesc.BackColor = System.Drawing.Color.Black;
            this.txtIDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDesc.ForeColor = System.Drawing.Color.Gray;
            this.txtIDesc.Location = new System.Drawing.Point(437, 75);
            this.txtIDesc.Multiline = true;
            this.txtIDesc.Name = "txtIDesc";
            this.txtIDesc.Size = new System.Drawing.Size(200, 91);
            this.txtIDesc.TabIndex = 4;
            this.txtIDesc.Text = "Platica un poco sobre tu receta";
            this.txtIDesc.Enter += new System.EventHandler(this.txtIDesc_Enter);
            this.txtIDesc.Leave += new System.EventHandler(this.txtIDesc_Leave);
            // 
            // lblBarraAzul
            // 
            this.lblBarraAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBarraAzul.Location = new System.Drawing.Point(180, 48);
            this.lblBarraAzul.Name = "lblBarraAzul";
            this.lblBarraAzul.Size = new System.Drawing.Size(199, 2);
            this.lblBarraAzul.TabIndex = 3;
            // 
            // txtNomRec
            // 
            this.txtNomRec.BackColor = System.Drawing.Color.Black;
            this.txtNomRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRec.ForeColor = System.Drawing.SystemColors.Info;
            this.txtNomRec.Location = new System.Drawing.Point(179, 31);
            this.txtNomRec.Name = "txtNomRec";
            this.txtNomRec.Size = new System.Drawing.Size(190, 17);
            this.txtNomRec.TabIndex = 1;
            this.txtNomRec.Text = "Escribe el nombre aquí";
            this.txtNomRec.Enter += new System.EventHandler(this.txtNomRec_Enter);
            this.txtNomRec.Leave += new System.EventHandler(this.txtNomRec_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.lblIngrediente);
            this.panel2.Controls.Add(this.txtIngre);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 193);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(58, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 2);
            this.label1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(363, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Insertar ingrediente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.Location = new System.Drawing.Point(57, 15);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(114, 24);
            this.lblIngrediente.TabIndex = 5;
            this.lblIngrediente.Text = "Ingredientes";
            // 
            // txtIngre
            // 
            this.txtIngre.BackColor = System.Drawing.Color.Black;
            this.txtIngre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngre.ForeColor = System.Drawing.Color.White;
            this.txtIngre.Location = new System.Drawing.Point(61, 51);
            this.txtIngre.Multiline = true;
            this.txtIngre.Name = "txtIngre";
            this.txtIngre.Size = new System.Drawing.Size(204, 24);
            this.txtIngre.TabIndex = 4;
            this.txtIngre.Text = "Escribe los ingredientes a utilizar";
            this.txtIngre.Enter += new System.EventHandler(this.txtIngre_Enter);
            this.txtIngre.Leave += new System.EventHandler(this.txtIngre_Leave);
            // 
            // SubirReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubRec;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelinfoRece;
        private System.Windows.Forms.Label lblBarraAzul;
        private System.Windows.Forms.TextBox txtNomRec;
        private System.Windows.Forms.TextBox txtIDesc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.TextBox txtIngre;
    }
}
