using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models.DietPlan
{
    public class DietPlan:AuditableEntity
    {
        [Key]
        public int DietPlanId { get; set; }
        [Required]
        public string DietPlanName { get; set; }
        public Patient Patient { get; set; }
        [Required]
        [ForeignKey("PatientId")]
        public int PatientId { get; set; }
        [Required]
        public int PlanDaysCount { get; set; }

        public List<DietPlanDay>? DietPlanDays { get; set; } = new List<DietPlanDay>(); //konfiguracja
        public DateTime? DietPlanStartTime { get;}=DateTime.Now;
        public DateTime? DietPlanEndTime { get;}= DateTime.Now;
        
        [Required]
        public float DailyCarbohydrates { get; set; }
        [Required]
        public float DailyFats { get; set; }
        [Required]
        public float DailyProteins { get; set; }
        public float DailyFiber { get; set; }
        [Required]
        public float DailyCalories { get; set; }

        public string? Recommendations { get; set; }

    }
}
