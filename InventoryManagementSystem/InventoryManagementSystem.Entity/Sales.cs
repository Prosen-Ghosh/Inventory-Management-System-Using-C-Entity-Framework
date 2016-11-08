using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("Sales")]
    public class Sales
    {
        [Key]
        public string SalesId { get; set; }
        [StringLength(50)]
        [Required]
        public string ProductId { get; set; }
        [StringLength(50)]
        [Required]
        public string SupplierId { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerId { get; set; }
        [StringLength(50)]
        [Required]
        public string UserId { get; set; }
        [Required]
        public decimal SalesTax { get; set; }
        [Required]
        public decimal SalesPrice { get; set; }
        [Required]
        public int SalesQuantity { get; set; }
        public DateTime SalesDate { get; set; }

        public virtual User Users { get; set; }
        public virtual Supplier Suppliers { get; set; }
        public virtual Customer Customers { get; set; }
        public virtual ICollection<Product> products { get; set; }
    }
}
