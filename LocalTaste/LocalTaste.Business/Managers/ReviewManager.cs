using LocalTaste.Business.Managers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocalTaste.Domain.POCO;
using LocalTaste.Data.Repositories.Interfaces;

namespace LocalTaste.Business.Managers
{
    public class ReviewManager : IReviewManager
    {
        private readonly IReviewRepository ReviewRepo;

        public ReviewManager(IReviewRepository reviewRepo)
        {
            ReviewRepo = reviewRepo;
        }

        public Review Add(Review entity)
        {
            ReviewRepo.Add(entity);
            return entity;
        }

        public void Delete(int Id)
        {
            var poco = ReviewRepo.Get(Id);
            ReviewRepo.Delete(poco);
        }

        public Review Get(int Id)
        {
            return ReviewRepo.Get(Id);
        }

        public void Update(Review entity)
        {
            ReviewRepo.Update(entity);
        }
    }
}
