using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.DataRepository;
using InventoryManagementSystem.Entity;

namespace InventoryManagementSystem.UserInterface.UserControls
{
    public partial class UserControlEmployee : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<User> userForUpdateOrDelete = new List<User>();

        public UserControlEmployee()
        {
            InitializeComponent();
            cbEmployeeSearvhByIdOrName.Items.Add("Search By Id");
            cbEmployeeSearvhByIdOrName.Items.Add("Search By Name");
            loadUsers();
        }

        #region FOR PRIVATE FUNCTION
        private void loadUsers()
        {
            dataGridViewEmployee.Rows.Clear();
            var userRepository = new UserDataRepository();
            List<User> tmp = userRepository.GetAllUsers();

            foreach (User u in tmp)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewEmployee.Rows[0].Clone();
                row.Cells[0].Value = false;
                row.Cells[1].Value = u.UserId;
                row.Cells[2].Value = u.UserName;
                row.Cells[3].Value = u.UserType;
                row.Cells[4].Value = u.UserEmail;
                row.Cells[5].Value = u.UserPhone;
                row.Cells[6].Value = u.UserAddress;
                dataGridViewEmployee.Rows.Add(row);
            }
        }
        #endregion

        private void cbEmployeeSearvhByIdOrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmployeeSearvhByIdOrName.SelectedItem.Equals("Search By Id"))
            {
                isSearchById = true;
                isSearchByName = false;
                tbEmployeeSearchByIdOrName.Clear();
            }
            else if (cbEmployeeSearvhByIdOrName.SelectedItem.Equals("Search By Name"))
            {
                isSearchById = false;
                isSearchByName = true;
                tbEmployeeSearchByIdOrName.Clear();
            }
        }

        private void tbEmployeeSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById)
            {
                string error;
                var userRepository = new UserDataRepository();
                User u = userRepository.GetUserById(tbEmployeeSearchByIdOrName.Text, out error);
                if (u != null)
                {
                    dataGridViewEmployee.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridViewEmployee.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = u.UserId;
                    row.Cells[2].Value = u.UserName;
                    row.Cells[3].Value = u.UserType;
                    row.Cells[4].Value = u.UserEmail;
                    row.Cells[5].Value = u.UserPhone;
                    row.Cells[6].Value = u.UserAddress;
                    dataGridViewEmployee.Rows.Add(row);
                }
                else
                {
                    loadUsers();
                }
            }
            else if (isSearchByName)
            {
                string error;
                var userRepository = new UserDataRepository();
                List<User> tmp = userRepository.GetUserByName(tbEmployeeSearchByIdOrName.Text, out error);
                if (tmp != null)
                {
                    dataGridViewEmployee.Rows.Clear();
                    foreach (User u in tmp)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewEmployee.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = u.UserId;
                        row.Cells[2].Value = u.UserName;
                        row.Cells[3].Value = u.UserType;
                        row.Cells[4].Value = u.UserEmail;
                        row.Cells[5].Value = u.UserPhone;
                        row.Cells[6].Value = u.UserAddress;
                        dataGridViewEmployee.Rows.Add(row);
                    }
                }
                else
                {
                    loadUsers();
                }
            }
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            CreateNewEmployee CNE = new CreateNewEmployee(this);
            CNE.Show();
            this.Enabled = false;
        }

        private void btmEmployeUpdate_Click(object sender, EventArgs e)
        {
            userForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;

            try
            {
                foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {

                        User u = new User();
                        u.UserId = row.Cells[1].Value.ToString();
                        u.UserName = row.Cells[2].Value.ToString();
                        u.UserType = row.Cells[3].Value.ToString();
                        u.UserEmail = row.Cells[4].Value.ToString();
                        u.UserPhone = row.Cells[5].Value.ToString();
                        u.UserAddress = row.Cells[6].Value.ToString();
                        userForUpdateOrDelete.Add(u);
                        isChecked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                loadUsers();
                MessageBox.Show("Can Not Posible Update Operation.");
            }
            try
            {
                if (isChecked)
                {
                    var userRepository = new UserDataRepository();
                    foreach (User u in userForUpdateOrDelete)
                    {
                        string error;
                        if (!userRepository.updateSelectedUser(u, out error))
                        {
                            flags = true;
                            error_message = error;
                            break;
                        }
                    }
                    loadUsers();
                    MessageBox.Show("Employee Update Successfull.");
                }
                if (flags) MessageBox.Show(error_message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Employee Update Failed.");
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            userForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    User u = new User();
                    u.UserId = row.Cells[1].Value.ToString();
                    u.UserName = row.Cells[2].Value.ToString();
                    u.UserType = row.Cells[3].Value.ToString();
                    u.UserEmail = row.Cells[4].Value.ToString();
                    u.UserPhone = row.Cells[5].Value.ToString();
                    u.UserAddress = row.Cells[6].Value.ToString();
                    userForUpdateOrDelete.Add(u);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var userRepository = new UserDataRepository();
                foreach (User u in userForUpdateOrDelete)
                {
                    string error;
                    if (!userRepository.deleteSelectedUser(u, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadUsers();
                MessageBox.Show("Customer Delete Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void UserControlEmployee_Load(object sender, EventArgs e)
        {
            //loadUsers();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
}
