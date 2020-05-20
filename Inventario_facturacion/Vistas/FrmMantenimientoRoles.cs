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
        string consulta = "select * from Roles";
        public FrmMantenimientoRoles()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btnBorrar.Enabled = false;
            btnEditar.Enabled = false;
            txtIDRoles.Enabled = false;
            txtNombreRoles.Enabled = false;            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoRoles_Load(object sender, EventArgs e)
        {
            try
            {               
                Conexion.Conectar();
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnBorrar.Enabled = true;
            btnEditar.Enabled = true;
            txtIDRoles.Enabled = true;
            txtNombreRoles.Enabled = true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Rol rl = new Rol();
            rl.ID = Convert.ToInt32(txtIDRoles.Text);
            rl.Nombre = txtNombreRoles.Text;
            string consultaInsert = "INSERT INTO Roles(ID, Nombre) " +
                "Values('" + rl.ID + "','" + rl.Nombre + "' )";
            Conexion.Agregar(consultaInsert);
            try
            {
                Conexion.Conectar();
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void DgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Rol rl = new Rol();
            rl.ID = Convert.ToInt32(txtIDRoles.Text);
            rl.Nombre = txtNombreRoles.Text;
            string ConsultaEditar = "update Roles Set Nombre = '"+rl.Nombre+"' where ID='"+rl.ID+"'";
            Conexion.Agregar(ConsultaEditar);
            try
            {
                Conexion.Conectar();
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }

        }

        private void DgvRoles_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int IndiceDGV = e.RowIndex;

            txtIDRoles.Text = dgvRoles.Rows[IndiceDGV].Cells[0].Value.ToString(); //TextBox1 = Ap.ID
            txtNombreRoles.Text = dgvRoles.Rows[IndiceDGV].Cells[1].Value.ToString(); //TextBox2 = Ap.Nombre
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            Rol rl = new Rol();
            rl.ID = Convert.ToInt32(txtIDRoles.Text);
            rl.Nombre = txtNombreRoles.Text;
            string ConsultaEliminar = "Delete from Roles where ID ='"+rl.ID+"'";
            Conexion.Agregar(ConsultaEliminar);
            try
            {
                Conexion.Conectar();
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (chbID.CheckState == CheckState.Checked)
            {
                int ID = Convert.ToInt32(txtBusqueda.Text);
                String consulta = "select * from Roles Where ID='" + ID + "'";

                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);

            }
            else if (chbNombre.CheckState == CheckState.Checked)
            {
                String Nombre = txtBusqueda.Text;
                String consulta = "select * from Roles Where Nombre='" + Nombre + "'";
                dgvRoles.DataSource = Conexion.LlenarDGV(consulta);
            }
        }
    }
}
