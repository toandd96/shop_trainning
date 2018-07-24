using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int ID { set; get; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string URL { get; set; }
        public int? DisplayOrder { get; set; }

        [Required]
        [ForeignKey("GroupID")]
        public virtual MenuGroup GroupId { get; set; }
        public string Target { get; set; }
        [Required]
        public int Status { get; set; }
    }
}