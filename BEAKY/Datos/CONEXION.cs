using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BEAKY.Datos
{
    public class CONEXION
    {
        public static string conexion = @"Data Source=MARIO\SQLEXPRESS;Initial Catalog=BEAKY;Integrated Security=True";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
               
                MessageBox.Show("CONECTADO");
                
            }

        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
