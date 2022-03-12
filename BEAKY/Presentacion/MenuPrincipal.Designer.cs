namespace BEAKY.Presentacion
{
    partial class MenuPrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUsuario);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 575);
            this.panel1.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Location = new System.Drawing.Point(0, 90);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(196, 89);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consultar Reseta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(196, 90);
            this.panel3.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(196, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 575);
            this.panel2.TabIndex = 1;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.FlatAppearance.BorderSize = 0;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Location = new System.Drawing.Point(0, 179);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(196, 89);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "Usuarios";
            this.btnUsuario.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUsuario;
    }
}