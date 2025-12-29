using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace UserLoginSystem
{
    public abstract class BaseDataAccess<TConnection, TCommand> 
        where TConnection : DbConnection, new()
        where TCommand : DbCommand, new()
    {
        protected static string _connectionString = string.Empty;

        protected abstract string GetConnectionStringName();

        protected string ConnectionString
        {
            get
            {
                if (_connectionString == string.Empty)
                {
                    _connectionString = ConfigurationManager.ConnectionStrings[GetConnectionStringName()].ConnectionString;
                }
                return _connectionString;
            }
        }

        protected BaseDataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected BaseDataAccess()
        {
            string connStr = ConfigurationManager.ConnectionStrings[GetConnectionStringName()].ConnectionString;
            _connectionString = connStr;
        }

        /// <summary>
        /// Returns a Command object to add some parameters in it. After you send this to Execute method.
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public TCommand GetCommand(string sql)
        {
            TConnection conn = new TConnection();
            conn.ConnectionString = ConnectionString;
            TCommand sqlCmd = new TCommand();
            sqlCmd.Connection = conn;
            sqlCmd.CommandText = sql;
            return sqlCmd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            TCommand cmd = GetCommand(sql);

            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        /// <summary>
        /// Returns DataTable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable Execute(TCommand command)
        {
            DataTable dt = new DataTable();
            try
            {

                command.Connection.Open();
                dt.Load(command.ExecuteReader());
            }
            catch (Exception ex) { }
            finally
            {
                command.Connection.Close();
            }

            return dt;
        }

        /// <summary>
        /// returns affected row count
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string sql)
        {
            TCommand cmd = GetCommand(sql);
            int result = 0;
            try
            {
                cmd.Connection.Open();
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                cmd.Connection.Close();
            }

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(TCommand command)
        {
            int result = 0;
            try
            {
                command.Connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                command.Connection.Close();
            }

            return result;
        }
    }
}
