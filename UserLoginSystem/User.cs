using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserType { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
    }
    public enum UserTypeEnum
    {
        [Description("Teacher")]
        Teacher,
        [Description("Student")]
        Student,
        [Description("Officer")]
        Officer
    }
}
