using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Model.Models
{
    [Table("Slides")]
    public class Slide
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SlideID { get; set; }
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        public string Description { get; set; }
        [Required]
        [MaxLength(500)]
        public string Image { get; set; }
        [Required]
        [MaxLength(500)]
        public string URL { get; set; }

        public int Display { get; set; }

        public int? Status { get; set; }
    }
}
