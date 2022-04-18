using ShopsRUs.Domains.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopsRUs.Domains
{
    public class Customer : BaseEntity
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string Surname { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public string FullName { get => $"{Name} {Surname}"; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        [Required]
        [MaxLength(13)]
        public string PhoneNumber { get; set; }

        [ForeignKey(nameof(CustomerTypes))]
        public int CustomerTypesId { get; set; }
        public CustomerType CustomerTypes { get; set; }
    }
}
