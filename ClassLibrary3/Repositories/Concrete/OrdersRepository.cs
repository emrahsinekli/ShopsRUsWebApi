using ClassLibrary3.Repositories.Abstract;
using ShopsRUs.DAL;
using ShopsRUs.Domains;
using ShopsRUs.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Repositories.Concrete
{
    public class OrdersRepository : BaseRepository<Order>, IOrdersRepository
    {
        private ApiContext _context;
        public OrdersRepository(ApiContext context) : base(context)
        {
            _context = context; 
        }
        public IEnumerable<Order> GetProductsByOrderCode(int orderCode)
        {
            return _context.Orders.Include("Products").Where(x => x.OrderCode == orderCode).ToList();
        }


        public ApiContext AppContext { get { return _context as ApiContext; } }

   
    }
}
