using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models
{
    public class UsedProduct
    {
        
        [Key]
        public int UsedProductId { get; set; }
        [Required]
        public Product Product { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        public Dish Dish { get; set; }
        [Required]
        public int DishId { get; set; }
        public int Quantity { get; set; }
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
