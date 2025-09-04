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
            fileToolStripMenuItem.DropDownItems.Add("Open");
            fileToolStripMenuItem.DropDownItemClicked += FileToolStripMenuItem_DropDownItemClicked;
        }

        private void FileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
            MessageBox.Show("Meni Item clicked "+e.ClickedItem.Text);
            if (e.ClickedItem.Text == "Exit")
            {
                Application.Exit();
            }
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
            var path = @"C:\Users\Mou\source\repos\UserLoginSystem\UserLoginSystem\images\";
            pbUserPic.ImageLocation = $"{path}{UserId}.jpg";
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

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var pic = openFileDialog1.FileName;

                pbUserPic.ImageLocation = pic;
                Bitmap bitmap = new Bitmap(pic);
                if (UserId >= 0)
                {
                    var path = @"C:\Users\Mou\source\repos\UserLoginSystem\UserLoginSystem\images\";
                    bitmap.Save(path+UserId + ".jpg");
                }
                lblFileame.Text = pic;
            }
          
            //pbUserPic.Image;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem fileToolStripMenuItem = (ToolStripMenuItem)sender;
            
        }
    }
}
