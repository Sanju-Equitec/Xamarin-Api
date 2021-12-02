using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace JWTAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportToCsvController : ControllerBase
    {
        [HttpGet]
        public FileResult Download()
        {
            string fileName = "foo.csv";
            byte[] fileBytes = Encoding.ASCII.GetBytes("Hello World"); ;

            return File(fileBytes, "text/csv", fileName); // this is the key!
        }
    }
}
