using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class SupplierDataRepository
    {
        private SupplierContext _supplierContext;
        public SupplierDataRepository() {
            _supplierContext = new SupplierContext();
        }

        public List<Supplier> GetAllSupplier() {
            try
            {
                return _supplierContext.GetAllSupplier();
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Supplier GetSupplierById(string supplierId, out string error) {
            try {
                return _supplierContext.GetSupplierById(supplierId, out error);
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public List<Supplier> GetSupplierByName(string supplierName, out string error) {
            try {
                return _supplierContext.GetSupplierByName(supplierName,out error);
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }

        public bool CreateNewSupplier(Supplier supplier, out string error) {
            if (_supplierContext.CreateNewSupplier(supplier, out error)) return true;
            return false;
        }

        public bool updateSelectedCustomer(Supplier supplier, out string error) {
            if (_supplierContext.updateSelectedSupplier(supplier, out error)) return true;
            return false;
        }
        public bool deleteSelectedSupplier(Supplier supplier, out string error) {
            
            if (_supplierContext.deleteSelectedSupplier(supplier, out error)) return true;
            return false;
        }
    }
}
