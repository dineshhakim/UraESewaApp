
using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Impl
{
    public class RequestRepository : RepositoryBase<Request>, IRequestRepository
    {
        public RequestRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
