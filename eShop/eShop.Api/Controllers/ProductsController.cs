using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eShop.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetProducts()
        {
            var prod1 = new {Name = "Laptop", Price = 100, Color = "Red"};
            var prod2 = new {Name = "PC", Price = 23, Color = "Blue"};
            var prod3 = new {Name = "Mouse", Price = 432, Color = "Black"};
            var products = new List<object>{prod1, prod2, prod3};
            return Ok(products);
        }
    }
}