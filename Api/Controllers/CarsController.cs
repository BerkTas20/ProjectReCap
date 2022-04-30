using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : Controller
    {
        [HttpGet]
        public List<Car>Get()
        {
            return new List<Car>
            {
                new Car{CarId = 1,CarName ="BMW"},
                new Car{CarId = 2,CarName ="Mercedes"},
            };
        }
    }
}
