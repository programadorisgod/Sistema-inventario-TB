using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Inventario
    {

        public Double ValorVenta { get; set; }


        public int EntradaProducto { get; set; }


        public int CantidadProducto { get; set; }


        public int SalidaProducto { get; set; }
      

        public Producto Producto { get; set; }


        public Ventas Ventas { get; set; }


        public string Almacen { get; set; }


    }
}