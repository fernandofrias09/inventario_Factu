using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_facturacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoProducto frmp = new FrmMantenimientoProducto();
            frmp.Show();
        }

        private void RolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoRoles frmR = new FrmMantenimientoRoles();
            frmR.Show();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoUsuario frmU = new FrmMantenimientoUsuario();
            frmU.Show();

        }

        private void AyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
