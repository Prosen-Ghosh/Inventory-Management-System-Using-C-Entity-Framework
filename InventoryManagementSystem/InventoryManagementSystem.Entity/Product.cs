using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        public string ProductId { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        [Required]
        public int ProductQuantity{ get; set; }
        [StringLength(50)]
        public string SupplierId { get; set; }
        public int SerialNumber { get; set; }


        public virtual Supplier Suppliers { get; set; }
        public virtual Purchases Purchasess { get; set; }
        public virtual ICollection<Sales> sales { get; set; }

    }
}
