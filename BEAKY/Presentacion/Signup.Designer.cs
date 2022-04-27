namespace BEAKY.Presentacion
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textPasswd = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.textPrimerNombre = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 707);
            this.panel1.TabIndex = 0;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox7.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(-17, 679);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1066, 28);
            this.textBox7.TabIndex = 5;
            this.textBox7.Text = " BEAKY  the best place to store your recipes!";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnSignup);
            this.panel2.Controls.Add(this.textApellido);
            this.panel2.Controls.Add(this.textPasswd);
            this.panel2.Controls.Add(this.textEmail);
            this.panel2.Controls.Add(this.textUserName);
            this.panel2.Controls.Add(this.textPrimerNombre);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(277, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 539);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 41);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignup
            // 
            this.btnSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignup.Location = new System.Drawing.Point(154, 458);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(168, 57);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Registrarse";
            this.btnSignup.UseVisualStyleBackColor = false;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // textApellido
            // 
            this.textApellido.BackColor = System.Drawing.Color.Ivory;
            this.textApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textApellido.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textApellido.Location = new System.Drawing.Point(21, 237);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(417, 42);
            this.textApellido.TabIndex = 5;
            this.textApellido.Text = "    Apellido";
            this.textApellido.TextChanged += new System.EventHandler(this.textApellido_TextChanged);
            // 
            // textPasswd
            // 
            this.textPasswd.BackColor = System.Drawing.Color.Ivory;
            this.textPasswd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPasswd.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPasswd.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textPasswd.Location = new System.Drawing.Point(21, 380);
            this.textPasswd.Name = "textPasswd";
            this.textPasswd.Size = new System.Drawing.Size(417, 42);
            this.textPasswd.TabIndex = 4;
            this.textPasswd.Text = "    Contraseña";
            this.textPasswd.TextChanged += new System.EventHandler(this.textPasswd_TextChanged);
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.Ivory;
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textEmail.Location = new System.Drawing.Point(21, 310);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(417, 42);
            this.textEmail.TabIndex = 3;
            this.textEmail.Text = "    email";
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged);
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.Ivory;
            this.textUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textUserName.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textUserName.Location = new System.Drawing.Point(21, 91);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(417, 42);
            this.textUserName.TabIndex = 2;
            this.textUserName.Text = "    Nombre de usuario";
            this.textUserName.TextChanged += new System.EventHandler(this.textUserName_TextChanged);
            // 
            // textPrimerNombre
            // 
            this.textPrimerNombre.BackColor = System.Drawing.Color.Ivory;
            this.textPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrimerNombre.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrimerNombre.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.textPrimerNombre.Location = new System.Drawing.Point(21, 164);
            this.textPrimerNombre.Name = "textPrimerNombre";
            this.textPrimerNombre.Size = new System.Drawing.Size(417, 42);
            this.textPrimerNombre.TabIndex = 1;
            this.textPrimerNombre.Text = "    Primer Nombre";
            this.textPrimerNombre.TextChanged += new System.EventHandler(this.textPrimerNombre_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Pink;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-3, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 41);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "SIGN UP";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Signup";
            this.Size = new System.Drawing.Size(1049, 707);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textPasswd;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.TextBox textPrimerNombre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox7;
    }
}
