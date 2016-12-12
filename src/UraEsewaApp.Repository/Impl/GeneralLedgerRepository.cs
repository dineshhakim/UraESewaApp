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
    public class GeneralLedgerRepository : RepositoryBase<GeneralLedger>, IGeneralLedgerRepository
    {
        public GeneralLedgerRepository(IDatabaseFactory databaseFactory) : base(databaseFactory)
        {
        }
    }
}
