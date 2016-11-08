using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementSystem.Entity;
using InventoryManagementSystem.DataRepository;

namespace InventoryManagementSystem.UserInterface.UserControls
{

    public partial class UserControlCustomer : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<Customer> customerForUpdateOrDelete = new List<Customer>();

        public UserControlCustomer()
        {
            InitializeComponent();
            cbCustomerSearvhByIdOrName.Items.Add("Search By Id");
            cbCustomerSearvhByIdOrName.Items.Add("Search By Name");
            loadCustomer();
        }

        private void loadCustomer()
        {

            dataGridViewCustomer.Rows.Clear();
            var customerRepository = new CustomerDataRepository();
            List<Customer> tmp = customerRepository.GetAllCustomers();

            #region NOT USED FOR CHECK BOX
            //DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            ////dataGridViewCheckBoxColumn.ValueType = typeof(bool);
            //dataGridViewCheckBoxColumn.Name = "customerCheckBox";
            //dataGridViewCheckBoxColumn.HeaderText = "Select Customer";
            //dataGridViewCustomer.Columns.Add(dataGridViewCheckBoxColumn);
            #endregion
            foreach (Customer c in tmp)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewCustomer.Rows[0].Clone();
                row.Cells[0].Value = false;
                row.Cells[1].Value = c.CustomerId;
                row.Cells[2].Value = c.CustomerName;
                row.Cells[3].Value = c.CustomerEmail;
                row.Cells[4].Value = c.CustomerLocation;
                dataGridViewCustomer.Rows.Add(row);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustomerSearvhByIdOrName.SelectedItem.Equals("Search By Id")) {
                isSearchById = true;
                isSearchByName = false;
                tbCustomerSearchByIdOrName.Clear();
            }
            else if (cbCustomerSearvhByIdOrName.SelectedItem.Equals("Search By Name")) {
                isSearchById = false;
                isSearchByName = true;
                tbCustomerSearchByIdOrName.Clear();
            }
        }

        private void tbCustomerSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById) {
                string error;
                var customerRepository = new CustomerDataRepository();
                Customer c = customerRepository.GetCustomerById(tbCustomerSearchByIdOrName.Text, out error);
                if (c != null)
                {
                    dataGridViewCustomer.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridViewCustomer.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = c.CustomerId;
                    row.Cells[2].Value = c.CustomerName;
                    row.Cells[3].Value = c.CustomerEmail;
                    row.Cells[4].Value = c.CustomerLocation;
                    dataGridViewCustomer.Rows.Add(row);
                }
                else
                {
                    loadCustomer();
                }
            }
            else if (isSearchByName) {
                string error;
                var customerRepository = new CustomerDataRepository();
                List<Customer> tmp = customerRepository.GetCustomersByName(tbCustomerSearchByIdOrName.Text, out error);
                if (tmp != null)
                {
                    dataGridViewCustomer.Rows.Clear();
                    foreach (Customer c in tmp)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewCustomer.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = c.CustomerId;
                        row.Cells[2].Value = c.CustomerName;
                        row.Cells[3].Value = c.CustomerEmail;
                        row.Cells[4].Value = c.CustomerLocation;
                        dataGridViewCustomer.Rows.Add(row);
                    }
                }
                else
                {
                    loadCustomer();
                }
            }
        }

        private void btmCustomerUpdate_Click(object sender, EventArgs e)
        {
            customerForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Customer c = new Customer();
                    c.CustomerId = row.Cells[1].Value.ToString();
                    c.CustomerName = row.Cells[2].Value.ToString();
                    c.CustomerEmail = row.Cells[3].Value.ToString();
                    c.CustomerLocation = row.Cells[4].Value.ToString();
                    customerForUpdateOrDelete.Add(c);
                    isChecked = true;
                }
            }
            if (isChecked)
            {
                var customerRepository = new CustomerDataRepository();
                foreach (Customer c in customerForUpdateOrDelete)
                {
                    string error;
                    if (!customerRepository.updateSelectedCustomer(c, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadCustomer();
                MessageBox.Show("Customer Update Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnCreateNewCustomer_Click(object sender, EventArgs e)
        {
            CreateNewCustomer CNC = new CreateNewCustomer(this);
            CNC.Show();
            this.Enabled = false;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            customerForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewCustomer.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Customer c = new Customer();
                    c.CustomerId = row.Cells[1].Value.ToString();
                    c.CustomerName = row.Cells[2].Value.ToString();
                    c.CustomerEmail = row.Cells[3].Value.ToString();
                    c.CustomerLocation = row.Cells[4].Value.ToString();
                    customerForUpdateOrDelete.Add(c);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var customerRepository = new CustomerDataRepository();
                foreach (Customer c in customerForUpdateOrDelete)
                {
                    string error;
                    if (!customerRepository.deleteSelectedCustomer(c, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadCustomer();
                MessageBox.Show("Customer Delete Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void UserControlCustomer_Load(object sender, EventArgs e)
        {
            //loadCustomer();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadCustomer();
        }
    }
}
