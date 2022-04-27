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
    public partial class SubirReceta : UserControl
    {
        public SubirReceta()
        {
            InitializeComponent();
        }

        //Evento cuando el Text esta activo
        private void txtNomRec_Enter(object sender, EventArgs e)
        {
            //Se llama a la clase con us metodo estatico y pasamos los paremetros
            PlaceHold.Enter("Escribe el nombre aquí", txtNomRec);

        }

        private void txtNomRec_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Escribe el nombre aquí", txtNomRec);
        }

        //Evento cuando el Text esta activo
        private void txtIngre_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Escribe los ingredientes a utilizar", txtIngre);
        }

        private void txtIngre_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Escribe los ingredientes a utilizar", txtIngre);
        }

        private void txtIDesc_Enter(object sender, EventArgs e)
        {
            PlaceHold.Enter("Platica un poco sobre tu receta", txtIDesc);
        }

        private void txtIDesc_Leave(object sender, EventArgs e)
        {
            PlaceHold.Leave("Platica un poco sobre tu receta", txtIDesc);
        }

        private void lblSubRec_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtIngre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                CONEXION.abrir();
                //AQUÍ SE EJECUTA EL SCRIPT PARA HACER INSERCIONES EN LA BD
                String sql = " ";
                sql = sql + "INSERT INTO [dbo].[receta] " + "\n";
                sql = sql + "           ([nombre] " + "\n";
                sql = sql + "           ,[tiempo] " + "\n";
                sql = sql + "           ,[descripcion] " + "\n";
                sql = sql + "           ,[ingrediente] " + "\n";
                sql = sql + "           ,[tips] " + "\n";
                sql = sql + "           ,[preparacion]) " + "\n";
                sql = sql + "     VALUES " + "\n";
                sql = sql + "           (@nombre " + "\n";
                sql = sql + "           ,@tiempo " + "\n";
                sql = sql + "           ,@descripcion " + "\n";
                sql = sql + "           ,@ingrediente " + "\n";
                sql = sql + "           ,@tips " + "\n";
                sql = sql + "           ,@preparacion)";

                //Aquí se lleva todo lo que esté contenido en los campos en los textbox
                SqlCommand prueba = new SqlCommand(sql, CONEXION.conectar);
                prueba.Parameters.AddWithValue("@nombre", txtNomRec.Text);
                prueba.Parameters.AddWithValue("@tiempo", txtTiempo.Text);
                prueba.Parameters.AddWithValue("@descripcion", txtIDesc.Text);
                prueba.Parameters.AddWithValue("@ingrediente", txtIngre.Text);
                prueba.Parameters.AddWithValue("@tips", txtTips.Text);
                prueba.Parameters.AddWithValue("@preparacion", txtPrepara.Text);
                prueba.ExecuteNonQuery();
                MessageBox.Show("Información cargada exitosamente");



            }
            catch (Exception)
            {
                MessageBox.Show("No jalas pa programar");

                
            }
            finally
            {
                CONEXION.cerrar();
            }
            
        }

        private void txtIDesc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
