using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic.BusinessEntities
{
    public class InstructionsBL
    {
        public int InstructionID { get; set; }
        public int RecipeID { get; set; }
        public string InstructionText { get; set; }
    }
}
