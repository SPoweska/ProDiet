﻿

using System.ComponentModel.DataAnnotations;

namespace ProDiet.Models
{
    public class Interview:AuditableEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
