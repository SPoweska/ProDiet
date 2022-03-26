using System.ComponentModel.DataAnnotations;
using ProDiet.Models;

namespace ProDiet.Data.Models
{
    public class Intolerance
    {
        [Key]
        public int IntoleranceId { get; set; }
        [Required] 
        public string IntoleranceName { get; set; }
        public Product Product  { get; set; }
        [Required]
        public int ProductId { get; set; }
        
    }
}
