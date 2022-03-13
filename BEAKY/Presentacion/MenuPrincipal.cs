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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienveni.Dock = DockStyle.Fill;
        }

        private void panel25_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //PruebasControl Control = new PruebasControl();
            //panelMuestra.Controls.Clear();
            //Control.Dock = DockStyle.Fill;
            //panelMuestra.Controls.Add(Control);
        }
    }
}
