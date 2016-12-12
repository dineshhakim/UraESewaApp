using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UraEsewaApp.Models;
using UraEsewaApp.Models.Entities;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Impl
{
    public class GLTranDetailRepository : RepositoryBase<GLTranDetail>, IGLTranDetailRepository
    {
        public GLTranDetailRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
