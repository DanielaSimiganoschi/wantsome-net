using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RecipesApp.Models
{
    public class CommentsViewModel
    {
        public int CommentsRecipeID { get; set; }
        public int CommentID { get; set; }
        public int RecipeID { get; set; }
        public string Comment { get; set; }
    }
}