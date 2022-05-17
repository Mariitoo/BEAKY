using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEAKY.Datos;
using BEAKY.Logica;
using System.Data.SqlClient;


namespace BEAKY.Presentacion
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            CONEXION.abrir();
            String sql = "";
            sql = sql + "INSERT INTO [dbo].[usuario] " + "\n";
            sql = sql + "           ([nombre] " + "\n";
            sql = sql + "           ,[apellido] " + "\n";
            sql = sql + "           ,[contra] " + "\n";
            sql = sql + "           ,[nombre_usuario]) " + "\n";
            sql = sql + "            VALUES " + "\n";
            sql = sql + "           (@nombre " + "\n";
            sql = sql + "           ,@apellido " + "\n";
            sql = sql + "           ,@contra" + "\n";
            sql = sql + "           ,@nombre_usuario) " + "\n";

            SqlCommand prueba = new SqlCommand(sql, CONEXION.conectar);
            prueba.Parameters.AddWithValue("@nombre", tbName2.Text);
            prueba.Parameters.AddWithValue("@apellido", tbLastName3.Text);
            
            prueba.Parameters.AddWithValue("@contra", tbPasswd5.Text);
            prueba.Parameters.AddWithValue("@nombre_usuario", tbUserName1.Text);
            prueba.ExecuteNonQuery();
            MessageBox.Show("Información cargada exitosamente");
            CONEXION.cerrar();
            InicioSesion inicsec = new InicioSesion();
            inicsec.Show();
            this.Hide();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            {
                CONEXION.abrir();
                String sql = "";
                sql = sql + "INSERT INTO [dbo].[usuario] " + "\n";
                sql = sql + "           ([nombre] " + "\n";
                sql = sql + "           ,[apellido] " + "\n";
                sql = sql + "           ,[contra] " + "\n";
                sql = sql + "           ,[nombre_usuario]) " + "\n";
                sql = sql + "            VALUES " + "\n";
                sql = sql + "           (@nombre " + "\n";
                sql = sql + "           ,@apellido " + "\n";
                sql = sql + "           ,@contra" + "\n";
                sql = sql + "           ,@nombre_usuario) " + "\n";

                SqlCommand prueba = new SqlCommand(sql, CONEXION.conectar);
                prueba.Parameters.AddWithValue("@nombre", tbName2.Text);
                prueba.Parameters.AddWithValue("@apellido", tbLastName3.Text);

                prueba.Parameters.AddWithValue("@contra", tbPasswd5.Text);
                prueba.Parameters.AddWithValue("@nombre_usuario", tbUserName1.Text);
                prueba.ExecuteNonQuery();
                MessageBox.Show("Información cargada exitosamente");
                CONEXION.cerrar();
                InicioSesion inicsec = new InicioSesion();
                inicsec.Show();
                this.Hide();
            }
        }
    }
}
