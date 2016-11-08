using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class SupplierContext
    {
        public List<Supplier> GetAllSupplier() {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Suppliers.ToList();
            }
        }

        public Supplier GetSupplierById(string supplierId, out string error)
        { 
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    return dbContext.Suppliers.Where(s => s.SupplierId.Contains(supplierId)).SingleOrDefault();
                }
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public List<Supplier> GetSupplierByName(string supplierName, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    return dbContext.Suppliers.Where(s => s.SupplierId.Contains(supplierName)).ToList();
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        public bool CreateNewSupplier(Supplier supplier, out string error) {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    dbContext.Suppliers.Add(supplier);
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex){
                error = ex.Message;
                return false;
            }
        }

        public bool updateSelectedSupplier(Supplier supplier, out string error) {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    var supplierToUpdate = dbContext.Suppliers.SingleOrDefault(s => s.SupplierId == supplier.SupplierId);
                    supplierToUpdate.SupplierId = supplier.SupplierId;
                    supplierToUpdate.SupplierName = supplier.SupplierName;
                    supplierToUpdate.SupplierAddress = supplier.SupplierAddress;
                    supplierToUpdate.SupplierEmail = supplier.SupplierEmail;
                    supplierToUpdate.SupplierPhone = supplier.SupplierPhone;
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch(Exception ex){
                error = ex.Message;
                return false;
            }
        }

        public bool deleteSelectedSupplier(Supplier supplier, out string error)
        {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    var supplierToDelete = dbContext.Suppliers.Find(supplier.SupplierId);
                    dbContext.Suppliers.Remove(supplierToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex){
                error = ex.Message + "  " + supplier.SupplierName;
                return false;
            }
        }
    }
}
