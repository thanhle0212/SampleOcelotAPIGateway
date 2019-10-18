using Microsoft.AspNetCore.Mvc;

namespace Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // GET api/values
        [HttpGet("GetProducts")]
        public string Get()
        {
            return "This Product service";
        }

    }
}