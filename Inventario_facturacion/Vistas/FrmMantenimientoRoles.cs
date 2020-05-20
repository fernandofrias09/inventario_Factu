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
    }
}
