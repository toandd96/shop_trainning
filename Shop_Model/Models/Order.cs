using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(250)]
        public string CustomerName { get; set; }
        [MaxLength(250)]
        public string CustomerAddress { get; set; }
        [MaxLength(250)]
        public string  CustomerPhone{ get; set; }
        [MaxLength(250)]
        public string CustomEmail { get; set; }
        [MaxLength(250)]
        public string CustomerMessage { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateBy { get; set; }
        [MaxLength(250)]
        public string PaymentMethod{ get; set; }
        [Required]
        [MaxLength(50)]
        public string PaymentStatus { get; set; }
        [Required]
        public int Status { get; set; }

    }
}
