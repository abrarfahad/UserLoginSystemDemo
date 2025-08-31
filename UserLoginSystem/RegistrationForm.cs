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
    public partial class RegistrationForm : Form
    {
        DataAccess dataAccess;
        public RegistrationForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var sql = $"insert into Users(UserName,Password,UserType,ContactNumber,Address) values('{txtUserNmae.Text}'," +
                $"'{txtPassword.Text}','{txtUserType.Text}'," +
                $"'{txtContactNumber.Text}','{txtAreaAddress.Text}');";

            int results = dataAccess.ExecuteNonQuery(sql);
            if (results > 0)
            {
                MessageBox.Show("Registration Success.");
            }
            else
            {
                MessageBox.Show("Registration Failed.");
            }
        }
    }
}
