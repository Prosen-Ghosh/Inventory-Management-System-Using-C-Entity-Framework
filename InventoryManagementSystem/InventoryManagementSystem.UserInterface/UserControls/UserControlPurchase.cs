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
    public partial class UserControlPurchase : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<Purchases> purchasesForUpdateOrDelete = new List<Purchases>();

        public UserControlPurchase()
        {
            InitializeComponent();
            cbPurchaseSearchByIdOrName.Items.Add("Search By Id");
            cbPurchaseSearchByIdOrName.Items.Add("Search By Name");
            loadPurchase();
        }

        private void loadPurchase() {
            try
            {
                dataGridViewPurchase.Rows.Clear();
                var purchaseRepository = new PurchaseDataRepository();
                var tmpPurchases = purchaseRepository.GetAllPurchases();
                if (tmpPurchases != null) {

                    foreach (Purchases p in tmpPurchases)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPurchase.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = Convert.ToString(p.SerialNumber);
                        row.Cells[2].Value = p.PurchaseId;
                        row.Cells[3].Value = p.SupplierId;
                        row.Cells[4].Value = p.PurchaseProductName;
                        row.Cells[5].Value = Convert.ToString(p.PurchaseProductQuantity);
                        row.Cells[6].Value = Convert.ToString(p.PurchaseProductPrice);
                        row.Cells[7].Value = p.UserId;
                        row.Cells[8].Value = p.PurchaseDate;
                        dataGridViewPurchase.Rows.Add(row);
                    }
                }
                else MessageBox.Show("");
            }
            catch (Exception ex) {
                //Console.WriteLine(ex.InnerException);
                MessageBox.Show(ex.Message);
            }
        }
        private void cbPurchaseSearchByIdOrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPurchaseSearchByIdOrName.SelectedItem.Equals("Search By Id"))
            {
                isSearchById = true;
                isSearchByName = false;
                tbPurchaseSearchByIdOrName.Clear();
            }
            else if (cbPurchaseSearchByIdOrName.SelectedItem.Equals("Search By Name"))
            {
                isSearchById = false;
                isSearchByName = true;
                tbPurchaseSearchByIdOrName.Clear();
            }
        }

        private void tbPurchaseSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById)
            {
                string error;
                var purchaseRepository = new PurchaseDataRepository();
                List<Purchases> tmpPurchases = purchaseRepository.GetPurchasesbyId(tbPurchaseSearchByIdOrName.Text, out error);
                if (tmpPurchases != null)
                {
                    dataGridViewPurchase.Rows.Clear();
                    foreach (Purchases p in tmpPurchases)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPurchase.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = Convert.ToString(p.SerialNumber);
                        row.Cells[2].Value = p.PurchaseId;
                        row.Cells[3].Value = p.SupplierId;
                        row.Cells[4].Value = p.PurchaseProductName;
                        row.Cells[5].Value = Convert.ToString(p.PurchaseProductQuantity);
                        row.Cells[6].Value = Convert.ToString(p.PurchaseProductPrice);
                        row.Cells[7].Value = p.UserId;
                        row.Cells[8].Value = p.PurchaseDate;
                        dataGridViewPurchase.Rows.Add(row);
                    }
                }
                else
                {
                    loadPurchase();
                }
            }
            else if (isSearchByName)
            {
                string error;
                var purchaseRepository = new PurchaseDataRepository();
                List<Purchases> tmpPurchases = purchaseRepository.GetPurchasesbyName(tbPurchaseSearchByIdOrName.Text, out error);
                if (tmpPurchases != null)
                {
                    dataGridViewPurchase.Rows.Clear();
                    foreach (Purchases p in tmpPurchases)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPurchase.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = Convert.ToString(p.SerialNumber);
                        row.Cells[2].Value = p.PurchaseId;
                        row.Cells[3].Value = p.SupplierId;
                        row.Cells[4].Value = p.PurchaseProductName;
                        row.Cells[5].Value = Convert.ToString(p.PurchaseProductQuantity);
                        row.Cells[6].Value = Convert.ToString(p.PurchaseProductPrice);
                        row.Cells[7].Value = p.UserId;
                        row.Cells[8].Value = p.PurchaseDate;
                        dataGridViewPurchase.Rows.Add(row);
                    }
                }
                else
                {
                    loadPurchase();
                }
            }
        }

        private void btnCreateNewPurchase_Click(object sender, EventArgs e)
        {
            PurchaseNewProduct PNP = new PurchaseNewProduct();
            PNP.Show();
        }

        private void btmPurchaseUpdate_Click(object sender, EventArgs e)
        {
            purchasesForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewPurchase.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Purchases p = new Purchases();
                    p.SerialNumber = Convert.ToInt32(row.Cells[1].Value);
                    p.PurchaseId = row.Cells[2].Value.ToString();
                    p.SupplierId = row.Cells[3].Value.ToString();
                    p.PurchaseProductName = row.Cells[4].Value.ToString();
                    p.PurchaseProductQuantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                    p.PurchaseProductPrice = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    p.UserId = row.Cells[7].Value.ToString();
                    p.PurchaseDate = Convert.ToDateTime(row.Cells[8].Value);
                    purchasesForUpdateOrDelete.Add(p);
                    isChecked = true;
                }
            }
            if (isChecked)
            {
                var purchasesRepository = new PurchaseDataRepository();
                foreach (Purchases p in purchasesForUpdateOrDelete)
                {
                    string error;
                    if (!purchasesRepository.updateSelectedPurchases(p, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadPurchase();
                MessageBox.Show("Purchases Update Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnPurchaseDelete_Click(object sender, EventArgs e)
        {
            //This Function not Working Perfectly
            purchasesForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            int i = 1;
            foreach (DataGridViewRow row in dataGridViewPurchase.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Purchases p = new Purchases();
                    p.SerialNumber = Convert.ToInt32(row.Cells[1].Value);
                    p.PurchaseId = row.Cells[2].Value.ToString();
                    p.SupplierId = row.Cells[3].Value.ToString();
                    p.PurchaseProductName = row.Cells[4].Value.ToString();
                    p.PurchaseProductQuantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                    p.PurchaseProductPrice = Convert.ToDecimal(row.Cells[6].Value.ToString());
                    p.UserId = row.Cells[7].Value.ToString();
                    p.PurchaseDate = Convert.ToDateTime(row.Cells[8].Value);
                    purchasesForUpdateOrDelete.Add(p);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var purchasesRepository = new PurchaseDataRepository();
                foreach (Purchases p in purchasesForUpdateOrDelete)
                {
                    string error;
                    if (!purchasesRepository.deleteSelectedPurchases(p, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                if (!flags)
                {
                    loadPurchase();
                    MessageBox.Show("Purchases Deleted Successfully.");
                }
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnPurchesesReport_Click(object sender, EventArgs e)
        {
            PurchasesReport PR = new PurchasesReport();
            PR.Show();
        }

        private void UserControlPurchase_Load(object sender, EventArgs e)
        {
            loadPurchase();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadPurchase();
        }
    }
}
