using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [Required]
        public string CustomerId { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerName { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerEmail { get; set; }
        [StringLength(50)]
        [Required]
        public string CustomerLocation { get; set; }

        public virtual ICollection<Sales> saless { get; set; }
    }
}
