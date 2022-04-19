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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubirReceta));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSubRec = new System.Windows.Forms.Label();
            this.panelinfoRece = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIDesc = new System.Windows.Forms.TextBox();
            this.lblBarraAzul = new System.Windows.Forms.Label();
            this.txtNomRec = new System.Windows.Forms.TextBox();
            this.txtIngre = new System.Windows.Forms.TextBox();
            this.lblIngrediente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelinfoRece.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
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
            this.lblSubRec.Location = new System.Drawing.Point(323, 9);
            this.lblSubRec.Name = "lblSubRec";
            this.lblSubRec.Size = new System.Drawing.Size(313, 24);
            this.lblSubRec.TabIndex = 0;
            this.lblSubRec.Text = "! COMPARTE TU RECETA !";
            this.lblSubRec.Click += new System.EventHandler(this.lblSubRec_Click);
            // 
            // panelinfoRece
            // 
            this.panelinfoRece.BackColor = System.Drawing.Color.White;
            this.panelinfoRece.Controls.Add(this.textBox1);
            this.panelinfoRece.Controls.Add(this.pictureBox1);
            this.panelinfoRece.Controls.Add(this.txtIDesc);
            this.panelinfoRece.Controls.Add(this.lblBarraAzul);
            this.panelinfoRece.Controls.Add(this.txtNomRec);
            this.panelinfoRece.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelinfoRece.Location = new System.Drawing.Point(0, 46);
            this.panelinfoRece.Name = "panelinfoRece";
            this.panelinfoRece.Size = new System.Drawing.Size(958, 215);
            this.panelinfoRece.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(373, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "  Escribe el Titulo de la receta...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 96);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // txtIDesc
            // 
            this.txtIDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDesc.ForeColor = System.Drawing.Color.Black;
            this.txtIDesc.Location = new System.Drawing.Point(299, 54);
            this.txtIDesc.Multiline = true;
            this.txtIDesc.Name = "txtIDesc";
            this.txtIDesc.Size = new System.Drawing.Size(471, 136);
            this.txtIDesc.TabIndex = 4;
            this.txtIDesc.Text = "  Platica un poco sobre tu receta...";
            this.txtIDesc.Enter += new System.EventHandler(this.txtIDesc_Enter);
            this.txtIDesc.Leave += new System.EventHandler(this.txtIDesc_Leave);
            // 
            // lblBarraAzul
            // 
            this.lblBarraAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBarraAzul.Location = new System.Drawing.Point(22, 164);
            this.lblBarraAzul.Name = "lblBarraAzul";
            this.lblBarraAzul.Size = new System.Drawing.Size(199, 2);
            this.lblBarraAzul.TabIndex = 3;
            // 
            // txtNomRec
            // 
            this.txtNomRec.BackColor = System.Drawing.Color.White;
            this.txtNomRec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomRec.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtNomRec.Location = new System.Drawing.Point(31, 144);
            this.txtNomRec.Name = "txtNomRec";
            this.txtNomRec.Size = new System.Drawing.Size(190, 17);
            this.txtNomRec.TabIndex = 1;
            this.txtNomRec.Text = "Escribe el nombre aquí";
            this.txtNomRec.Enter += new System.EventHandler(this.txtNomRec_Enter);
            this.txtNomRec.Leave += new System.EventHandler(this.txtNomRec_Leave);
            // 
            // txtIngre
            // 
            this.txtIngre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIngre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIngre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngre.ForeColor = System.Drawing.Color.Black;
            this.txtIngre.Location = new System.Drawing.Point(15, 51);
            this.txtIngre.Multiline = true;
            this.txtIngre.Name = "txtIngre";
            this.txtIngre.Size = new System.Drawing.Size(206, 186);
            this.txtIngre.TabIndex = 4;
            this.txtIngre.Text = "Escribe los ingredientes a utilizar: ";
            this.txtIngre.TextChanged += new System.EventHandler(this.txtIngre_TextChanged);
            this.txtIngre.Enter += new System.EventHandler(this.txtIngre_Enter);
            this.txtIngre.Leave += new System.EventHandler(this.txtIngre_Leave);
            // 
            // lblIngrediente
            // 
            this.lblIngrediente.AutoSize = true;
            this.lblIngrediente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngrediente.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngrediente.ForeColor = System.Drawing.Color.Black;
            this.lblIngrediente.Location = new System.Drawing.Point(61, 12);
            this.lblIngrediente.Name = "lblIngrediente";
            this.lblIngrediente.Size = new System.Drawing.Size(97, 24);
            this.lblIngrediente.TabIndex = 5;
            this.lblIngrediente.Text = "Ingredientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(246, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Preparación";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(246, 51);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 186);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Escribe el proceso de elaboración: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(428, 16);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(398, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(24, 13);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "min";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBox5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblIngrediente);
            this.panel2.Controls.Add(this.txtIngre);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(958, 307);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(742, 51);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(198, 186);
            this.textBox6.TabIndex = 14;
            this.textBox6.Text = "  Escribe una recomendación: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(805, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tips";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(523, 51);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(198, 186);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "  Escribe una recomendación: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(572, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Presentación";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(356, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 33);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(413, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 24);
            this.button1.TabIndex = 15;
            this.button1.Text = "Subir receta";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(15, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 43);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Location = new System.Drawing.Point(888, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 43);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // SubirReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelinfoRece);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "SubirReceta";
            this.Size = new System.Drawing.Size(958, 562);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelinfoRece.ResumeLayout(false);
            this.panelinfoRece.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSubRec;
        private System.Windows.Forms.Panel panelinfoRece;
        private System.Windows.Forms.Label lblBarraAzul;
        private System.Windows.Forms.TextBox txtNomRec;
        private System.Windows.Forms.TextBox txtIDesc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtIngre;
        private System.Windows.Forms.Label lblIngrediente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
    }
}
