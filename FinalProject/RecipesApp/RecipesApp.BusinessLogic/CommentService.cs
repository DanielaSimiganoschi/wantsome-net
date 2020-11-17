using RecipesApp.BusinessLogic.BusinessEntities;
using RecipesApp.DAL;
using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.BusinessLogic
{
    public class CommentService
    {
        private readonly GenericRepository<Comments> commentRepositoryG;
        private readonly GenericRepository<CommentsRecipe> commentsRecipeRepository;
        private readonly CommentsRepository commentRepository;

        public CommentService()
        {
            commentRepositoryG = new GenericRepository<Comments>();
            commentsRecipeRepository = new GenericRepository<CommentsRecipe>();
            commentRepository = new CommentsRepository();
        }

        public int CreateNewComment(string comment)
        {
            var commentDAL = new Comments()
            {
                Comment = comment
            };
            int id = commentRepository.Create(commentDAL);
            return id;

        }

        public void InsertCommentForRecipe(int idRecipe, int idComment)
        {
            var commentForRecipeDAL = new CommentsRecipe()
            {
                CommentID = idComment,
                RecipeID = idRecipe
            };
            commentsRecipeRepository.Create(commentForRecipeDAL);

        }

        public void DeleteCommentsForRecipe(int idRecipe)
        {
            var commentsForRecipe = commentRepository.GetAllCommentsByRecipeID(idRecipe);
            foreach(var c in commentsForRecipe)
            {
                commentsRecipeRepository.Delete(c.CommentsRecipeID);
                commentRepositoryG.Delete(c.CommentID);
            }
        }

        public List<CommentsRecipeBL> GetAllCommentsForRecipe(int idRecipe)
        {
            var listComments = commentRepository.GetAllCommentsByRecipeID(idRecipe); // lista comment ID / RecipeID
            var listIDSints = new List<int>();
            var listOfCommentsForRecipe = new List<CommentsRecipeBL>(); // CommentID/RecipeID/COmmentText
            foreach (var i in listComments)
            {
                listIDSints.Add(i.CommentID);
            }

            var listCommentText = commentRepository.GetTextForRecipeComments(listIDSints); // lista comments ptr Comment id uri

            for (var i = 0; i < listComments.Count(); i++)
            {
                for (var j = 0; j < listCommentText.Count(); j++)
                {
                    if (listComments[i].CommentID == listCommentText[j].CommentID)
                    {
                        listOfCommentsForRecipe.Add(new CommentsRecipeBL()
                        {
                            CommentID = listComments[i].CommentID,
                            CommentsRecipeID = listComments[i].CommentsRecipeID,
                            RecipeID = idRecipe,
                            CommentText = listCommentText[i].Comment
                        });
                    }
                }
            }
            return listOfCommentsForRecipe;

        }

    }
}
