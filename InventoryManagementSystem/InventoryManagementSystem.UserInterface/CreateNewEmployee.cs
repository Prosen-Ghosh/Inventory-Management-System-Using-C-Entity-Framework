using InventoryManagementSystem.DataRepository;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserInterface
{
    public partial class CreateNewEmployee : Form
    {
        private UserControl userControl;
        public CreateNewEmployee(UserControl userControl)
        {
            this.userControl = userControl;
            InitializeComponent();
            comboBoxNewUserType.Items.Add("Admin");
            comboBoxNewUserType.Items.Add("Manager");
            comboBoxNewUserType.Items.Add("Cashier");
            comboBoxNewUserType.Items.Add("Worker");
            lvlNewUserPassword.Visible = false;
            tbNewUserPassword.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.UserId= tbNewUserId.Text.ToString();
            user.UserName = tbNewUserName.Text.ToString();
            user.UserEmail = tbNewUserEmail.Text.ToString();
            user.UserType = comboBoxNewUserType.SelectedItem.ToString();
            user.UserPhone = tbNewUserPhone.Text.ToString();
            user.UserAddress = tbNewUserAddress.ToString();
            user.UserPassword = tbNewUserPassword.Text.ToString();
            var createUser = new UserDataRepository();
            string error;
            if (createUser.CreateNewUser(user, out error))
            {
                MessageBox.Show("New User Created Successfully.");
            }
            else MessageBox.Show(error);

            //this will be last statment
            this.userControl.Enabled = true;
            this.Close();
        }

        private void comboBoxNewUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNewUserType.SelectedItem.Equals("Admin"))
            {
                lvlNewUserPassword.Visible = true;
                tbNewUserPassword.Visible = true;
            }
            else {
                lvlNewUserPassword.Visible = false;
                tbNewUserPassword.Visible = false;
            }
        }
    }
}
