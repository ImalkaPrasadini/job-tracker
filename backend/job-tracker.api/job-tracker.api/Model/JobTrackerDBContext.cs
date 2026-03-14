using Microsoft.EntityFrameworkCore;

namespace job_tracker.api.Model
{
    public class JobTrackerDBContext: DbContext
    {
        public JobTrackerDBContext(DbContextOptions<JobTrackerDBContext> options) : base(options) 
        {
            
        }

        public DbSet<Companies> Companies { get; set; }

        public DbSet<Jobs> Jobs { get; set; }

        public DbSet<Interviews> Interviews { get; set; }

        public DbSet<Status> Status { get; set; }
    }
}
