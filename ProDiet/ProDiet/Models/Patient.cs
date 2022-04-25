using System.ComponentModel.DataAnnotations;
using ProDiet.Data.Enums;

namespace ProDiet.Models
{
    public class Patient:AuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required] 
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public Interview Interview { get; set; }

        public List<BodyMeasurement> BodyMeasurements { get; set; } = new List<BodyMeasurement>();
        public List<PatientIntolerance> PatientIntolerances { get; set; } = new List<PatientIntolerance>();
        public List<PatientAlergene> PatientAlergenes { get; set; } = new List<PatientAlergene>();
        public int Height { get; set; }
        
        public int Weight { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public float? BMI { get; set; }
        public float? BMR { get; set; }
        public float? PAL { get; set; } //Współczynnik aktywności fizycznej
        public float? PPM { get; set; }
        public float? CPM { get; set; }
        public List<DietPlan.DietPlan> DietPlans { get; set; }


    }
}
