using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;
using NPOI.SS.Formula.Functions;

namespace Logica
{
    public class ServicioCliente : Iservices<Cliente>
    {
        Datos.RepositorioCliente repositorioCliente = new Datos.RepositorioCliente();
        List<Cliente> clientes;
        public ServicioCliente()
        {
            clientes = repositorioCliente.GetClienteList();
        }
        public string Delete(Cliente Cliente)
        {
            var encontro = repositorioCliente.BuscarPorId(Cliente.Cedula);
            if (encontro !=0)
            {
               return repositorioCliente.Elimnar(Cliente.Cedula);
            }
            return "Cliente no encontrado";
        }

        public string Edit(Cliente Cliente)
        {
            var encontro = repositorioCliente.BuscarPorId(Cliente.Cedula);
            if (encontro != 0)
            {
                return repositorioCliente.EditarCliente(Cliente);
            }
            return "Cliente no encontrado";
        }

        public List<Cliente> GetAll()
        {
            return clientes;
        }


        public string Guardar(Cliente Cliente)
        {
            return repositorioCliente.InsertarCliente(Cliente);
        }
    }
}