using ClassLibrary3.Repositories.Abstract;
using ClassLibrary3.Repositories.Concrete;
using ShopsRUs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApiContext _context;

        public UnitOfWork(ApiContext context)
        {
            _context = context;
            InvoiceRepository = new InvoiceRepository(_context);
            DiscountRepository = new DiscountRepository(_context);
            OrdersRepository = new OrdersRepository(_context);
        }

        public IInvoiceRepository InvoiceRepository { get; private set; }
        public IDiscountTypesRepository DiscountRepository { get; private set; }

        public IOrdersRepository OrdersRepository { get; private set; }

        public void Dispose()
        {
          _context.Dispose();   
        }

       public int Complete()
        {
          return  _context.SaveChanges();
        }
    }
}
