﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Model.Abstract;

namespace Shop_Model.Models
{
    [Table("Posts")]
    public class Post:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [MaxLength(256)]
        public string Image { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }

        public string Content { get; set; }

        public int? HomeFlag { get; set; }

        public int? HotFlag { get; set; }

        public int? ViewCount { get; set; }
        [ForeignKey("CategoryID")]
        public virtual PostCategory PostCategory{ get; set; }

        public virtual IEnumerable<PostTag> PostTags{ get; set; }
    }
}
