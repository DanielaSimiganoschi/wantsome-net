using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic.BusinessEntities
{
   public class RecipeBL
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public int RatingID { get; set; }
        public string PictureLocation { get; set; }

        public int PrepTime { get; set; }
        public int CookTime { get; set; }

    }
}
