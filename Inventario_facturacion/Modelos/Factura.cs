using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_facturacion
{
    class Factura
    {
        public int ID { get; set; }
        public int ID_Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public double ITBIS { get; set; }
        public double Total { get; set; }
    }
}
