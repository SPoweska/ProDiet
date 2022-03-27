using System.ComponentModel.DataAnnotations;
using ProDiet.Data.Enums;

namespace ProDiet.Models
{
    public class HomeMeasurement
    {
        [Key]
        public int MeasurementId { get; set; }
        [Required]
        public string MeasurementName { get; set; }
        [Required]
        public float Mass { get; set; }
        
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}
