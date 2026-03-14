using job_tracker.api.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace job_tracker.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusMasterController : ControllerBase
    {
        private readonly JobTrackerDBContext _dbContext;

        public StatusMasterController(JobTrackerDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAllStatus")]
        public IActionResult GetAllStatus()
        {
            var statusList = _dbContext.Status.ToList();
            return Ok(statusList);
        }

        [HttpPost("AddStatus")]

        public IActionResult AddStatus(Status status)
        {
            _dbContext.Status.Add(status);
            _dbContext.SaveChanges();
            return Ok(status);
        }

        [HttpPut("UpdateStatus")]

        public IActionResult UpdateStatus(Status status) {  
            var existingStatus = _dbContext.Status.Find(status.ID);
            if (existingStatus == null)
            {
                return NotFound();
            }
            existingStatus.Name = status.Name;
            _dbContext.SaveChanges();
            return Ok(existingStatus);
        }

        [HttpDelete("DeleteStatus/{id}")]
        public IActionResult DeleteStatus(int id)
        {
            var existingStatus = _dbContext.Status.Find(id);
            if (existingStatus == null)
            {
                return NotFound();
            }

            _dbContext.Status.Remove(existingStatus);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
