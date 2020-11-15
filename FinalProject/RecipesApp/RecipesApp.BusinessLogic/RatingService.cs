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
    }
}
