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
