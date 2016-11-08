using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Data
{
    public class ProductContext
    {
        public List<Product> GetAllProduct() {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Products.ToList();
            }
        }

        public Product GetProductById(string productId) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Products.Where(p => p.ProductId.Contains(productId)).SingleOrDefault();
            }
        }

        public List<Product> GetProductByName(string productName) {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                return dbContext.Products.Where(p => p.ProductName.Contains(productName)).ToList();
            }
        }

        public bool updateSelectedProduct(Product product) {
            using (var dbContext = new InventoryManagementSystemDataContext())
            {
                var productToUpdate = dbContext.Products.SingleOrDefault(p => p.ProductId == product.ProductId);
                productToUpdate.ProductId = product.ProductId;
                productToUpdate.ProductName = product.ProductName;
                productToUpdate.ProductPrice = product.ProductPrice;
                productToUpdate.ProductQuantity = product.ProductQuantity;
                productToUpdate.SupplierId = product.SupplierId;
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool deleteSelectedProduct(Product product) {

            try
            {
                using (var dbContext = new InventoryManagementSystemDataContext())
                {
                    var productrToDelete = dbContext.Products.Find(product.ProductId);
                    dbContext.Products.Remove(productrToDelete);
                    dbContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CreateNewProduct(Product product)
        {
            using (var dbContext = new InventoryManagementSystemDataContext()) {
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
