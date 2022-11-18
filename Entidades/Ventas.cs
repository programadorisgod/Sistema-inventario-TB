using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Ventas
    {
        public int  IdVenta { get; set; }

        public string CedulaCliente { get; set; }

        public int CantidadProductos { get; set; }

        public double TotalVenta { get; set; }

        private DateTime FechaVenta { get; set; }

        public List<DetalleSalida> ListaDetalleSalida { get; set; }
    }
}