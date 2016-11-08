using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Entity
{
    [Table("User")]
    public class User
    {
        [Key]
        public string UserId { get; set; }
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserEmail { get; set; }
        [StringLength(50)]
        public string UserAddress { get; set; }
        [StringLength(50)]
        public string UserPhone { get; set; }
        [StringLength(50)]
        public string UserType { get; set; }
        [StringLength(50)]
        public string UserPassword { get; set; }

        public virtual ICollection<Purchases> Purchases { get; set; }
        public virtual ICollection<Sales> Sales { get; set; }
    }
}
