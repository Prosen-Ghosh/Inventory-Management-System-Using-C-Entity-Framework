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
    public partial class UserControlSales : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<Sales> salesForUpdateOrDelete = new List<Sales>();
        public UserControlSales()
        {
            InitializeComponent();
            cbSalesSearchByIdOrName.Items.Add("Search By Id");
            loadSales();
        }

        private void loadSales() {
            try
            {
                dataGridViewSales.Rows.Clear();
                var salesRepository = new SalesDataRepository();
                var tmpSales = salesRepository.GetAllSales();
                if (tmpSales != null)
                {

                    foreach (Sales s in tmpSales)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewSales.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = s.SalesId;
                        row.Cells[2].Value = s.ProductId;
                        row.Cells[3].Value = s.SupplierId;
                        row.Cells[4].Value = s.CustomerId;
                        row.Cells[5].Value = s.UserId;
                        row.Cells[6].Value = Convert.ToString(s.SalesTax);
                        row.Cells[7].Value = Convert.ToString(s.SalesPrice);
                        row.Cells[8].Value = Convert.ToString(s.SalesQuantity);
                        row.Cells[9].Value = Convert.ToString(s.SalesDate);
                        dataGridViewSales.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.InnerException);
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSalesDelete_Click(object sender, EventArgs e)
        {
            salesForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewSales.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Sales s = new Sales();
                    s.SalesId = row.Cells[1].Value.ToString();
                    s.ProductId = row.Cells[2].Value.ToString();
                    s.SupplierId = row.Cells[3].Value.ToString();
                    s.CustomerId = row.Cells[4].Value.ToString();
                    s.UserId = row.Cells[5].Value.ToString();
                    s.SalesTax = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    s.SalesPrice = Convert.ToDecimal(row.Cells[7].Value.ToString());
                    s.SalesQuantity = Convert.ToInt32(row.Cells[8].Value.ToString());
                    s.SalesDate = Convert.ToDateTime(row.Cells[9].Value);
                    salesForUpdateOrDelete.Add(s);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var salesRepository = new SalesDataRepository();
                foreach (Sales s in salesForUpdateOrDelete)
                {
                    string error;
                    if (!salesRepository.deleteSelectedSales(s, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                if (!flags)
                {
                    loadSales();
                    MessageBox.Show("Sales Deleted Successfully.");
                }
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnCreateNewSales_Click(object sender, EventArgs e)
        {
            CreateNewSales CNS = new CreateNewSales();
            CNS.Show();
        }

        private void cbSalesSearchByIdOrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSalesSearchByIdOrName.SelectedItem.Equals("Search By Id"))
            {
                isSearchById = true;
                isSearchByName = false;
                tbSalesSearchByIdOrName.Clear();
            }
            else
            {
                isSearchById = false;
                isSearchByName = true;
                tbSalesSearchByIdOrName.Clear();
            }
        }

        private void tbSalesSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById)
            {
                string error;
                var salesRepository = new SalesDataRepository();
                Sales s = salesRepository.GetSalesbyId(tbSalesSearchByIdOrName.Text, out error);
                if (s != null)
                {
                    dataGridViewSales.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridViewSales.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = s.SalesId;
                    row.Cells[2].Value = s.ProductId;
                    row.Cells[3].Value = s.SupplierId;
                    row.Cells[4].Value = s.CustomerId;
                    row.Cells[5].Value = s.UserId;
                    row.Cells[6].Value = Convert.ToString(s.SalesTax);
                    row.Cells[7].Value = Convert.ToString(s.SalesPrice);
                    row.Cells[8].Value = Convert.ToString(s.SalesQuantity);
                    row.Cells[9].Value = Convert.ToString(s.SalesDate);
                    dataGridViewSales.Rows.Add(row);
                }
                else
                {
                    loadSales();
                }
            }
        }

        private void btnSalesUpdate_Click(object sender, EventArgs e)
        {
            salesForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewSales.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Sales s = new Sales();
                    s.SalesId = row.Cells[1].Value.ToString();
                    s.ProductId = row.Cells[2].Value.ToString();
                    s.SupplierId = row.Cells[3].Value.ToString();
                    s.CustomerId = row.Cells[4].Value.ToString();
                    s.UserId = row.Cells[5].Value.ToString();
                    s.SalesTax = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    s.SalesPrice = Convert.ToDecimal(row.Cells[7].Value.ToString());
                    s.SalesQuantity = Convert.ToInt32(row.Cells[7].Value.ToString());
                    s.SalesDate = Convert.ToDateTime(row.Cells[8].Value);
                    salesForUpdateOrDelete.Add(s);
                    isChecked = true;
                }
            }
            if (isChecked)
            {
                var salesRepository = new SalesDataRepository();
                foreach (Sales s in salesForUpdateOrDelete)
                {
                    string error;
                    if (!salesRepository.updateSelectedSales(s, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadSales();
                MessageBox.Show("Sales Update Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnSelsReport_Click(object sender, EventArgs e)
        {
            SalesReport SR = new SalesReport();
            SR.Show();
        }

        private void UserControlSales_Load(object sender, EventArgs e)
        {
            loadSales();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadSales();
        }
    }
}
