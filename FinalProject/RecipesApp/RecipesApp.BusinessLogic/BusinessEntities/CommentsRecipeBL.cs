using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic.BusinessEntities
{
    public class CommentsRecipeBL
    {
        public int CommentsRecipeID { get; set; }
        public int CommentID { get; set; }
        public int RecipeID { get; set; }
        public string CommentText { get; set; }
    }
}
