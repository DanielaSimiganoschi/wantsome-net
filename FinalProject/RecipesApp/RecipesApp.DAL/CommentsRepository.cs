using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
   public class CommentsRepository
    {
        private readonly RecipesDBEntities db;


        public CommentsRepository()
        {
            db = new RecipesDBEntities();

        }
        public int Create(Comments comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return comment.CommentID;

        }

        public List<CommentsRecipe> GetAllCommentsByRecipeID(int id)
        {
            return db.CommentsRecipe.Where(i => i.RecipeID == id).ToList();
        }

        public List<Comments> GetTextForRecipeComments(List<int> ids)
        {

            return db.Comments.Where(i => ids.Contains(i.CommentID)).ToList();
        }


    }
}
