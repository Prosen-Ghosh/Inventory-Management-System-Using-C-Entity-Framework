using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class InventoryManagementSystemDataContext:DbContext
    {
        private static System.Data.Entity.SqlServer.SqlProviderServices instance = 
            System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        public InventoryManagementSystemDataContext()
            : base("name=InventoryManagementSystemDataConection"){ 
            
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Purchases> Purchasess { get; set;}
        public virtual DbSet<Sales> Saless { get; set; }
     }
}
