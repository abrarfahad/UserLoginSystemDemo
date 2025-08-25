using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class UserRepo
    {
        List<User> Users;
        public UserRepo()
        {
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
