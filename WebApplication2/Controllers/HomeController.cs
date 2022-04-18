using ClassLibrary3;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public IActionResult Index()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ShopsRUs.DAL.ApiContext());
            unitOfWork.InvoiceRepository.GetById(1);

            return View();
        }
    }
}