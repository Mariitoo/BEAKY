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
            SqlCommand cmd = new SqlCommand($"SELECT * FROM dbo.receta WHERE id_receta = '2'", CONEXION.conectar);
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.AddWithValue("id_receta", 2);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblDescription.Text = $"{dr["descripcion"].ToString()}";
                lblPreparation.Text = $"{dr["preparacion"].ToString()}";
                lblIngredients.Text = $"{dr["ingredientes"].ToString()}";
                lblTips.Text = $"{dr["tips"].ToString()}";
                lblTime.Text = $"{dr["tiempo_receta"].ToString()}";
            }
            CONEXION.cerrar();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
