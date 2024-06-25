using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CartAPI.Controllers
{
    [Route("cart-api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Cart API2");
        }
    }
}
