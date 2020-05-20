using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Inventario_facturacion
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=FERNANDOFRIAS;DATABASE=Tienda_Globos;integrated security = true");
            cn.Open();           
            return cn;
        }
        public static DataTable LlenarDGV(string Consulta)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(Consulta, Conexion.Conectar());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static int Agregar(string Consulta)
        {
            int a = 0;
            try
            {
               
                SqlCommand cmd = new SqlCommand(Consulta, Conexion.Conectar());
                a = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return a;
        }
        public static List<Rol> Obtener(string consultarol)
        {
            List<Rol> lista = new List<Rol>();          
            SqlCommand cmd = new SqlCommand(consultarol, Conexion.Conectar());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Rol rl = new Rol();
                rl.ID = dr.GetInt32(0);
                rl.Nombre = dr.GetString(1);
                lista.Add(rl);
            }

            return lista;
        }
        
    }
}
