using Microsoft.AspNetCore.Mvc;
using Astras.JobPortal.API.Data;

namespace Astras.JobPortal.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JobsController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetJobs()
        {
            var jobs = _context.Jobs.ToList();
            return Ok(jobs);
        }
    }
}
