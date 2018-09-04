﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop_Model.Models
{
    [Table("SystemConfigs")]
    public class SystemConfig
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Code { get; set; }

        [MaxLength(250)]
        public string ValueString { get; set; }

        public int? ValueInt { get; set; }
    }
}