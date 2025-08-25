using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class Teacher:User
    {
        public Teacher()
        {
            this.UserType = (int)UserTypeEnum.Teacher;
        }
        public DateTime JoiningDate { get; set; }
    }
}
