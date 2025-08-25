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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUserNmae.Text !=null && txtUserNmae.Text.Trim() == "")
            {
                MessageBox.Show("Please Give an user name");
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please Give a Password!!!");
                return;
            }
            
            UserRepo userRepo = new UserRepo();
            //DESKTOP-JM75471\SQLEXPRESS
            var user = userRepo.GetUserForLogin(txtUserNmae.Text, txtPassword.Text);
            if (user == null) {
                MessageBox.Show("Wrong User Name or Password!!!");
                return;
            }

            MessageBox.Show($"Welcome {user.UserName}, Your User Type is {(UserTypeEnum)user.UserType}","Logged in");
            if(user.UserType== (int)UserTypeEnum.Teacher)
            {
                TeacherDetails teacherDetailsForm = new TeacherDetails(user);
                this.Hide();
                teacherDetailsForm.Show();
            }
            else if(user.UserType == (int)UserTypeEnum.Student)
            {
                StudentDetails studentDetails = new StudentDetails(user);
                this.Hide();
                studentDetails.Show();
            }
            
            
                
        }
    }
}
