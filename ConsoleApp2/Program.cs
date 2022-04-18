using ClassLibrary3;
using ShopsRUs.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ApiContext());
            unitOfWork.InvoiceRepository.GetAll();
           var result = unitOfWork.InvoiceRepository.GetById(2);
            var a = unitOfWork.InvoiceRepository.GetAll();
            int i = 0; 
            Console.ReadKey();
        }
    }
}
