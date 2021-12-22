using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ConnectionToSql
    {
        private readonly string connectionstring;
        public ConnectionToSql()
        {
            connectionstring = "Server=.;DataBase= GestionVeterinaria; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionstring);
        }

        
    }
}
