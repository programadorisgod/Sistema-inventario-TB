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
            Conexion.Open();
            cmd = new SqlCommand("RegistrarCliente", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            try
            {
                var result = cmd.ExecuteNonQuery();
                return result == 1 ? "se agregó el Cliente" : "error al agregar";
            }
            catch (Exception)
            {
                return "error al agregar ";
            }

            Conexion.Close();

        }

        public List<Cliente> GetClienteList()
        {
            List<Cliente> clientes = new List<Cliente>();
            string ssql = String.Format("select * from Clientes");
            cmd = new SqlCommand(ssql, Conexion);
            Conexion.Open();
            var reader = cmd.ExecuteReader();
            while ((reader.Read()))
            {
                clientes.Add(new Cliente(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5)));
            }
            Cerrar();
            return clientes;
        }


        public string EditarCliente(Cliente cliente)
        {
            Conexion.Open();
            cmd = new SqlCommand("EditarCliente", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", cliente.Cedula);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Direccion", cliente.Direccion);
            try
            {
                var result = cmd.ExecuteNonQuery();
                return result == 1 ? "se edtió el Cliente" : " error al editar ";

            }
            catch (Exception)
            {
                return "error al editar";

            }
            Conexion.Close();

        }

        public int BuscarPorId(string Cedula)
        {
            int count = 0;

            Conexion.Open();
            cmd = new SqlCommand("BuscarID", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            try
            {
                cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception)
            {
                return count;

            }
            Conexion.Close();
            return count;
        }

        public string Elimnar(string Cedula)
        {

            Conexion.Open();
            cmd = new SqlCommand("Eliminar", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Cedula", Cedula);
            try
            {
                var result = cmd.ExecuteNonQuery();
                return result == 1 ? "se eliminó el Cliente" : "error al eliminar el cliente ";

            }
            catch (Exception)
            {
                return "error al editar";

            }
            Conexion.Close();
        }
        public Administrador Capturar()
        {
            Administrador obj = new Administrador();

            try
            {

                Conexion.Open();
                string Query = "Select Cedula, Nombre from Administrador ";
                cmd = new SqlCommand(Query, Conexion);
                cmd.CommandType = System.Data.CommandType.Text;
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    obj = new Administrador()
                    {
                        Cedula = reader["Cedula"].ToString(),
                        Nombre = reader["Nombre"].ToString()
                    };
                }
            }
            catch (Exception)
            {

                obj = new Administrador();
            }
            return obj;
        }

    }

}
