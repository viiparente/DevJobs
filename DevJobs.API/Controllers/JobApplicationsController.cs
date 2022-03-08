namespace DevJobs.API.Controllers
{
    using DevJobs.API.Entities;
    using DevJobs.API.Models;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/job-vacancies/{id}/applications")]
    [ApiController]
    public class JobApplicationsController : ControllerBase
    {

        // POST api/job-vacancies/4/applications
        [HttpPost]
        public IActionResult Post(int id, AddJobApplicationInputModel model)
        {
            return NoContent();
        }
    }
}
