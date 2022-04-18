using ClassLibrary3.Repositories.Abstract;
using ShopsRUs.DAL;
using ShopsRUs.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary3.Repositories.Concrete
{
    public class DiscountRepository : BaseRepository<DiscountTypes>, IDiscountTypesRepository
    {
        private ApiContext _context;
        public DiscountRepository(ApiContext context) : base(context)
        {
            _context = context; 
        }

        public ApiContext AppContext { get { return _context as ApiContext; } }
    }
}
