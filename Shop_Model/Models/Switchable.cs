using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop_Model.Abstract;

namespace Shop_Model.Models
{
    public class Switchable:ISwitchable
    {
        public bool Status { get; set; }
    }
}
