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
    public partial class UsersFrom : Form
    {
        public UsersFrom()
        {
            InitializeComponent();
        }

        private void UsersFrom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scoolManagementSystemDbDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.scoolManagementSystemDbDataSet.Users);

        }
    }
}
