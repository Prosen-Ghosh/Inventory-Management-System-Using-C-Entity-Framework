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
    public partial class UserControlSupplier : UserControl
    {
        private bool isSearchById = false;
        private bool isSearchByName = false;

        private List<Supplier> SupplierForUpdateOrDelete = new List<Supplier>();

        public UserControlSupplier()
        {
            InitializeComponent();
            cbSupplierSearchByIdOrName.Items.Add("Search By Id");
            cbSupplierSearchByIdOrName.Items.Add("Search By Name");
            loadSupplier();
        }

        private void loadSupplier(){
            dataGridViewSupplier.Rows.Clear();
            var supplierRepository = new SupplierDataRepository();
            List<Supplier> tmpSupplier = supplierRepository.GetAllSupplier();
            foreach (Supplier s in tmpSupplier) {
                DataGridViewRow row = (DataGridViewRow)dataGridViewSupplier.Rows[0].Clone();
                row.Cells[0].Value = false;
                row.Cells[1].Value = s.SupplierId;
                row.Cells[2].Value = s.SupplierName;
                row.Cells[3].Value = s.SupplierAddress;
                row.Cells[4].Value = s.SupplierEmail;
                row.Cells[5].Value = s.SupplierPhone;
                dataGridViewSupplier.Rows.Add(row);
            }
        }
        private void cbSupplierSearvhByIdOrName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSupplierSearchByIdOrName.SelectedItem.Equals("Search By Id"))
            {
                isSearchById = true;
                isSearchByName = false;
                tbSupplierrSearchByIdOrName.Clear();
            }
            else if (cbSupplierSearchByIdOrName.SelectedItem.Equals("Search By Name"))
            {
                isSearchById = false;
                isSearchByName = true;
                tbSupplierrSearchByIdOrName.Clear();
            }
        }

        private void tbSupplierrSearchByIdOrName_TextChanged(object sender, EventArgs e)
        {
            if (isSearchById)
            {
                string error;
                var supplierRepository = new SupplierDataRepository();
                Supplier s = supplierRepository.GetSupplierById(tbSupplierrSearchByIdOrName.Text, out error);
                if (s != null)
                {
                    dataGridViewSupplier.Rows.Clear();
                    DataGridViewRow row = (DataGridViewRow)dataGridViewSupplier.Rows[0].Clone();
                    row.Cells[0].Value = false;
                    row.Cells[1].Value = s.SupplierId;
                    row.Cells[2].Value = s.SupplierName;
                    row.Cells[3].Value = s.SupplierAddress;
                    row.Cells[4].Value = s.SupplierEmail;
                    row.Cells[5].Value = s.SupplierPhone;
                    dataGridViewSupplier.Rows.Add(row);
                }
                else
                {
                    loadSupplier();
                }
            }
            else if (isSearchByName)
            {
                string error;
                var supplierRepository = new SupplierDataRepository();
                List<Supplier> tmpSupplier = supplierRepository.GetSupplierByName(tbSupplierrSearchByIdOrName.Text, out error);
                if (tmpSupplier != null)
                {
                    dataGridViewSupplier.Rows.Clear();
                    foreach (Supplier s in tmpSupplier)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewSupplier.Rows[0].Clone();
                        row.Cells[0].Value = false;
                        row.Cells[1].Value = s.SupplierId;
                        row.Cells[2].Value = s.SupplierName;
                        row.Cells[3].Value = s.SupplierAddress;
                        row.Cells[4].Value = s.SupplierEmail;
                        row.Cells[5].Value = s.SupplierPhone;
                        dataGridViewSupplier.Rows.Add(row);
                    }
                }
                else
                {
                    loadSupplier();
                }
            }
        }

        private void btmSupplierUpdate_Click(object sender, EventArgs e)
        {
            SupplierForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewSupplier.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Supplier s = new Supplier();
                    s.SupplierId = row.Cells[1].Value.ToString();
                    s.SupplierName = row.Cells[2].Value.ToString();
                    s.SupplierAddress = row.Cells[3].Value.ToString();
                    s.SupplierEmail = row.Cells[4].Value.ToString();
                    s.SupplierPhone = row.Cells[5].Value.ToString();
                    SupplierForUpdateOrDelete.Add(s);
                    isChecked = true;
                }
            }
            if (isChecked)
            {
                var supplierRepository = new SupplierDataRepository();
                foreach (Supplier s in SupplierForUpdateOrDelete)
                {
                    string error;
                    if (!supplierRepository.updateSelectedCustomer(s, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                loadSupplier();
                MessageBox.Show("Supplier Update Successfull.");
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnSupplierDelete_Click(object sender, EventArgs e)
        {
            SupplierForUpdateOrDelete.Clear();
            bool flags = false;
            string error_message = "";
            bool isChecked = false;
            foreach (DataGridViewRow row in dataGridViewSupplier.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    Supplier s = new Supplier();
                    s.SupplierId = row.Cells[1].Value.ToString();
                    s.SupplierName = row.Cells[2].Value.ToString();
                    s.SupplierAddress = row.Cells[3].Value.ToString();
                    s.SupplierEmail = row.Cells[4].Value.ToString();
                    s.SupplierPhone = row.Cells[5].Value.ToString();
                    SupplierForUpdateOrDelete.Add(s);
                    isChecked = true;
                }
            }
            if (isChecked)
            {

                var supplierRepository = new SupplierDataRepository();
                foreach (Supplier s in SupplierForUpdateOrDelete)
                {
                    string error;
                    if (!supplierRepository.deleteSelectedSupplier(s, out error))
                    {
                        flags = true;
                        error_message = error;
                        break;
                    }
                }
                if (!flags) {
                    loadSupplier();
                    MessageBox.Show("Supplier Deleted Successfully.");
                }
            }
            if (flags) MessageBox.Show(error_message);
        }

        private void btnCreateNewSupplier_Click(object sender, EventArgs e)
        {
            CreateNewSupplier CNS = new CreateNewSupplier();
            CNS.Show();
        }

        private void UserControlSupplier_Load(object sender, EventArgs e)
        {
            loadSupplier();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadSupplier();
        }
    }
}
