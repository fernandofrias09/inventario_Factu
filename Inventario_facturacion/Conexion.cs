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
    }
}
