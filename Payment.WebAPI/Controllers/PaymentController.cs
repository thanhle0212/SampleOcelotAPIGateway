using Microsoft.AspNetCore.Mvc;

namespace Payment.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        // GET api/values
        [HttpGet("GetPayment")]
        public string Get()
        {
            return "This Payment service";
        }
    }
}