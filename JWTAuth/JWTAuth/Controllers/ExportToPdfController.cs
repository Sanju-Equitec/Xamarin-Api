using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace PDF_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExportToPdfController : ControllerBase
    {
        [HttpGet]
  
        public IActionResult PhysicalLocation()
        {
            string physicalPath = "./Content/Home Leave Reimbursement Report.pdf";
            byte[] pdfBytes = System.IO.File.ReadAllBytes(physicalPath);
            MemoryStream ms = new MemoryStream(pdfBytes);
            return new FileStreamResult(ms, "application/pdf");
        }


    }
}
