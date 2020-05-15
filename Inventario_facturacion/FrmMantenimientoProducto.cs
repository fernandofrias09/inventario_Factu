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
    public partial class FrmMantenimientoProducto : Form
    {
        public FrmMantenimientoProducto()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void GbProductosRegistrados_Enter(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoProducto_Load(object sender, EventArgs e)
        {
            try
            {

                string consulta = "select * from Producto";
                Conexion.Conectar();                
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }
    }
}
