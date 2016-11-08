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
    public partial class CreateNewCustomer : Form
    {
        private UserControl userControl;
        public CreateNewCustomer(System.Windows.Forms.UserControl  userControl) {
            this.userControl = userControl;
            InitializeComponent();
        }
        #region Not Used
        //public CreateNewCustomer()
        //{
        //    InitializeComponent();
        //}
        #endregion
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.CustomerId = tbCustomerId.Text.ToString();
            customer.CustomerName = tbCustomerName.Text.ToString();
            customer.CustomerEmail = tbCustomerEmail.Text.ToString();
            customer.CustomerLocation = tbCustomerLocation.Text.ToString();
            var createCustomer = new CustomerDataRepository();
            string error;
            if (createCustomer.CreateNewCustomer(customer, out error))
            {
                MessageBox.Show("New Customer Created Sucessfully.");
            }
            else MessageBox.Show(error);
            //This is the Last Statment
            this.userControl.Enabled = true;
            this.Close();
        }
    }
}
