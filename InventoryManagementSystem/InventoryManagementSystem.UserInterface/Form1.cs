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
    
    public partial class LoginForm : Form
    {
        public static string logedIn = "";
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try {
                if (tbUserId.Text == String.Empty || tbUserPassword.Text == String.Empty)
                {
                    this.Hide();
                    MessageBox.Show("The Feild is empty");
                    LoginForm LF = new LoginForm();
                    LF.Show();
                }
                else {
                    string error;
                    var adminRepository = new UserDataRepository();
                    User admin = adminRepository.GetUsersLoginInfo(tbUserId.Text.ToString(),out error);
                    if (admin != null && admin.UserId.Equals(tbUserId.Text.ToString()) && admin.UserPassword.Equals(tbUserPassword.Text.ToString()))
                    {
                        logedIn = tbUserId.Text.ToString();
                        this.Hide();
                        InventoryManagementSystem IMS = new InventoryManagementSystem();
                        IMS.Show();
                    }
                    else
                    {
                        Console.Beep(500, 200);
                        MessageBox.Show("You Enter Wrong User Name Or Password. ");
                    }
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
