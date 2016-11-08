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
    public partial class UserControlStock : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<Product> productForUpdateOrDelete = new List<Product>();
        public UserControlStock()
        {
            InitializeComponent();
            cbStockSearchByIdOrName.Items.Add("Search By Id");
            cbStockSearchByIdOrName.Items.Add("Search By Name");
            loadProduct();
        }
        private void loadProduct(){

            dataGridViewStock.Rows.Clear();
            var productRepository = new ProductDataRepository();
            List<Product> tmpProduct = productRepository.GetAllProduct();
            if (tmpProduct != null) {
                foreach (Product p in tmpProduct)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewStock.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = p.ProductId;
                    row.Cells[2].Value = p.ProductName;
                    row.Cells[3].Value = p.ProductPrice;
                    row.Cells[4].Value = p.ProductQuantity;
                    row.Cells[5].Value = p.SupplierId;
                    dataGridViewStock.Rows.Add(row);
                }
            }
        }

        private void btnCreateNewStock_Click(object sender, EventArgs e)
        {

        }

        private void cbStockSearchByIdOrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStockSearchByIdOrName.SelectedItem.Equals("Search By Id"))
            {
                isSearchById = true;
                isSearchByName = false;
                tbStockSearchByIdOrName.Clear();
            }
            else if (cbStockSearchByIdOrName.SelectedItem.Equals("Search By Name"))
            {
                isSearchById = false;
                isSearchByName = true;
                tbStockSearchByIdOrName.Clear();
            }
        }

        private void tbStockSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById)
            {
                string error;
                var prosuctRepository = new ProductDataRepository();
                Product p = prosuctRepository.GetProductrById(tbStockSearchByIdOrName.Text, out error);
                if (p != null)
                {
                    dataGridViewStock.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridViewStock.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = p.ProductId;
                    row.Cells[2].Value = p.ProductName;
                    row.Cells[3].Value = p.ProductPrice;
                    row.Cells[4].Value = p.ProductQuantity;
                    row.Cells[5].Value = p.SupplierId;
                    dataGridViewStock.Rows.Add(row);
                }
                else
                {
                    loadProduct();
                }
            }
            else if (isSearchByName)
            {
                string error;
                var productRepository = new ProductDataRepository();
                List<Product> tmpProduct = productRepository.GetProductrByName(tbStockSearchByIdOrName.Text, out error);
                if (tmpProduct != null)
                {
                    dataGridViewStock.Rows.Clear();
                    foreach (Product p in tmpProduct)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewStock.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = p.ProductId;
                        row.Cells[2].Value = p.ProductName;
                        row.Cells[3].Value = p.ProductPrice;
                        row.Cells[4].Value = p.ProductQuantity;
                        row.Cells[5].Value = p.SupplierId;
                        dataGridViewStock.Rows.Add(row);
                    }
                }
                else
                {
                    loadProduct();
                }
            }
        }

        private void btnStockUpdate_Click(object sender, EventArgs e)
        {
            productForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewStock.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Product p = new Product();
                    p.ProductId = row.Cells[1].Value.ToString();
                    p.ProductName = row.Cells[2].Value.ToString();
                    p.ProductPrice = Convert.ToDecimal(row.Cells[3].Value.ToString());
                    p.ProductQuantity = Convert.ToInt32(row.Cells[4].Value.ToString());
                    p.SupplierId = row.Cells[5].Value.ToString();
                    productForUpdateOrDelete.Add(p);
                    isChecked = true;
                }
            }
            if (isChecked)
            {
                var productRepository = new ProductDataRepository();
                foreach (Product p in productForUpdateOrDelete)
                {
                    string error;
                    if (!productRepository.updateSelectedProduct(p, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadProduct();
                MessageBox.Show("Product Update Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnStockDelete_Click(object sender, EventArgs e)
        {
            productForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewStock.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Product p = new Product();
                    p.ProductId = row.Cells[1].Value.ToString();
                    p.ProductName= row.Cells[2].Value.ToString();
                    p.ProductPrice = Convert.ToDecimal(row.Cells[3].Value.ToString());
                    p.ProductQuantity = Convert.ToInt32(row.Cells[4].Value.ToString());
                    p.SupplierId = row.Cells[5].Value.ToString();
                    productForUpdateOrDelete.Add(p);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var productRepository = new ProductDataRepository();
                foreach (Product p in productForUpdateOrDelete)
                {
                    string error;
                    if (!productRepository.deleteSelectedProduct(p, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                if (!flags)
                {
                    loadProduct();
                    MessageBox.Show("Product Deleted Successfully.");
                }
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void UserControlStock_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadProduct();
        }
    }
}
