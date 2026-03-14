using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace job_tracker.api.Model
{
    [Table("Companies")]
    public class Companies
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required, MaxLength(50)]
        public string Industry { get; set; }

        [Required, MaxLength(50)]
        public string Location { get; set; }

        [Required, MaxLength(100)]
        public string WebSite { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
