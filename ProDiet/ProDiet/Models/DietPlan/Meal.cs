using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models.DietPlan
{
    public class Meal : AuditableEntity
    {
        [Key]
        public int MealId { get; set; }
        [Required]
        public int DietPlanId { get; set; }//dorobić konfiguracje
        [Required]
        public string MealName { get; set; }
        public float MealDailySharePercent { get; set;}
    }
}
