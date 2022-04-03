using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms; 

namespace BEAKY.Presentacion
{
    public class PlaceHold
    {
        public static void Leave(string pHolder, TextBox pText)
        {
            if(pText.Text ==  string.Empty)
            {
                pText.Text = pHolder;
                pText.ForeColor = Color.DimGray;
            }
        }
        public static void Enter(string pHolder, TextBox pText)
        {
            if(pText.Text == pHolder)
            {
                pText.Text = string.Empty;
                pText.ForeColor = Color.White;
            }
        }
    }
}
