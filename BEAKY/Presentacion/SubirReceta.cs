using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
