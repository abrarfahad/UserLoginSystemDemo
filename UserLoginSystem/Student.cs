using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginSystem
{
    public class Student:User
    {
        public Student()
        {
            this.UserType = (int)UserTypeEnum.Student;
        }
        public int CreditCompleted { get; set; }
        public DateTime AdmissionDate { get; set; }

    }
}
