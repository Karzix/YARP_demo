using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("product-api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetAll()
        {
            var listProduct = new List<string> { "product1", "product2", "product3" };
            return Ok(listProduct);
        }
    }
}
