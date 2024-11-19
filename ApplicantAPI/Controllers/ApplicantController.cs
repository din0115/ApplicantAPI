using ApplicantAPI.Data;
using ApplicantAPI.Models;
using ApplicantAPI.Models.Entities;
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
        public IActionResult AddApplicant(AddApplicantDto addApplicantDto)
        {
            var apllicantEntity = new Applicant()
            {
                FirstName= addApplicantDto.FirstName,
                MiddleName= addApplicantDto.MiddleName,
                LastName= addApplicantDto.LastName,
                Email= addApplicantDto.Email,
                PhoneNumber= addApplicantDto.PhoneNumber,
                Comment= addApplicantDto.Comment,
                LinkedIn= addApplicantDto.LinkedIn,
                GitHub = addApplicantDto.GitHub,

            };
            dbContext.Applicants.Add(apllicantEntity);
            dbContext.SaveChanges();
            return Ok("Your Data has been added successfull!");
        }
    }
}
