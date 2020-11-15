using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesApp.DAL
{
   public class RatingRepository
    {

        private readonly RecipesDBEntities db;


        public RatingRepository()
        {
            db = new RecipesDBEntities();

        }
        public int Create(Ratings rating)
        {
            db.Ratings.Add(rating);
            db.SaveChanges();
            return rating.RatingID;

        }

      
    }
}
