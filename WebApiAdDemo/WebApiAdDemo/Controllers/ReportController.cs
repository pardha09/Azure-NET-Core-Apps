using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace WebApiAdDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequiredScope(RequiredScopesConfigurationKey ="AzureAd:scopes")]
    public class ReportController : ControllerBase
    {
        [Authorize(Roles = "Manager")]
        [HttpGet("[action]")]
        public IActionResult GetReport()
        {
            return File(System.IO.File.ReadAllBytes("C:\\Explore1\\Azure-NET-Core-Apps\\Report.pdf"), "appliction/pdf");
        }

        [Authorize]
        [HttpGet("[action]")]
        public IActionResult GetReportStatus()
        {
            return Ok(new { status = @"Report generated at -" + DateTime.Now.ToString("MM-dd-YYYY HH:mm:ss") });
        }
    }
}
