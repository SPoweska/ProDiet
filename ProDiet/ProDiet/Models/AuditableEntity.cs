using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProDiet.Models
{
    public abstract class AuditableEntity
    {
        
        public string CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}