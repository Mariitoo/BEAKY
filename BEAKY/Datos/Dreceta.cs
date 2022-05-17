using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BEAKY.Logica;

namespace BEAKY.Datos
{
    public class Dreceta
    {
        public bool InsertarReceta(receta parametros)
        {
            try
            {
                CONEXION.abrir();
                SqlCommand cmd = new SqlCommand("insertarRecet", CONEXION.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", parametros.nombre);
                cmd.Parameters.AddWithValue("@tiempo", parametros.tiempo);
                cmd.Parameters.AddWithValue("@descripcion", parametros.descripcion);
                cmd.Parameters.AddWithValue("@ingrediente", parametros.ingrediente);
                cmd.Parameters.AddWithValue("@preparacion", parametros.preparacion);
                //cmd.Parameters.AddWithValue("@id_categoria", parametros.id_categoria);
                cmd.Parameters.AddWithValue("@categoria", parametros.categoria);
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
