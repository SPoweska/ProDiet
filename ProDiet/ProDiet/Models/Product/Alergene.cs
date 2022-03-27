using System.ComponentModel.DataAnnotations;
using ProDiet.Models;

namespace ProDiet.Data.Models
{
    public class Alergene
    {

        [Key]
        public int AlergeneId { get; set; }
        [Required]
        public string AlergeneName { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
