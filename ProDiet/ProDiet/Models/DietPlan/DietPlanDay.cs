

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models.DietPlan
{
    public class DietPlanDay : AuditableEntity
    {
        [Key]
        public int DietPlanDayId { get; set; }

        public DietPlan DietPlan { get; set; }
        [Required]
        public int DietPlanId { get; set; }
        public DateTime ? DietPlanDayDate { get; set; }
        public List<DietPlanDayDish> DietPlanDayDish { get; set; }

        [Required]
        public float Carbohydrates { get; set; }
        [Required]
        public float Fats { get; set; }
        [Required]
        public float Proteins { get; set; }
        public float? Fiber { get; set; }
        [Required]
        public float Calories { get; set; }

    }
}
