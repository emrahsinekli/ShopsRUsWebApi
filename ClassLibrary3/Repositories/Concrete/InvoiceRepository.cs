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
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        private ApiContext _context;
        public InvoiceRepository(ApiContext context) : base(context)
        {
            _context = context; 
        }


        IEnumerable<Invoice> IInvoiceRepository.GetAllInvoice()
        {
            this._context.Configuration.LazyLoadingEnabled = false;
            return _context.Invoices.Include("Users.CustomerTypes").Include("Orders.Products").ToList();
        }

        Invoice IInvoiceRepository.GetInvoiceWithCustomerByBillNumber(string billNumber)
        {
            return _context.Invoices.Include("Users.CustomerTypes").Include("Orders").Where(x => x.InvoiceNumber == billNumber).FirstOrDefault();
        }

        public ApiContext AppContext { get { return _context as ApiContext; } }
    }
}
