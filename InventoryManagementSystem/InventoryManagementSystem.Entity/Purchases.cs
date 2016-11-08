using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("Purchases")]
    public class Purchases
    {
        [StringLength(50)]
        public string PurchaseId { get; set; }
        [StringLength(50)]
        public string SupplierId { get; set; }
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string PurchaseProductName { get; set; }
        public int PurchaseProductQuantity { get; set; }
        public decimal PurchaseProductPrice{ get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SerialNumber { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual User Users { get; set; }
        public virtual Supplier Suppliers { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
