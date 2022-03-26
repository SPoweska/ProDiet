

using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models
{
    public class Interview:AuditableEntity
    {
        [Key]
        public int InterviewId { get; set; }
        public Patient Patient { get; set; }
        [Required]
        public int PatientId { get; set; }
    }
}
