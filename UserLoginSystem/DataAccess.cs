using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UserLoginSystem
{
    public class DataAccess : BaseDataAccess<SqlConnection, SqlCommand>
    {
        public static string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["UserDb"].ConnectionString;

        protected override string GetConnectionStringName()
        {
            return "UserDb";
        }

        public DataAccess(string connectionString) : base(connectionString)
        {
        }

        public DataAccess() : base()
        {
        }
    }
}
