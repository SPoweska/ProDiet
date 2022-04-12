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
        public Patient Patient { get; set; }
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
    }
}
