using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models.DietPlan
{
    public class DietPlanDayDish : AuditableEntity
    {
        [Key]
        public int DayDishId { get; set; }
        public Dish Dish { get; set; }
        [Required]
        public int DishId { get; set; }
        public DayMeal DayMeal { get; set; }
        [Required]
        [ForeignKey("DayMealId")]
        public int DayMealId { get; set; }

        [Required]
        public float Carbohydrates { get; set; }
        [Required]
        public float Fats { get; set; }
        [Required]
        public float Proteins { get; set; }
        public float? Fiber { get; set; }
        [Required]
        public float Calories { get; set; }

        [Required]
        public int Servings { get; set; }
    }
}
