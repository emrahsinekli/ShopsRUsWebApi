using ShopsRUs.Domains.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopsRUs.Domains
{
    public class Invoice : BaseEntity
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        public string InvoiceNumber { get; set; } //Also bill number

        [Required]
        public decimal OrderTotal { get; set; }

        [Required]
        public decimal Total { get; set; }

        [Required]
        public bool HasDiscountApplied { get; set; } = false; //default false

        [ForeignKey(nameof(Users))]
        public int UserId { get; set; }
        public Customer Users { get; set; }

        [ForeignKey(nameof(Orders))]
        public int OrderCode { get; set; }
        public Order Orders { get; set; }

    }
}
