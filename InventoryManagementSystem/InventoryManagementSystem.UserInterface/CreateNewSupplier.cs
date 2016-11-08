using InventoryManagementSystem.DataRepository;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.UserInterface
{
    public partial class CreateNewSupplier : Form
    {
        public CreateNewSupplier()
        {
            InitializeComponent();
        }

        private void btnNewSupplierSubmit_Click(object sender, EventArgs e)
        {

            Supplier supplier = new Supplier();
            supplier.SupplierId = tbSupplierId.Text;
            supplier.SupplierName = tbSupplierName.Text;
            supplier.SupplierAddress = tbSupplierAddress.Text;
            if (CheckForEmail(tbSupplierEmail.Text)) supplier.SupplierEmail = tbSupplierEmail.Text;
            else MessageBox.Show("Please Insert A valid Email.");
            supplier.SupplierPhone = tbSipplierPhone.Text;

            var createSupplier = new SupplierDataRepository();
            string error;
            if (createSupplier.CreateNewSupplier(supplier, out error))
            {
                MessageBox.Show("Supplier Created Successfully");
            }
            else MessageBox.Show(error);

            this.Close();
        }

        private bool CheckForEmail(string email)
        {
            bool IsValid = false;
            Regex r = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
              @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
              RegexOptions.IgnoreCase);
            if (r.IsMatch(email)) IsValid = true;
            return IsValid;
        }
    }
}
