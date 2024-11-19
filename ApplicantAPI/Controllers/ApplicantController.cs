using ApplicantAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApplicantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ApplicantController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllApplicant()
        {
            var allApplicant = dbContext.Applicants.ToList();
            return Ok(allApplicant);
        }
        [HttpPost]
        public IActionResult AddApplicant()
        {

        }
    }
}
