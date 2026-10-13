using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfOrderSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(10,0)")]
        public decimal Price { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

        [StringLength(300)]
        public string? ImagePath { get; set; }

        public bool IsSoldOut { get; set; }
        public bool IsActive { get; set; } = true;

        public Category? Category { get; set; }
    }
}
