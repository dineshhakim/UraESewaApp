using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;


namespace UraEsewaApp.Repository.Impl
{
    public class RoleTypeRepository : RepositoryBase<RoleType>, IRoleTypeRepository
    {
        public RoleTypeRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
    }
}
}
