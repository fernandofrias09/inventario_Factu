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
    public partial class FrmMantenimientoRoles : Form
    {
        public FrmMantenimientoRoles()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoRoles_Load(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from Roles";
                Conexion.Conectar();
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }
    }
}
