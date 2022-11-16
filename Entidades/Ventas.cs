using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Ventas
    {
        public int NumeroVenta { get; set; }

        public string DocumentoCliente { get; set; }
        private DateTime FechaVenta { get; set; }

        public int CantidadVendidaProducto { get; set; }

        public double TotalVenta { get; set; }


        public Producto Producto { get; set; }


        public Cliente Cliente { get; set; }


        public List<DetalleSalida> ListaDetalleSalida { get; set; }

    }
}