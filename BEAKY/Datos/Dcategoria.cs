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
    public class Dcategoria
    {
        public bool insertarCategoria(Lcategoria parametros)
        {
            try
            {
                CONEXION.abrir();
                SqlCommand cmd = new SqlCommand("insertarCategoria", CONEXION.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public void BuscarCat(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXION.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCat", CONEXION.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
               
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
    }
}