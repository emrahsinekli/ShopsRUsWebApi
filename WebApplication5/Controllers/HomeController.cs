using ClassLibrary3;
using ShopsRUs.Domains;
using ShopsRUs.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class HomeController : ApiController
    {
        UnitOfWork _unitOfWork = new UnitOfWork(new ShopsRUs.DAL.ApiContext());

        [HttpGet]
        public IEnumerable<Invoice> GetAllInvoice()
        {
            var result = _unitOfWork.InvoiceRepository.GetAllInvoice();
            return result.ToList();
        }

        //[HttpPost]
        //public Invoice GetInvoiceByBillNumber(string billNumber)
        //{
        //    var result = _unitOfWork.InvoiceRepository.GetInvoiceWithCustomerByBillNumber(billNumber);
        //    return result;
        //}

        [HttpPost]
        public string ApplyDiscount(string billNumber)
        {
            var result = _unitOfWork.InvoiceRepository.GetInvoiceWithCustomerByBillNumber(billNumber);

            if (result.HasDiscountApplied)
            {
                return "Discount Applied Before!!";
            }

            var appliedInvoice = ApplyDiscount(result);
            return $"Discount Applied The last Orderf Total is : {appliedInvoice}"; 
        }

        private decimal ApplyDiscount(Invoice invoice)
        {
            var discounts = _unitOfWork.DiscountRepository.GetAll(); // Discount tablosundan indirim listesini getir.
            Customer customer = invoice.Users;
            decimal totalDiscount = 0, lastOrderTotal = 0;
            int forEvery = 100;

            var orderAndOrderOfProducts = _unitOfWork.OrdersRepository.GetProductsByOrderCode(invoice.OrderCode); //ilgili faturanın ürünlerini getir.


            foreach (var discount in discounts)
            {
                if (discount.Id.Equals(customer.CustomerTypesId) && discount.IsRatePercentage)
                {
                    int diffYears = new DateTime((DateTime.Now - customer.CreatedDate).Ticks).Year - 1;
                    if (customer.CustomerTypesId == 3 && diffYears < 2)
                    {
                        break; //Müşteri tipi customer ve 2 yıldan az müşteri ise percentage indirimi uygulama!!!
                    }
                    foreach (var i in orderAndOrderOfProducts) // Her bir ürünün categorisini kontrol edip ürün başı indirim uygula
                    {
                        if (i.Products.CategoriesId != 1) // Category 1 == Groceries
                        {
                            var discountPerProduct = i.Products.ProductPrice * (discount.Rate / 100);
                            totalDiscount += discountPerProduct;
                        }
                    }
                }

                else if (discount.Id.Equals(customer.CustomerTypesId) && discount.IsRatePercentage)
                {
                    /* bir alttaki kodu buraya da yazarak sadece price discount olaranlar için inidirim yapabilirdim ama dokümanda
                       her kullanıcı için 100 dolarlık alışverişe 5 dolar indirim uygula gibi anladım bu yüzden aşağıya koydum. 
                    */
                }
                while (forEvery < invoice.OrderTotal) // Tüm müşteriler için her 100 dolarlık alışverişe 5 dolar indirim yap
                {
                    forEvery += 100;
                    totalDiscount += 5m;

                }
            }
            lastOrderTotal = invoice.OrderTotal - totalDiscount;
            return lastOrderTotal;
        }
    }
}
