using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopsRUs.Domains
{
    public   class BaseEntity
    {
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
