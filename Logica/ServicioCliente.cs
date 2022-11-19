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
        public string Delete(int Indice)
        {
            throw new NotImplementedException();
        }

        public string Edit(Cliente Cliente, int p)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(Cliente Cliente, int p)
        {
            throw new NotImplementedException();
        }

        public string Guardar(Cliente Cliente)
        {
            return repositorioCliente.InsertarCliente(Cliente);
        }
    }
}