using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Inventario_facturacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        public void logins()
        {           
            
            SqlCommand cmd = new SqlCommand("Select Nombre,contraseña from Usuario where Nombre = '" + txtNombreUsuario.Text +"' AND Contraseña = '"+txtContraseñaUsuario.Text+"'",Conexion.Conectar() );
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("login exitoso");
            }
            else
            {
                MessageBox.Show("Datos Incorrecto");
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            logins();
        }
    }
}
