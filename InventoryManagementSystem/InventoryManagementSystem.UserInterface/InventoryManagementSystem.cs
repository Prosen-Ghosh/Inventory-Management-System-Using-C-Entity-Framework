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
    public partial class InventoryManagementSystem : Form
    {
       

        public InventoryManagementSystem()
        {
            InitializeComponent();
            var userControls = new UserControls.UserControlDashboard();
            userControls.Dock = DockStyle.Fill;
            tabPageDashboard.Controls.Add(userControls);
        }
        private void tabInventoryManagementSystem_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageCustomer) {
                TabControl(tabPageCustomer);
            }
            else if (e.TabPage == tabPageUsers) {
                TabControl(tabPageUsers);
            }
            else if (e.TabPage == tabPageSupplier) {
                TabControl(tabPageSupplier);
            }
            else if (e.TabPage == tabPagePurchase) {
                TabControl(tabPagePurchase);
            }
            else if (e.TabPage == tabPageSales)
            {
                TabControl(tabPageSales);
            }
            else if (e.TabPage == tabPageStock)
            {
                TabControl(tabPageStock);
            }
            else if (e.TabPage == tabPageDashboard)
            {
                TabControl(tabPageDashboard);
            }
        }
        private void TabControl(TabPage tabPage) {
            var userControls = new UserControl();
            if (tabPage.Equals(tabPageCustomer)) userControls = new UserControls.UserControlCustomer();
            else if (tabPage.Equals(tabPageUsers)) userControls = new UserControls.UserControlEmployee();
            else if (tabPage.Equals(tabPageSupplier)) userControls = new UserControls.UserControlSupplier();
            else if (tabPage.Equals(tabPagePurchase)) userControls = new UserControls.UserControlPurchase();
            else if (tabPage.Equals(tabPageSales)) userControls = new UserControls.UserControlSales();
            else if (tabPage.Equals(tabPageStock)) userControls = new UserControls.UserControlStock();
            else if (tabPage.Equals(tabPageDashboard)) userControls = new UserControls.UserControlDashboard();
            userControls.Dock = DockStyle.Fill;
            tabPage.Controls.Add(userControls);
        }

        private void InventoryManagementSystem_Load(object sender, EventArgs e)
        {

        }

        private void InventoryManagementSystem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
