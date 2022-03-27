﻿using System.ComponentModel.DataAnnotations;
using ProDiet.Data.Enums;
using ProDiet.Data.Models;

namespace ProDiet.Models
{
    public class Product:AuditableEntity
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float Carbohydrates { get; set; }
        [Required]
        public float Fats { get; set; }
        [Required]
        public float Proteins { get; set; }
        public float? Fiber { get; set; }
        [Required]
        public float Calories { get; set; }

        public ICollection<Alergene>? Alergenes { get; set; } = new List<Alergene>();
        public ICollection<Intolerance>? Intolerances { get; set; } = new List<Intolerance>();
        public ICollection<Nutrient>? Nutrients { get; set; } = new List<Nutrient>();
        public ICollection<HomeMeasurement>? HomeMeasurement { get; set; } = new List<HomeMeasurement>();
        [Required]
        public string ProductCategory { get; set; }
    }
}