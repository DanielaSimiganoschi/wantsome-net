using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class RecipeViewModel
    {
        public int RecipeID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string LongDescription { get; set; }
        public int RatingID { get; set; }
        [Required]
        public string PictureLocation { get; set; }
        [Required]
        public int PrepTime { get; set; }
        [Required]
        public int CookTime { get; set; }
        [Required]
        public int NrOfIngredients { get; set; }
        [Required]
        public int NrOfInstructions { get; set; }
       
        public bool IsDeleted { get; set; }
        public List<CategoryViewModel> Categories { get; set; }

        public List<SubcategoryViewModel> Subcategories { get; set; }

        public List<IngredientViewModel> ListIngredients { get; set; }
        public List<InstructionViewModel> ListInstructions { get; set; }


        public RecipeViewModel()
        {
            Categories = new List<CategoryViewModel>();
            Subcategories = new List<SubcategoryViewModel>();
            ListIngredients = new List<IngredientViewModel>();
            ListInstructions = new List<InstructionViewModel>();

        }
    }
}