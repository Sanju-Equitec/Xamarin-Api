using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Http.Headers;
using System.IO;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HtmlController : Controller
    {
        
        [HttpGet]
        public ContentResult Get()
        {

            var fileContents =System.IO.File.ReadAllText("./Content/index.html");
            return new ContentResult
            {
                Content = fileContents,
                ContentType = "text/html"
            };
        }

    }
}
