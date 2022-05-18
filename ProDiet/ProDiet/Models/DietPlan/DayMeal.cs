using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models.DietPlan
{
    public class DayMeal : AuditableEntity
    {
        [Key]
        public int MealId { get; set; }
        [Required]
        public string Name { get; set; }

        public DietPlanDay DietPlanDay { get; set; }
        [Required]
        [ForeignKey("DietPlanDayId")]
        public int DietPlanDayId { get; set; }
        public MealDish MealDish { get; set; }

        [Required]
        public float Carbohydrates { get; set; }
        [Required]
        public float Fats { get; set; }
        [Required]
        public float Proteins { get; set; }
        public float Fiber { get; set; }
        [Required]
        public float Calories { get; set; }

    }
}
