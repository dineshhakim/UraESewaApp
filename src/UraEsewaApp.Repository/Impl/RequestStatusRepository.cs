using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Impl
{
    public class RequestStatusRepository : RepositoryBase<RequestStatus>, IRequestStatusRepository
    {
        public RequestStatusRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
