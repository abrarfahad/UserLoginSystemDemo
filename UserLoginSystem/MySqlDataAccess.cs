using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class MySqlDataAccess : BaseDataAccess<MySqlConnection, MySqlCommand>
    {
        public static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["MyUserDb"].ConnectionString;

        protected override string GetConnectionStringName()
        {
            return "MyUserDb";
        }

        public MySqlDataAccess(string connectionString) : base(connectionString)
        {
        }

        public MySqlDataAccess() : base()
        {
        }
    }
}
