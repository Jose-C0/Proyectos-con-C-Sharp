using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaSoporte;
using CapaSoporte.Cache;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {
        private bool userCache;

        public bool Login(string Usuario, string Contrasena)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select* from Usuario where  Usuario = @Usuario and Contrasena = @Contrasena";
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Contrasena", Contrasena);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.Id = reader.GetInt32(0);
                            UserLoginCache.IdRol = reader.GetInt32(1);
                            UserLoginCache.Nombre = reader.GetString(2);
                            UserLoginCache.Apellido = reader.GetString(3);
                            UserLoginCache.Telefono = reader.GetString(5);
                            UserLoginCache.Correo = reader.GetString(4);

                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        public void AnyMethod()
        {
         
        }

    }
}
