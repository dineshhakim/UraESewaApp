using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Impl
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
