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
    public partial class UsersForm2 : Form
    {
        UserRepo userRepo   ;
        int UserId = -1;
        public UsersForm2()
        {
            InitializeComponent();
            userRepo = new UserRepo();
        }

        private void UsersForm2_Load(object sender, EventArgs e)
        {
            updateUserGrid();


        }
        void updateUserGrid() {
            gvUsers.DataSource = userRepo.getAllUsers();
        }
        private void gvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gvUsers.Rows[e.RowIndex];
            var userName = row.Cells["UserName"].Value.ToString();

            UserId = Int32.Parse(row.Cells["Id"].Value.ToString());
            txtUserNmae.Text = userName;
            txtContactNumber.Text = row.Cells["Contact"].Value.ToString();
            txtAreaAddress.Text = row.Cells["Address"].Value.ToString();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var user = new User();
            if (UserId < 0)
            {
                MessageBox.Show("Please select a user");
                return;
            }
            user.Id = UserId;
            user.UserName = txtUserNmae.Text;
            user.ContactNumber = txtContactNumber.Text;
            user.Address = txtAreaAddress.Text;
            if (!userRepo.UpdateUser(user))
            {
                MessageBox.Show("Unable To Update User.");
                return;
            }
            updateUserGrid();
            MessageBox.Show("Update Success.");
            
        }
    }
}
