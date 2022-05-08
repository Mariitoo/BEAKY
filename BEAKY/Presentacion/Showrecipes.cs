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
    public partial class Showrecipes : UserControl
    {
        public Showrecipes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            CONEXION.abrir();
            try
            {
                //esto funciona
                string consultar = $"select * from receta where nombre LIKE '%" + lblSearch.Text + "%'";
                SqlDataAdapter adaptador = new SqlDataAdapter(consultar, CONEXION.conectar);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                DGDatos.DataSource = dt;
                
                SqlCommand comando = new SqlCommand(consultar, CONEXION.conectar);
                SqlDataReader lector;
                lector = comando.ExecuteReader();


                //Esta parte no funciona, lo de arriba si, si quieres que funcione, solo quita los comentarios
                //SqlCommand cmd = new SqlCommand($"select * from receta where nombre = '%'", CONEXION.conectar);
                //cmd.CommandType = CommandType.Text;

                //cmd.Parameters.AddWithValue("@nombre", lblSearch.Text);
                //SqlDataReader dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    lblDescription.Text = $"{dr["descripcion"].ToString()}";
                //    lblPreparation.Text = $"{dr["preparacion"].ToString()}";
                //    lblIngredients.Text = $"{dr["ingrediente"].ToString()}";
                //    lblTips.Text = $"{dr["tips"].ToString()}";
                //    lblTime.Text = $"{dr["tiempo"].ToString()}";
                //}
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

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Showrecipes_Load(object sender, EventArgs e)
        {
            string consultar = $"select * from receta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, CONEXION.conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGDatos.DataSource = dt;

        }

        private void lblSearch_TextChanged(object sender, EventArgs e)
        {
            //Esto lo podremos quitar si queremos

            SqlDataAdapter cmd = new SqlDataAdapter($"select * from receta where nombre = '" + this.lblSearch.Text + "'", CONEXION.conectar);
            DataSet ds = new DataSet();
            cmd.Fill(ds, "receta");
            this.DGDatos.DataSource = ds.Tables[0];
        }

        private void DGDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = DGDatos.SelectedCells[0].Value.ToString();
            lblNombre.Text = DGDatos.SelectedCells[1].Value.ToString();
            lblTime.Text = DGDatos.SelectedCells[2].Value.ToString();
            lblDescription.Text = DGDatos.SelectedCells[3].Value.ToString();
            lblIngredients.Text = DGDatos.SelectedCells[4].Value.ToString();
            lblTips.Text = DGDatos.SelectedCells[5].Value.ToString();
            lblPreparation.Text = DGDatos.SelectedCells[6].Value.ToString();
        }

        private void Showrecipes_Load_1(object sender, EventArgs e)
        {
            string consultar = $"select * from receta";
            SqlDataAdapter adaptador = new SqlDataAdapter(consultar, CONEXION.conectar);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            DGDatos.DataSource = dt;
        }
    }
}
