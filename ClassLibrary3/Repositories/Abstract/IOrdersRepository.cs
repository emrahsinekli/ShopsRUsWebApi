using ShopsRUs.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Repositories.Abstract
{
    public interface IOrdersRepository : IBaseRepository<Order>
    {
        IEnumerable<Order> GetProductsByOrderCode(int orderCode);
    }
}
