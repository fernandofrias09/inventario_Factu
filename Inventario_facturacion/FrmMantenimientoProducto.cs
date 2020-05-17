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
        string consulta = "select * from Producto";
        public FrmMantenimientoProducto()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            BtnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            TxtID.Enabled = false;
            txtCantidad.Enabled = false;
            txtCosto.Enabled = false;
            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
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

                  
                Conexion.Conectar();                
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            BtnBorrar.Enabled = true;
            btnEditar.Enabled = true;
            TxtID.Enabled = true;
            txtCantidad.Enabled = true;
            txtCosto.Enabled = true;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            producto pd = new producto();
            pd.ID = Convert.ToInt32(TxtID.Text);
            pd.Nombre = txtNombre.Text;
            pd.Costo = Convert.ToDouble(txtCosto.Text);
            pd.Cantidad = Convert.ToInt32(txtCantidad.Text);
            pd.Precio = Convert.ToDouble(txtPrecio.Text);
            string consultaInsert = "INSERT INTO Producto(ID, Nombre, Costo, Cantidad, Precio) " +
                "Values('"+pd.ID+"','"+pd.Nombre+"','"+pd.Costo+"','"+pd.Cantidad+"','"+pd.Precio+"' )";
            Conexion.Agregar(consultaInsert);
             try
             {                
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
