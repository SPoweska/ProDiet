using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models
{
    public class PatientIntolerance
    {
        [Key]
        public int IntoleranceId { get; set; }
        [Required]
        public string IntoleranceName { get; set; }
        public Interview Interview { get; set; }
        [ForeignKey("InterviewId")]
        public int InterviewId { get; set; }
    }
}
