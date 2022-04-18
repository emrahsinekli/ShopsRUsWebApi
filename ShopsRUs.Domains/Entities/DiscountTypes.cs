using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopsRUs.Domains
{
    public class DiscountTypes 
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(35)]
        public string Type { get; set; }

        [Required]
        public decimal Rate { get; set; }
        public bool IsRatePercentage { get; set; }
    }
}
