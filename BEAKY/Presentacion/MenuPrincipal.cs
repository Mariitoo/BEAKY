using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BEAKY.Presentacion;

namespace BEAKY.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            btnUsuarios.Text = InicioSesion.username;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            panelBienvenida.Dock = DockStyle.Fill;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SubirReceta Control = new SubirReceta();
            panelMuestra.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelMuestra.Controls.Add(Control);

        }

        private void panelMuestra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            Showrecipes Control = new Showrecipes();
            panelMuestra.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelMuestra.Controls.Add(Control);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UserPorfile Control = new UserPorfile();
            panelMuestra.Controls.Clear();
            Control.Dock = DockStyle.Fill;
            panelMuestra.Controls.Add(Control);
        }
    }
}
