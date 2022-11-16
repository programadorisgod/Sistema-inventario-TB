using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{

    public class DetalleSalida
    {
        public int Idhistorialventa { get; set; }
        public int IdSalida { get; set; }
        public int IdProducto { get; set; }
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public string AlmacenProducto { get; set; }
        public string PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public string SubTotal { get; set; }
        private DateTime FechaVenta { get; set; }

    }
}