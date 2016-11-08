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
    public partial class PurchaseNewProduct : Form
    {
        public PurchaseNewProduct()
        {
            InitializeComponent();
            var supplierRepository = new SupplierDataRepository().GetAllSupplier();
            if (supplierRepository != null) {
                foreach (Supplier s in supplierRepository)
                {
                    comboBoxSupplierId.Items.Add(s.SupplierId.ToString());
                }
            }
        }

        private void btnPurchaseSubmit_Click(object sender, EventArgs e)
        {
            string error;
            try {
                Purchases purchases = new Purchases();
                purchases.PurchaseId = tbPurchaseId.Text;
                purchases.SupplierId = comboBoxSupplierId.SelectedItem.ToString();
                purchases.PurchaseProductName = tbProductName.Text;
                purchases.PurchaseProductQuantity = Convert.ToInt32(tbProductQuantity.Text.ToString());
                purchases.PurchaseProductPrice = Convert.ToDecimal(tbProductPrice.Text.ToString());
                purchases.UserId = LoginForm.logedIn;
                purchases.PurchaseDate = DateTime.Today;
                var purchasesNewProduct = new PurchaseDataRepository();

                if (purchasesNewProduct.PurchaseNewProduct(purchases, out error))
                {
                    var productUpdateOrCreate = new ProductDataRepository();
                    if (productUpdateOrCreate.GetProductrById(tbPurchaseId.Text, out error) == null)
                    {
                        Product product = new Product();
                        product.ProductId = purchases.PurchaseId;
                        product.ProductName = purchases.PurchaseProductName;
                        product.ProductPrice = purchases.PurchaseProductPrice;
                        product.ProductQuantity = purchases.PurchaseProductQuantity;
                        product.SupplierId = purchases.SupplierId;
                        product.SerialNumber = purchases.SerialNumber;
                        
                        productUpdateOrCreate.CreateNewProduct(product, out error);
                    }
                    else
                    {
                        Product product = productUpdateOrCreate.GetProductrById(tbPurchaseId.Text, out error);
                        product.ProductPrice += purchases.PurchaseProductPrice;
                        product.ProductQuantity += purchases.PurchaseProductQuantity;
                        if (!productUpdateOrCreate.updateSelectedProduct(product, out error))
                        {
                            MessageBox.Show("Updating Product Not Successfull.");
                        }
                        else MessageBox.Show("Updating Product Successfull.");
                    }
                    MessageBox.Show("Product Purchases Successfully.");
                    
                    this.Close();
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
