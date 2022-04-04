using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models
{
    public class BodyMeasurement : AuditableEntity
    {

        [Key]
        public int MeasurementId { get; set; }
         
        public Patient Patient { get; set; }
        [Required]
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        [Required]
        public float BodyWeight { get; set; }
        [Required]
        public float Height { get; set; }
        public float Waist { get; set; }
        public float Hips { get; set; }
        public float TotalBodyFat { get; set; }
        public float TotalBodyWater { get; set; }
        public float TotalBoneMineral { get; set; }
        [Required]
        public DateTime MeasurementDate { get; set; }



    }
}
