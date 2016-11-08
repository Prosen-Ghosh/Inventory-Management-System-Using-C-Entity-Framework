using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class SalesContext
    {
        public List<Sales> GetAllSales() {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Saless.ToList();
            }
        }

        public Sales GetSalesbyId(string salesId) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Saless.Where(s => s.SalesId == salesId).SingleOrDefault();
            }
        }

        public bool updateSelectedSales(Sales sales) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                var salesToUpdate = dbContext.Saless.SingleOrDefault(s => s.SalesId == sales.SalesId);
                salesToUpdate.SalesId = sales.SalesId;
                salesToUpdate.ProductId = sales.ProductId;
                salesToUpdate.SupplierId = sales.SupplierId;
                salesToUpdate.CustomerId = sales.CustomerId;
                salesToUpdate.UserId = sales.UserId;
                salesToUpdate.SalesTax = sales.SalesTax;
                salesToUpdate.SalesPrice = sales.SalesPrice;
                salesToUpdate.SalesQuantity = sales.SalesQuantity;
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool deleteSelectedSales(Sales sales) {
            using (var dbContext = new InventoryManagementSystemDataContext())
            {
                var salesToDelete = dbContext.Saless.Find(sales.SalesId);
                dbContext.Saless.Remove(salesToDelete);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool CreateNewSales(Sales sales) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                dbContext.Saless.Add(sales);
                dbContext.SaveChanges();
                return true;
            }
        }

        public List<Sales> GetSalesByDate(DateTime date) {

            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Saless.Where(s => s.SalesDate.Equals(date)).ToList(); ;
            }
        }
    }
}
