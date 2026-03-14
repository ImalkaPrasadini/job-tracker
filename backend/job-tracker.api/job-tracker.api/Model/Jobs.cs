using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace job_tracker.api.Model
{
    [Table("Jobs")]
    public class Jobs
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int CompanyId { get; set; }
        public int StatusId { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public string JobType { get; set; } = string.Empty;

        public DateTime AppliedDate { get; set; }

        [Required, MaxLength(50)]
        public string Notes { get; set; } = string.Empty;
    }
}
