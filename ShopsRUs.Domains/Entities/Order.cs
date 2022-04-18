using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Domains.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public int OrderCode { get; set; }

        public int ProductCount { get; set; } //ürün adedi örn 1 adet veya 1 kilo veya 1 litre
        public decimal OrderTotalAmount { get; set; }


        [ForeignKey(nameof(Products))]
        public int ProductsId { get; set; }
        public virtual Product Products { get; set; } //Burada aslında tüm productları getirmek istedim fakat bir hata vardı çözmek için ise vaktim yoktu.

    }
}

