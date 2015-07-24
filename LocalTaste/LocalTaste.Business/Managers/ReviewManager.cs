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
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Review Get(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Review entity)
        {
            throw new NotImplementedException();
        }
    }
}
