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
        MySqlDataAccess dataAccess;
        public RegistrationForm()
        {
            InitializeComponent();
            dataAccess = new MySqlDataAccess();
            var items = new List<object>();
            items.Add("select one");
            foreach(var item in Enum.GetValues(typeof(UserTypeEnum)))
            {
                items.Add(item);
            }
            
            cbUserType.DataSource = items;
            
            //PopulateCombobox<UserTypeEnum>(cbUserType);
            cbUserType.SelectedIndexChanged += CbUserType_SelectedIndexChanged;
            

        }

        private void CbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbUserType.SelectedValue.ToString());

            //var selectedItem = new KeyValuePair<string,int>();
        }

        private void PopulateCombobox<T>(ComboBox cb)
        {
            var usertypes =  EnumHelper.GetEnumDescriptionAndValue<T>();

            cbUserType.DisplayMember = "Key";
            cbUserType.ValueMember = "Value";

            cbUserType.DataSource = usertypes;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var sql = $"insert into Users(UserName,Password,UserType,ContactNumber,Address,DOB) values('{txtUserNmae.Text}'," +
                $"'{txtPassword.Text}','{cbUserType.SelectedIndex-1}'," +
                $"'{txtContactNumber.Text}','{txtAreaAddress.Text}','{dtpDob.Value.ToString("yyyy-MM-dd HH:mm")}');";

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

        private void cbUserType_DropDownClosed(object sender, EventArgs e)
        {
           // MessageBox.Show(cbUserType.SelectedText);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpDob.Value.ToShortDateString());
        }
    }
}
