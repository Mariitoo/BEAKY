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
    public partial class Signup : UserControl
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrimerNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPasswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.abrir();
                //AQUÍ SE EJECUTA EL SCRIPT PARA HACER INSERCIONES EN LA BD
                String sql = " ";
                sql = sql + "INSERT INTO [dbo].[usuario] " + "\n";
                sql = sql + "           ([nombre_usuario] " + "\n";
                sql = sql + "           ,[nombre_real] " + "\n";
                sql = sql + "           ,[apellido_real] " + "\n";
                sql = sql + "           ,[email] " + "\n";
                sql = sql + "           ,[passwd]) " + "\n";
                sql = sql + "            VALUES " + "\n";
                sql = sql + "           (@nombre_usuario " + "\n";
                sql = sql + "           ,@nombre_real " + "\n";
                sql = sql + "           ,@apellido_real " + "\n";
                sql = sql + "           ,@email " + "\n";
                sql = sql + "           ,@passwd) " + "\n";

                //Aquí se lleva todo lo que esté contenido en los campos en los textbox
                SqlCommand prueba = new SqlCommand(sql, CONEXION.conectar);
                prueba.Parameters.AddWithValue("@nombre_usuario", textUserName.Text);
                prueba.Parameters.AddWithValue("@nombre_real", textPrimerNombre.Text);
                prueba.Parameters.AddWithValue("@apellido_real", textApellido.Text);
                prueba.Parameters.AddWithValue("@email", textEmail.Text);
                prueba.Parameters.AddWithValue("@passwd", textPasswd.Text);
                prueba.ExecuteNonQuery();
                MessageBox.Show("Información cargada con éxito");



            }
            catch (Exception)
            {
                MessageBox.Show("Error de conexión");


            }
            finally
            {
                CONEXION.cerrar();
            }
        }
    }
}
