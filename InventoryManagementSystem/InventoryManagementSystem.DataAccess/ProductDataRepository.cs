using InventoryManagementSystem.Data;
using InventoryManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.DataRepository
{
    public class ProductDataRepository
    {
        private readonly ProductContext _productContext;
        public ProductDataRepository(){
            _productContext  = new ProductContext();
        }
        public List<Product> GetAllProduct() {
            try
            {
                return _productContext.GetAllProduct();
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Product GetProductrById(string productId, out string error) {
            error = string.Empty;
            try
            {
                return _productContext.GetProductById(productId);
            }
            catch (Exception ex) {
                error = ex.Message;
                return null;
            }
        }

        public List<Product> GetProductrByName(string productName, out string error) {
            error = string.Empty;
            try
            {
                return _productContext.GetProductByName(productName);
            }
            catch (Exception ex) {
                error = ex.Message;
                return null;
            }
        }

        public bool updateSelectedProduct(Product product,out string error) {
            error = string.Empty;
            try
            {
                if (_productContext.updateSelectedProduct(product)) return true;
                return false;
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }

        public bool deleteSelectedProduct(Product product, out string error)
        {
            error = string.Empty;
            try {
                if (_productContext.deleteSelectedProduct(product)) return true;
                return false;
            }catch(Exception ex){

                error = ex.Message;
                return false;
            }
        }

        public bool CreateNewProduct(Product Product,out string error) {
            error = string.Empty;
            try
            {
                if (_productContext.CreateNewProduct(Product)) return true;
                return false;
            }
            catch (Exception ex) {
                error = ex.Message;
                return false;
            }
        }
    }
}
