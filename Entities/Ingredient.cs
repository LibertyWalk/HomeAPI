using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeAPI.Entites {
    public class Ingredient {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public string Amount { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe Recipe { get; set; }

        public Guid RecipeId { get; set; }
    }
}