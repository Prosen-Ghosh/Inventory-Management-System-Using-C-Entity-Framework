using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class SalesDataRepository
    {
        private SalesContext _salesContext;
        public SalesDataRepository() {
            _salesContext = new SalesContext();
        }
        public List<Sales> GetAllSales() {
            return _salesContext.GetAllSales();
        }

        public Sales GetSalesbyId(string salesId,out string error) {
            error = string.Empty;
            try {
                return _salesContext.GetSalesbyId(salesId);
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }

        public bool updateSelectedSales(Sales sales, out string error) {
            error = string.Empty;
            try
            {
                if (_salesContext.updateSelectedSales(sales)) return true;
                return false;
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }

        public bool deleteSelectedSales(Sales sales, out string error)
        {
            error = string.Empty;
            try
            {
                if (_salesContext.deleteSelectedSales(sales)) return true;
                return false;
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }

        public bool CreateNewSales(Sales sales, out string error) {
            error = string.Empty;
            try
            {
                if (_salesContext.CreateNewSales(sales)) return true;
                return false;
            }
            catch (Exception ex){
                error = ex.Message;
                return false;
            }
        }

        public List<Sales> GetSalesByDate(DateTime date,out string error) {
            error = string.Empty;
            try {
                return _salesContext.GetSalesByDate(date);
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
    }
}
