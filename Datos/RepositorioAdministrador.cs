using System;
using System.Data.SqlClient;

namespace Datos
{
    public class RepositorioAdministrador : ConexionBasedeDatos
    {
 

        SqlCommand cmd;

        public int Consultarlogin(string Usuario, string Clave)
        {
            int count = 0;
            Conexion.Open();
            cmd = new SqlCommand("ConsultaLogin", Conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Clave", Clave);
            try
            {
                 cmd.ExecuteNonQuery();
                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                return count;
                throw;
            }
            Conexion.Close();
            return count;
           
        }

    }
}
