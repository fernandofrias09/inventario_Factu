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

        private void BtnBorrar_Click(object sender, EventArgs e)
        {

            producto pd = new producto();
            pd.ID = Convert.ToInt32(TxtID.Text);
            string consultaDelete = "DELETE from Producto where Producto.ID = '"+pd.ID+"' ";
            Conexion.Agregar(consultaDelete);
            try
            {
                Conexion.Conectar();
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }

        private void DgvProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceDGV = e.RowIndex;

            TxtID.Text = dgvProducto.Rows[IndiceDGV].Cells[0].Value.ToString(); //TextBox1 = Ap.ID
            txtNombre.Text = dgvProducto.Rows[IndiceDGV].Cells[1].Value.ToString(); //TextBox2 = Ap.Nombre
            txtCosto.Text = dgvProducto.Rows[IndiceDGV].Cells[2].Value.ToString(); //TextBox3 = Costo
            txtCantidad.Text = dgvProducto.Rows[IndiceDGV].Cells[3].Value.ToString(); //TextBox3 = Cantidad
            txtPrecio.Text = dgvProducto.Rows[IndiceDGV].Cells[4].Value.ToString(); //TextBox3 = Precio
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            producto pd = new producto();
            pd.ID = Convert.ToInt32(TxtID.Text);
            pd.Nombre = txtNombre.Text;
            pd.Costo = Convert.ToDouble(txtCosto.Text);
            pd.Cantidad = Convert.ToInt32(txtCantidad.Text);
            pd.Precio = Convert.ToDouble(txtPrecio.Text);

            string consultaEditar = "UPDATE Producto SET Nombre = '"+pd.Nombre+ "', Costo = '"+pd.Costo+"'," +
                " Cantidad ='" +pd.Cantidad+"', Precio ='"+pd.Precio+"'" +
                " WHERE ID ='"+pd.ID+"' ";
            Conexion.Agregar(consultaEditar);
            try
            {
                Conexion.Conectar();
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

            if(chbID.CheckState == CheckState.Checked)
            {
                int ID = Convert.ToInt32(txtBusqueda.Text);
                String consulta = "select * from Producto Where ID='"+ID+"'";
                
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);

            }
            else if (chbNombre.CheckState == CheckState.Checked)
            {
                String Nombre = txtBusqueda.Text;
                String consulta = "select * from Producto Where Nombre='" + Nombre + "'";
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }
            else if (chbPrecio.CheckState == CheckState.Checked)
            {
                Double Precio = Convert.ToDouble( txtBusqueda.Text);
                String consulta = "select * from Producto Where Precio='" + Precio + "'";
                dgvProducto.DataSource = Conexion.LlenarDGV(consulta);
            }

        }

        private void ChbID_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
