using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HomeAPI.Entites {
    public class Recipe {

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public DateTime LastCooked { get; set; }
        public List<string> Notes { get; set; }
        public List<Ingredient> Ingredients { get; set; }

    }
}