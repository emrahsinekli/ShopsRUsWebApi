using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Domains.Entities
{
    public class Product
    {
   
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal DerivedProductCost { get; set; }
        public int CategoriesId { get; set; }

    }
}
