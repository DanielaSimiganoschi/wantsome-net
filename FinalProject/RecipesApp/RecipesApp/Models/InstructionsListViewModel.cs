using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class InstructionsListViewModel
    {
        public int RecipeID { get; set; }

        public int NrOfInstructions { get; set; }



        public List<InstructionViewModel> ListOfInstructions { get; set; }

        public InstructionsListViewModel()
        {
            ListOfInstructions = new List<InstructionViewModel>();
        }

    }
}