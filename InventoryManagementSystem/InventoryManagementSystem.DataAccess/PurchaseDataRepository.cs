using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class PurchaseDataRepository
    {
        private readonly PurchaseContext _purchaseContext;

        public PurchaseDataRepository() {
            _purchaseContext = new PurchaseContext();
        }

        public List<Purchases> GetAllPurchases()
        {
            return _purchaseContext.GetAllPurchases();
        }

        public List<Purchases> GetPurchasesbyId(string purchasesId,out string error) {
            error = string.Empty;
            try
            {
                return _purchaseContext.GetPurchasesbyId(purchasesId, out error);
            }
            catch (Exception ex) {
                error = ex.Message;
                return null;
            }
        }

        public List<Purchases> GetPurchasesbyName(string purchasesName, out string error)
        {
            error = string.Empty;
            try
            {
                return _purchaseContext.GetPurchasesbyName(purchasesName, out error);
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool PurchaseNewProduct(Purchases purchases, out string error) {
            try {
                if (_purchaseContext.PurchaseNewProduct(purchases, out error)) return true;
                return false;
            }catch(Exception ex){
                error = ex.Message;
                return false;
            }
        }

        public bool updateSelectedPurchases(Purchases purchases,out string error) {
            if (_purchaseContext.updateSelectedPurchases(purchases, out error)) return true;
            return false;
        }

        public bool deleteSelectedPurchases(Purchases purchases, out string error)
        {
            if (_purchaseContext.deleteSelectedPurchases(purchases, out error)) return true;
            return false;
        }

        public List<Purchases> GetPurchasesByDate(DateTime date,out string error) {
            error = string.Empty;
            try
            {
                return _purchaseContext.GetPurchasesByDate(date);
            }
            catch (Exception ex) {
                error = ex.Message;
                return null;
            }
        }
    }
}
