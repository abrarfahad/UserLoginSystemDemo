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
            //var user = userRepo.GetUserForLogin(txtUserNmae.Text, txtPassword.Text);
            if (!userRepo.IsUserValidForLogin(txtUserNmae.Text,txtPassword.Text)) {
                MessageBox.Show("Wrong User Name or Password!!!");
                return;
            }

            MessageBox.Show($"Welcome {txtUserNmae.Text}");
            this.Hide();
            UsersFrom usersFrom = new UsersFrom();
            usersFrom.Show();
            //if(user.UserType== (int)UserTypeEnum.Teacher)
            //{
            //    TeacherDetails teacherDetailsForm = new TeacherDetails(user);
            //    this.Hide();
            //    teacherDetailsForm.Show();
            //}
            //else if(user.UserType == (int)UserTypeEnum.Student)
            //{
            //    StudentDetails studentDetails = new StudentDetails(user);
            //    this.Hide();
            //    studentDetails.Show();
            //}
            
            
                
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            this.Hide();
            registrationForm.Show();
        }
    }
}
