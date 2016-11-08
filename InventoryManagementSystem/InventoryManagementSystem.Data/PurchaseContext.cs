using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class PurchaseContext
    {
        public List<Purchases> GetAllPurchases() {
            using (var dbContext = new InventoryManagementSystemDataContext())
            {
                return dbContext.Purchasess.ToList();
            }
        }

        public List<Purchases> GetPurchasesbyId(string purchasesId, out string error) {

            error = string.Empty;
            try
            {
                using (var dbConext = new InventoryManagementSystemDataContext())
                {
                    return dbConext.Purchasess.Where(p => p.PurchaseId.Contains(purchasesId)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public List<Purchases> GetPurchasesbyName(string purchasesName, out string error)
        {

            error = string.Empty;
            try
            {
                using (var dbConext = new InventoryManagementSystemDataContext())
                {
                    return dbConext.Purchasess.Where(p => p.PurchaseProductName.Contains(purchasesName)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool PurchaseNewProduct(Purchases purchases, out string error) {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    dbContext.Purchasess.Add(purchases);
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex){
                error = ex.Message + " "+ "Prosen";
                return false;
            }
        }

        public bool updateSelectedPurchases(Purchases purchases, out string error) {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var purchasesToUpdate = dbContext.Purchasess.SingleOrDefault(p => p.PurchaseId == purchases.PurchaseId);
                    purchasesToUpdate.PurchaseId = purchases.PurchaseId;
                    purchasesToUpdate.SupplierId = purchases.SupplierId;
                    purchasesToUpdate.PurchaseProductName = purchases.PurchaseProductName;
                    purchasesToUpdate.PurchaseProductQuantity = purchases.PurchaseProductQuantity;
                    purchasesToUpdate.PurchaseProductPrice = purchases.PurchaseProductPrice;
                    purchasesToUpdate.UserId = purchases.UserId;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        public bool deleteSelectedPurchases(Purchases purchases, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var purchasesToDelete = dbContext.Purchasess.Find(purchases.SerialNumber);
                    dbContext.Purchasess.Remove(purchasesToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + " "+ purchases.SerialNumber;
                return false;
            }
        }

        public List<Purchases> GetPurchasesByDate(DateTime date) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Purchasess.Where(p => p.PurchaseDate.Equals(date)).ToList();
            }
        }
    }
}
