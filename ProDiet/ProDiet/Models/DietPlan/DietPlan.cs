using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models.DietPlan
{
    public class DietPlan:AuditableEntity
    {
        [Key]
        public int DietPlanId { get; set; }
        [Required]
        public string DietPlanName { get; set; }

        public List<DietPlanDay>? DietPlanDays { get; set; } = new List<DietPlanDay>(); //konfiguracja
        public DateTime? DietPlanStartTime { get;}=DateTime.Now;
        public DateTime? DietPlanEndTime { get;}= DateTime.Now;
        
        [Required]
        public float DailyCarbohydrates { get; set; }
        [Required]
        public float DailyFats { get; set; }
        [Required]
        public float DailyProteins { get; set; }
        public float? DailyFiber { get; set; }
        [Required]
        public float DailyCalories { get; set; }

        [Required] 
        public List<Meal> Meals { get; set; } = new List<Meal>();//konfiguracja

        public string Recommendations { get; set; }

    }
}
