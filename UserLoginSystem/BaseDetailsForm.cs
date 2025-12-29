using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserLoginSystem
{
    public class BaseDetailsForm : Form
    {
        protected void SetWelcomeTitle(User user)
        {
            this.Text = $"Welcome {user.UserName} and You are a {(UserTypeEnum)user.UserType}";
        }
    }
}
