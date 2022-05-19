using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models
{
    public class Dish : AuditableEntity
    {
        [Key]
        public int DishId { get; set; }
        [Required]
        public string DishName { get; set; }

        public List<UsedProduct>? UsedProducts { get; set; } = new List<UsedProduct>();

        [Required]
        public float Carbohydrates { get; set; }
        [Required]
        public float Fats { get; set; }
        [Required]
        public float Proteins { get; set; }
        public float Fiber { get; set; }
        [Required]
        public float Calories { get; set; }

        [Required]
        public int Servings { get; set; }
        [Required]
        public int PreparationMinutes { get; set; }
        [Required]
        public string Recipe { get; set; }
        [Required]
        public string MealType { get; set; }


        public Dish ShallowCopy()
        {
            return (Dish)this.MemberwiseClone();
        }
    }
}
