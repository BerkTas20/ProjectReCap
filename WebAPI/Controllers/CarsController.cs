using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        [HttpGet]
        public List<Car>Get() 
        {
          return new List<Car>()
          {
              new Car{CarId = 1, CarName="Bmw"},
              new Car{CarId = 2, CarName="Mercedes"},
          };
        }
    }
}
