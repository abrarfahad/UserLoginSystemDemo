using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginSystem
{
    public partial class TeacherDetails : Form
    {
        public TeacherDetails(User user)
        {
            InitializeComponent();
            this.Text = $"Welcome {user.UserName} and You are a {(UserTypeEnum)user.UserType}";
        }
    }
}
