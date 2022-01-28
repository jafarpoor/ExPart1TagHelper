using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace ExTagHelper.Models
{
    public class ProductModelcs
    {
        public int Id { get; set; }

        [DisplayName("محصول")]
        public string Name { get; set; }
    }
}
