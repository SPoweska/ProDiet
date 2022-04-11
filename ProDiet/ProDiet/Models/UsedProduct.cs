using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProDiet.Models
{
    public class UsedProduct
    {

        //dopisać kaloryke itp
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

    }
}
