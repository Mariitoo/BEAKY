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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }
           static public string username, passwd;

        public void button1_Click(object sender, EventArgs e)
        {

            username = tbUserName.Text;
            passwd = tbPasswd.Text;

            try
            {
                CONEXION.abrir();
                String query = "SELECT * FROM usuario WHERE nombre_usuario = '" + tbUserName.Text + "'AND contra = '" + tbPasswd.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, CONEXION.conectar);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = tbUserName.Text;
                    passwd = tbPasswd.Text;
                    
                    MenuPrincipal menuPrincipal = new MenuPrincipal();
                    menuPrincipal.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ingresa un usuario valido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }

            CONEXION.cerrar();
        }
    }
}
