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
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetApplicantById(int id)
        {
            var applicant = dbContext.Applicants.Find(id);
            if (applicant == null) 
            {
                return NotFound();
            }
            return Ok(applicant);
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
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateApplicant(int id, AddApplicantDto addApplicantDto)
        {
            var applicant = dbContext.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound("This Id Doesn't Exist");
            }


            applicant.FirstName = addApplicantDto.FirstName;
            applicant.MiddleName = addApplicantDto.MiddleName;
            applicant.LastName = addApplicantDto.LastName;
            applicant.Email = addApplicantDto.Email;
            applicant.PhoneNumber = addApplicantDto.PhoneNumber;
            applicant.Comment = addApplicantDto.Comment;
            applicant.LinkedIn = addApplicantDto.LinkedIn;
            applicant.GitHub = addApplicantDto.GitHub;
            dbContext.SaveChanges();
            return Ok("Your Data has been updated successfull!");
        }

    }
}
