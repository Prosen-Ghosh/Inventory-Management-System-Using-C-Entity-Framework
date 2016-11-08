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
    public partial class UserControlDashboard : UserControl
    {
        public UserControlDashboard()
        {
            InitializeComponent();
            LoadChart();
        }
        private void LoadChart(){

            var purchaeseRepository = new PurchaseDataRepository();
            var purchaseValue = new Dictionary<string,decimal>();
            var purchasePrice = new Dictionary<string, decimal>();
            string[] purchaseYear = new string[4000] ;
            foreach (Purchases p in purchaeseRepository.GetAllPurchases()) {
                if (!purchaseValue.Equals(Convert.ToString(p.PurchaseDate.Year))) purchaseValue[Convert.ToString(p.PurchaseDate.Year)] = 0;
                     purchaseValue[Convert.ToString(p.PurchaseDate.Year)]=+ (p.PurchaseProductPrice*p.PurchaseProductQuantity);
                if (!purchasePrice.Equals(Convert.ToString(p.PurchaseDate.Year))) purchasePrice[Convert.ToString(p.PurchaseDate.Year)] = 0;
                purchasePrice[Convert.ToString(p.PurchaseDate.Year)] = +p.PurchaseProductPrice;
                if (string.IsNullOrEmpty(purchaseYear[Convert.ToInt32(p.PurchaseDate.Year)])) purchaseYear[Convert.ToInt32(p.PurchaseDate.Year)] = Convert.ToString(p.PurchaseDate.Year);
            }
            for (int x = 0; x < purchaseYear.Length; x++) {
                if(!string.IsNullOrEmpty(purchaseYear[x]))InventoryChart.Series["Purchases"].Points.AddXY(purchaseYear[x], purchaseValue[purchaseYear[x]]);
            }

            // For Sales chart

            var salesRepository = new SalesDataRepository();
            var salesValue = new Dictionary<string, decimal>();
            var salesQuantity = new Dictionary<string, decimal>();
            string[] salesYear = new string[4000];
            foreach (Sales s in salesRepository.GetAllSales())
            {
                if (!salesValue.Equals(Convert.ToString(s.SalesDate.Year))) salesValue[Convert.ToString(s.SalesDate.Year)] = 0;
                 salesValue[Convert.ToString(s.SalesDate.Year)] = +(s.SalesPrice * s.SalesQuantity);

                if (!salesQuantity.Equals(Convert.ToString(s.SalesDate.Year))) salesQuantity[Convert.ToString(s.SalesDate.Year)] = 0;
                salesQuantity[Convert.ToString(s.SalesDate.Year)] = +s.SalesQuantity;
               
                if (string.IsNullOrEmpty(salesYear[Convert.ToInt32(s.SalesDate.Year)])) salesYear[Convert.ToInt32(s.SalesDate.Year)] = Convert.ToString(s.SalesDate.Year);
            }
            for (int x = 0; x < salesYear.Length; x++)
            {
                if(!string.IsNullOrEmpty(salesYear[x]))InventoryChart.Series["Sales"].Points.AddXY(salesYear[x], salesValue[salesYear[x]]);
            }
            //For Profit Chart
            
            for (int x = 0; x < salesYear.Length; x++) {
                if (!string.IsNullOrEmpty(salesYear[x])) InventoryChart.Series["Profit"].Points.AddXY(salesYear[x], (salesValue[salesYear[x]] -(purchasePrice[salesYear[x]] * salesQuantity[salesYear[x]])));
            }
        }
    }
}
