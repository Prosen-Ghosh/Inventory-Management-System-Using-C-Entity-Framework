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
    public partial class CreateNewSales : Form
    {
        List<Product> forComboxProductId;
        public CreateNewSales()
        {
            InitializeComponent();
            tbUserId.Text = LoginForm.logedIn;
            loadValueToComboBox();
        }

        private void loadValueToComboBox(){
            try {
                forComboxProductId = new ProductDataRepository().GetAllProduct();
                if (forComboxProductId != null)
                {
                    foreach (Product p in forComboxProductId)
                    {
                        comboBoxProductId.Items.Add(p.ProductId);
                    }
                }
                var forComboxCustomerId = new CustomerDataRepository().GetAllCustomers();
                if (forComboxCustomerId != null) {
                    foreach (Customer c in forComboxCustomerId)
                    {
                        comboBoxCustomerId.Items.Add(c.CustomerId);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbSalesQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            isDigitValue(e);
        }

        private bool isDigitValue(KeyPressEventArgs kpev) {
            if (!char.IsDigit(kpev.KeyChar) && kpev.KeyChar != 8) {
                MessageBox.Show("Please Enter a Valid Value.");
                return false;
            }
            return true;
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void btnNewSalesSubmit_Click(object sender, EventArgs e)
        {
            string error;
            var product = new ProductDataRepository();
            Product tmpProduct = product.GetProductrById(comboBoxProductId.SelectedItem.ToString(),out error);

            if (tmpProduct.ProductQuantity >= Convert.ToInt32(tbSalesQuantity.Text))
            {
                tmpProduct.ProductQuantity -= Convert.ToInt32(tbSalesQuantity.Text);
                if (product.updateSelectedProduct(tmpProduct,out error)) {

                    var sales = new SalesDataRepository();
                    Sales tmpSales = new Sales();
                    tmpSales.SalesId = tbSalesId.Text;
                    tmpSales.ProductId = tmpProduct.ProductId;
                    tmpSales.SupplierId = tmpProduct.SupplierId;
                    tmpSales.CustomerId = comboBoxCustomerId.SelectedItem.ToString();
                    tmpSales.UserId = tbUserId.Text;
                    tmpSales.SalesTax = Convert.ToDecimal(tbSalesTax.Text.ToString());
                    tmpSales.SalesPrice = Convert.ToDecimal(tbSalesPrice.Text.ToString());
                    tmpSales.SalesQuantity = Convert.ToInt32(tbSalesQuantity.Text.ToString());
                    tmpSales.SalesDate = DateTime.Today;
                    if (sales.CreateNewSales(tmpSales,out error))
                    MessageBox.Show("Product Sales Successfull.");
                }
            }
            else {
                MessageBox.Show("Check Your Product Quantity.");
            }
            this.Close();
        }

        private void comboBoxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Product p in forComboxProductId)
                {
                    if (comboBoxProductId.SelectedItem.ToString().Equals(p.ProductId))
                    {
                        tbSupplierId.Text = p.SupplierId;
                        break;
                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
