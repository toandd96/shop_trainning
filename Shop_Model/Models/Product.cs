using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Shop_Model.Abstract;

namespace Shop_Model.Models
{
    [Table("Products")]
    public class Product : IAuditable
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public string Alias { get; set; }
        public string CategoryID { get; set; }
        public XElement moreImages { get; set; }
        public decimal Price { get; set; }
        public decimal? Promotion { get; set; }
        public int? Warranty { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }

        public int? HomeFlag { get; set; } 
        public int? HotFlag { get; set; }
        public int? ViewCount { get; set; }
    }
}
