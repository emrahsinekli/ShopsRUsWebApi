using ClassLibrary3;
using ClassLibrary3.Repositories.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace ShopsRUsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet(Name = "GetWeatherForecast")]
        public ActionResult Get()
        {
            UnitOfWork unitOfWork = new UnitOfWork(new ShopsRUs.DAL.ApiContext());
            unitOfWork.InvoiceRepository.GetById(1);
            unitOfWork.Complete();

            return Ok();
        }
    }
}