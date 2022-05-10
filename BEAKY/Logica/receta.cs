using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEAKY.Logica
{
    public class receta
    {
        public int id_receta { get; set; }
        public string nombre { get; set; }
        public string tiempo { get; set; }
        public string descripcion { get; set; }
        public string ingrediente { get; set; }
        public string tips { get; set; }
        public string preparacion { get; set; }
        public int id_categoria { get; set; }
        public string categoria { get; set; }



    }
}
