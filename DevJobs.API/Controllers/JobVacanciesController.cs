namespace DevJobs.API.Controllers
{
    using DevJobs.API.Entities;
    using DevJobs.API.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies")]
    [ApiController]
    public class JobVacanciesController : ControllerBase
    {

        // GET api/job-vacancies
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        // GET api/job-vacancies/4
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            //se nao existe e return NotFound();
            return Ok();
        }

        // POST api/job-vacancies
        [HttpPost]
        public IActionResult Post(AddJobVacancyInputModel model)
        {

            return CreatedAtAction("GetById", new { id = 1 }, model);
        }

        // PUT api/job-vacancies/4
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateJobVacancyInputModel model)
        {
            return NoContent();
        }
    }
}
