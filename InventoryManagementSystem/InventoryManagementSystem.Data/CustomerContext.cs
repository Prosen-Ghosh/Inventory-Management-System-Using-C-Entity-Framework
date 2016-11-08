using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class CustomerContext
    {
        public List<Customer> GetAllCustomers()
        {
            using (var dbConext = new InventoryManagementSystemDataContext()) {
                return dbConext.Customers.ToList();
            }
        }
        public List<Customer> GetCustomersByName(string customerName,out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbConext = new InventoryManagementSystemDataContext())
                {
                    return dbConext.Customers.Where(c => c.CustomerName.Contains(customerName)).ToList();
                }
            }
            catch (Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public Customer GetCustomerById(string customerId,out string error){

            error = string.Empty;
            try { 
                using (var dbConext = new InventoryManagementSystemDataContext())
                {
                    return dbConext.Customers.Find(customerId);
                }
            }catch(Exception ex){
                error = ex.Message;
                return null;
            }
        }
        public bool CreateNewCustomer(Customer customer,out string error) {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    dbContext.Customers.Add(customer);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }
        public bool updateSelectedCustomer(Customer customer,out string error) {
            error = string.Empty;
            try {
                using (var dbContext = new InventoryManagementSystemDataContext()) {
                    var customerToUpdate = dbContext.Customers.SingleOrDefault(c => c.CustomerId == customer.CustomerId);
                    customerToUpdate.CustomerId = customer.CustomerId;
                    customerToUpdate.CustomerName = customer.CustomerName;
                    customerToUpdate.CustomerEmail = customer.CustomerEmail;
                    customerToUpdate.CustomerLocation = customer.CustomerLocation;
                    dbContext.SaveChanges();
                    return true;
                }
            }catch(Exception ex){
                error = ex.Message;
                return false;
            }
        }
        public bool deleteSelectedCustomer(Customer customer, out string error)
        {
            error = string.Empty;
            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var customerToDelete = dbContext.Customers.Find(customer.CustomerId);
                    dbContext.Customers.Remove(customerToDelete);
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
    }
}
