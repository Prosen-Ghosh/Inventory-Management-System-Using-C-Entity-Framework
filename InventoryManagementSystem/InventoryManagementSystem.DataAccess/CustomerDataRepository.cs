using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class CustomerDataRepository
    {
        private CustomerContext _customerContext;
        public CustomerDataRepository() {
            _customerContext = new CustomerContext();
        }
        public List<Customer> GetAllCustomers() {
            return _customerContext.GetAllCustomers().ToList();
        }
        public List<Customer> GetCustomersByName(string customerName,out string error)
        {
            return _customerContext.GetCustomersByName(customerName,out error).ToList();
        }
        public Customer GetCustomerById(string customerId,out string error)
        {
            return _customerContext.GetCustomerById(customerId, out error);
        }
        public bool CreateNewCustomer(Customer customer,out string error) {
            if(_customerContext.CreateNewCustomer(customer,out error))return true;
            return false;
        }
        public bool updateSelectedCustomer(Customer customer,out string error) {
            if (_customerContext.updateSelectedCustomer(customer, out error)) return true;
            return false;
        }
        public bool deleteSelectedCustomer(Customer customer, out string error) {
            if (_customerContext.deleteSelectedCustomer(customer, out error)) return true;
            return false;
        }
    }
}
