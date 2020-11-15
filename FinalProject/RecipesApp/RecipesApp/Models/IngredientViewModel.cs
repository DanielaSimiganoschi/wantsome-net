using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class IngredientViewModel
    {
        public int IngredientRecipeID { get; set; }
        public int IngredientID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Quantity { get; set; }


    }
}