using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models.DietPlan
{
    public class DietPlanDayDish : AuditableEntity
    {
        [Key]
        public int DayDishId { get; set; }
        public Dish Dish { get; set; }
        [Required]
        public int DishId { get; set; }
    }
}
