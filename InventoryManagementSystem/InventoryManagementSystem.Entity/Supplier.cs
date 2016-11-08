using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("Supplier")]
    public class Supplier
    {
        [Key]
        [Required]
        public string SupplierId { get; set; }

        [StringLength(50)]
        [Required]
        public string SupplierName { get; set; }
        [StringLength(50)]
        [Required]
        public string SupplierAddress { get; set; }
        [StringLength(50)]
        [Required]
        public string SupplierEmail { get; set; }
        [StringLength(50)]
        [Required]
        public string SupplierPhone { get; set; }

        public virtual ICollection<Purchases> Purchases { get; set; }
    }
}
