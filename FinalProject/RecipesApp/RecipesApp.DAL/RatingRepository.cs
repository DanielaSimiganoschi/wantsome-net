using RecipesApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public void Update(Ratings rating)
        {
            var ratingInDb = db.Ratings.Find(rating.RatingID);

            if (ratingInDb == null)
            {
                return;
            }

            db.Entry(ratingInDb).CurrentValues.SetValues(rating);
            db.Entry(ratingInDb).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
