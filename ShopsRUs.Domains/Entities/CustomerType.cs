using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Domains.Entities
{
    public class CustomerType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        [Required]
        public string TypeCode { get; set; }
    }
}
