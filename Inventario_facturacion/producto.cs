﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario_facturacion
{
    class producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Costo { get; set; }
        public int Cantidad { get; set; }
        public float Precio { get; set; }
    }
}