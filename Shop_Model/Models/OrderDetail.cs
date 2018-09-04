using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        [Required]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Required]
        [Key]
        [Column(Order = 2)]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("OrderId")]
        public virtual Product Products { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Orders { get; set; }
    }
}
