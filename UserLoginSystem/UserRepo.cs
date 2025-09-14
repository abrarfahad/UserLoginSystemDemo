using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class UserRepo
    {
        List<User> Users;
        DataAccess dataAccess;
        public UserRepo()
        {
            dataAccess = new DataAccess();
            Users = new List<User>();
            PopulateUsers();
        }

        public void PopulateUsers()
        {
            User teacher = new Teacher() {
                Id = 1,
                UserName = "abrar",
                Password = "1111"
            };
            Student student = new Student() {
                Id = 2,
                UserName = "Tahasin",
                Password="1234"
            };
            Users.Add(teacher);
            Users.Add(student);
        }
        public DataTable getAllUsers()
        {
            var sql = $"Select Id,UserName,UserType,ContactNumber as Contact,Address from Users ";
            var datatable = dataAccess.Execute(sql);
            foreach(var row in datatable.Rows)
            {
                
            }
            return datatable;
        }
        public bool UpdateUser(User user)
        {
            //string cs = @"Server=DESKTOP-JM75471\SQLEXPRESS;Database=ScoolManagementSystemDb;Trusted_Connection=True;";

            //string sql = @"UPDATE [ScoolManagementSystemDb].[dbo].[Users]
            //       SET UserName = @un,
            //           ContactNumber = @cn,
            //           Address = @adr
            //       WHERE Id = @Id";

            //using (SqlConnection conn = new SqlConnection(cs))
            //using (SqlCommand cmd = new SqlCommand(sql, conn))
            //{
            //    cmd.CommandType = CommandType.Text;

            //    cmd.Parameters.Add("@un", SqlDbType.NVarChar, 50).Value = user.UserName;
            //    cmd.Parameters.Add("@cn", SqlDbType.NVarChar, 16).Value = user.ContactNumber;
            //    cmd.Parameters.Add("@adr", SqlDbType.NVarChar, 255).Value = user.Address;
            //    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = user.Id;

            //    conn.Open();
            //    int rows = cmd.ExecuteNonQuery();

            //    if (rows > 0)
            //    {
            //        return true;
            //    }
            //}
            var updateSql2 = $"update Users set UserName='{user.UserName}'," +
                $"ContactNumber='{user.ContactNumber}'," +
                $"Address='{user.Address}' where Id='{user.Id}'";
            var cmd = dataAccess.GetCommand(updateSql2);
            if (dataAccess.ExecuteNonQuery(cmd) > 0)
            {
                return true;
            }
            return false;
        }
        public bool IsUserValidForLogin(string username,string password)
        {
            DataTable dataTable;
            var sql = "select * from Users where UserName=@UN and Password = @PW";
            var cmd = dataAccess.GetCommand(sql);
            cmd.Parameters.AddWithValue("@UN", username);
            cmd.Parameters.AddWithValue("@PW", password);
            dataTable = dataAccess.Execute(cmd);

            if (dataTable.Rows.Count > 0) {
                return true;
            }

            return false;
        }
        public User GetUserForLogin(string username, string Password)
        {

            
            foreach(var user in Users)
            {
                if(user.UserName==username && user.Password == Password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
