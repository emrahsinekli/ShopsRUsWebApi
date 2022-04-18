using ClassLibrary3.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3
{
    public interface IUnitOfWork:IDisposable
    {
        IInvoiceRepository InvoiceRepository { get; }
        IDiscountTypesRepository DiscountRepository { get; }

        IOrdersRepository OrdersRepository { get; }

        int Complete();
    }
}
