using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FortniteRPC1.Models;



namespace FortniteRPC1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RPCController : ControllerBase
    {
        [HttpPost("use-potion")]
        public ActionResult<Response> UsePotion(Request request)
        {
            var newHealth = request.StartingHealth + request.Amount;

            return Ok(new Response
            {
                Success = true,
                NewHealth = newHealth
            });
        }

        [HttpPost("take-damage")]
        public ActionResult<Response> TakeDamage(Request request)
        {
            var newHealth = request.StartingHealth - request.Amount;

            return Ok(new Response
            {
                Success = newHealth > 0,
                NewHealth = newHealth
            });
        }
    }
}
