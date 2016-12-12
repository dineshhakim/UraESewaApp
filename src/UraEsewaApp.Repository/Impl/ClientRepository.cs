using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Impl
{
    public class ClientRepository : RepositoryBase<Client>, IClientRepository
    {
        public ClientRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
