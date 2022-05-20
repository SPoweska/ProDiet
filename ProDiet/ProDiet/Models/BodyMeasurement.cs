using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProDiet.Models
{
    public class BodyMeasurement : AuditableEntity
    {

        //Dodać minimalne i maksymalne wartości, sprawdzić walidacje


        [Key]
        public int MeasurementId { get; set; }
         
        public Patient Patient { get; set; }
        [Required]
        public int PatientId { get; set; }
        [Required]
        [Range(25, 350)]

        public float BodyWeight { get; set; }
        [Required]
        [Range(30, 250)]

        public float Height { get; set; }
        [Range(30, 250)]

        public float Waist { get; set; }
        [Range(30, 250)]
        public float Hips { get; set; }
        [Range(5, 300)]
        public float TotalBodyFat { get; set; }
        [Range(20,300 )]
        public float TotalBodyWater { get; set; }
        [Range(25, 300)]
        public float TotalBoneMineral { get; set; }
        [Required]
        public DateTime MeasurementDate { get; set; } = DateTime.Now;



    }
}
