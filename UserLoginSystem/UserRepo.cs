using System;
using System.Collections.Generic;
using System.Data;
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
            var sql = $"Select Id,UserName,ContactNumber as Contact,Address from Users ";
            var datatable = dataAccess.Execute(sql);
            return datatable;
        }
        public bool UpdateUser(User user)
        {
            var updateSql = $"update Users set UserName='{user.UserName}'," +
                $"ContactNumber='{user.ContactNumber}'," +
                $"Address='{user.Address}' where Id='{user.Id}'";
            if (dataAccess.ExecuteNonQuery(updateSql) > 0)
            {
                return true;
            }
            return false;
        }
        public bool IsUserValidForLogin(string userame,string password)
        {
            DataTable dataTable;
            dataTable = dataAccess.Execute($"Select * from Users where UserName='{userame.Trim()}' and Password='{password.Trim()}' ");

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
