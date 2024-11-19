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
        [HttpPost]
        [Route("AddOrUpdate")]
        public IActionResult SaveUpdateApplicant([FromBody] AddApplicantDto addApplicantDto, [FromQuery] int? id = null)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); 
            }

            if (id == null || id == 0)
            {
                var applicantEntity = new Applicant
                {
                    FirstName = addApplicantDto.FirstName,
                    MiddleName = addApplicantDto.MiddleName,
                    LastName = addApplicantDto.LastName,
                    Email = addApplicantDto.Email,
                    PhoneNumber = addApplicantDto.PhoneNumber,
                    Comment = addApplicantDto.Comment,
                    LinkedIn = addApplicantDto.LinkedIn,
                    GitHub = addApplicantDto.GitHub,
                    CallTimeInterval = addApplicantDto.CallTimeInterval
                };

                dbContext.Applicants.Add(applicantEntity);
                dbContext.SaveChanges();

                return Ok("Your Data has been added successfully!");
            }
            else
            {
                var applicant = dbContext.Applicants.Find(id);
                if (applicant == null)
                {
                    return NotFound("This ID doesn't exist.");
                }

                applicant.FirstName = addApplicantDto.FirstName;
                applicant.MiddleName = addApplicantDto.MiddleName;
                applicant.LastName = addApplicantDto.LastName;
                applicant.Email = addApplicantDto.Email;
                applicant.PhoneNumber = addApplicantDto.PhoneNumber;
                applicant.Comment = addApplicantDto.Comment;
                applicant.LinkedIn = addApplicantDto.LinkedIn;
                applicant.GitHub = addApplicantDto.GitHub;
                applicant.CallTimeInterval = addApplicantDto.CallTimeInterval;

                dbContext.SaveChanges();

                return Ok("Your Data has been updated successfully.");
            }
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
                return NotFound("This Id Doesn't Exist");
            }
            return Ok(applicant);
        }
       

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DelApplicantById(int id)
        {
            var applicant = dbContext.Applicants.Find(id);
            if (applicant == null)
            {
                return NotFound("This Id Doesn't exist to delete");
            }
            dbContext.Applicants.Remove(applicant);
            dbContext.SaveChanges();
            return Ok(applicant.FirstName+ " " + applicant.MiddleName + " " + applicant.LastName + " delete successfull.");
        }
    }
}
