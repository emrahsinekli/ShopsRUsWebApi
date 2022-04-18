using ShopsRUs.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Repositories.Abstract
{
    public interface ICustomerRepository : IBaseRepository<Customer>
    {
        IEnumerable<Customer> GetCustomerWithCustomerType();
    }
}
