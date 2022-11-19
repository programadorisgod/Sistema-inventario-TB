using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {

        public string Correo { get; set; }
        public string Direccion { get; set; }


        public Cliente()
        {

        }

        public Cliente(string Cedula, string Nombre, string Telefono, string Correo, string Direccion)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Correo = Correo;
            this.Direccion = Direccion;
        }
    }
}