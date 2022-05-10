using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEAKY.Logica;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BEAKY.Datos
{
    public class Dusuario
    {
        public bool insertarUsuario(Lusuario parametros)
        {
            try
            {
                CONEXION.abrir();
                SqlCommand cmd = new SqlCommand("insertarUsuario", CONEXION.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.nombre);
                cmd.Parameters.AddWithValue("@apellido", parametros.apellido);
                cmd.Parameters.AddWithValue("@contra", parametros.contra);
                cmd.Parameters.AddWithValue("@nombre_usuario", parametros.nombre_usuario);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
                return false;
            }
            finally
            {
                CONEXION.cerrar();
            }
        }
    }
}
