using System.ComponentModel.DataAnnotations;
using ProDiet.Models;

namespace ProDiet.Data.Models
{
    public class Nutrient
    {

        [Key]
        public int NutrientId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public float Quantity { get; set; }

        //[Required]
        public Product Product { get; set; }

        [Required]
        public int ProductId { get; set; }
    }
}
