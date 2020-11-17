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
   public class RatingService
    {
        // private readonly GenericRepository<Ratings> ratingRepository;
        private readonly RatingRepository ratingRepository;
        private readonly GenericRepository<Ratings> ratingRepositoryG;
        public RatingService()
        {
            ratingRepository = new RatingRepository();
            ratingRepositoryG = new GenericRepository<Ratings>();
        }
        public int CreateEmptyRating()
        {
            var ratingDAL = new Ratings()
            {
                NumberOfRatings = 0,
                Score = 0.00m,
                SumRatings = 0
            };
           int id = ratingRepository.Create(ratingDAL);
            return id;

        }

        public void Delete(int id)
        {
            ratingRepositoryG.Delete(id);
        }

        public RatingsBL GetRatingByID(int id)
        {
           var ratingDAL = ratingRepositoryG.Get(id);

            var ratingBL = new RatingsBL()
            {
                RatingID = ratingDAL.RatingID,
                NumberOfRatings = ratingDAL.NumberOfRatings,
                Score = ratingDAL.Score,
                SumRatings = ratingDAL.SumRatings
            };
            return ratingBL;
        }


        public void UpdateRatingByRatingID(int id, int newScore)
        {
           
            var ratingDAL = ratingRepositoryG.Get(id);
            decimal newScoreRating = (decimal)(ratingDAL.SumRatings + newScore) / (decimal)(ratingDAL.NumberOfRatings + 1);
           var ratingDALNew = new Ratings() {
                RatingID = ratingDAL.RatingID,
                NumberOfRatings = ratingDAL.NumberOfRatings+1,
                Score = newScoreRating,
                SumRatings= ratingDAL.SumRatings + newScore
              
           };

            ratingRepository.Update(ratingDALNew);

        }
    }
}
