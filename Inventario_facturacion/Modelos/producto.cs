using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_facturacion
{
    class producto
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public Double Costo { get; set; }
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public double Precio { get; set; }
    }
}
