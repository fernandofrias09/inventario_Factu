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
    public partial class FrmMantenimientoUsuario : Form
    {
        string consulta = "select * from Usuario";
        public FrmMantenimientoUsuario()
        {
            InitializeComponent();
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            BtnEditar.Enabled = false;
            txtIDUsuario.Enabled = false;
            txtNombreUsuario.Enabled = false;
            txtContraseña.Enabled = false;
            cbRolUsuario.Enabled = false;
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TxtApellido_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoUsuario_Load(object sender, EventArgs e)
        {
            string consultacb = "select ID,Nombre from Roles";
            try
            {
               
                Conexion.Conectar();
                dgvUsuario.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
            cbRolUsuario.DataSource = Conexion.Obtener(consultacb);
            cbRolUsuario.DisplayMember = "Nombre";
            cbRolUsuario.ValueMember = "ID";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
           
            btnAgregar.Enabled = true;
            BtnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            txtIDUsuario.Enabled = true;
            txtNombreUsuario.Enabled = true;
            txtContraseña.Enabled = true;
            cbRolUsuario.Enabled = true;
           
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.ID = Convert.ToInt32(txtIDUsuario.Text);
            us.Nombre = txtNombreUsuario.Text;
            us.Contraseña = txtContraseña.Text;
            us.ID_Rol = Convert.ToInt32(cbRolUsuario.SelectedValue);
            
            string consultaInsert = "INSERT INTO Usuario(ID, Nombre, Contraseña, ID_Roles) " +
                "Values('" + us.ID + "','" + us.Nombre + "','" + us.Contraseña + "','" + us.ID_Rol + "')";
            Conexion.Agregar(consultaInsert);
            try
            {
                Conexion.Conectar();
                dgvUsuario.DataSource = Conexion.LlenarDGV(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                throw;
            }
        }
    }
}
