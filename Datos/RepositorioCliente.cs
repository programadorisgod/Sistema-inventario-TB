using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades;
using NPOI.SS.Formula.Functions;

namespace Datos
{
    public class RepositorioCliente : ConexionBasedeDatos
    {

        SqlCommand cmd;

        public string InsertarCliente(Cliente cliente)
        {
            int count = 0;
            Conexion.Open();
            cmd = new SqlCommand("RegistrarCliente", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula.ToString());
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre.ToString());
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono.ToString());
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo.ToString());
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion.ToString());
            try
            {
                var result = cmd.ExecuteNonQuery();
                return result == 1 ? "se agregro el Cliente" : "error al agregar ";
            }
            catch (Exception)
            {
                return "error al agregar ";
                throw;
            }
            Conexion.Close();
        }

    }

}
