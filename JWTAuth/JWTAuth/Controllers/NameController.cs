using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet("GetNames")]
        public IActionResult GetNames()
        {
            return Ok(new List<string> { "Rupa","Sanju"});
        }
    }
}
