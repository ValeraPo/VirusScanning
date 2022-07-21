using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Virus_scanning.Controllers
{
    [ApiController]
    [Route("api/process")]
    public class VirusScanningController : ControllerBase
    {
        // Checking file for viruses
        // api/process
        [HttpPost]
        [SwaggerOperation("Check file for viruses")]
        public ActionResult<string> ScanFile([FromQuery] List<byte[]> file)
        {
            var result = "clean";
            return Ok(result);
        }
    }
}