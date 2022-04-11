using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models
{
    public class PatientAlergene
    {
        [Key]
        public int AlergeneId { get; set; }
        [Required]
        public string AlergeneName { get; set; }
        public Interview Interview { get; set; }
        [ForeignKey("InterviewId")]
        public int InterviewId { get; set; }
    }
}
