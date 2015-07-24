using LocalTaste.Domain.POCO;

namespace LocalTaste.Business.Managers.Interfaces
{
    public interface IReviewManager
    {
        Review Get(int Id);
        Review Add(Review entity);
        void Update(Review entity);
        void Delete(int Id);
    }
}
