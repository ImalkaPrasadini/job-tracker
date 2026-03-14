using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace job_tracker.api.Model
{
    [Table("Interviews")]
    public class Interviews
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public int JobId { get; set; }
        
        [Required, MaxLength(50)]
        public string InterviewType { get; set; } = string.Empty;

        [Required, MaxLength(50)]
        public DateTime InterviewDate { get; set; }

        [Required, MaxLength(50)]
        public string Result { get; set; } = string.Empty;
    }
}
