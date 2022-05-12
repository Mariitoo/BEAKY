using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BEAKY.Datos;

namespace BEAKY.Presentacion
{
    public partial class UserPorfile : UserControl
    {
        public UserPorfile()
        {
            InitializeComponent();
        }

        private void UserPorfile_Load(object sender, EventArgs e)
        {
            CONEXION.abrir();
            try
            {
                txtNomUS.Text = InicioSesion.username;
                SqlCommand cmd = new SqlCommand($"select apellido from usuario where nombre_usuario LIKE '%" + txtNomUS.Text + "%'", CONEXION.conectar);
                cmd.CommandType = CommandType.Text;

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtApellido.Text = $"{dr["apellido"].ToString()}";

                }

                //Mostrar recetas
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);

            }
            finally
            {


                CONEXION.cerrar();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            string consultar = $"select nombre, categoria, tiempo from receta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, CONEXION.conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            Datos.DataSource = dt;
        }
    }
}
