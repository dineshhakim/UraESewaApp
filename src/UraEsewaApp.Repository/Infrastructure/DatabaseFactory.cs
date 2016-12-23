


using Microsoft.EntityFrameworkCore;
using UraEsewaApp.API.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private DatabaseContext dataContext;
        public DatabaseContext Get()
        {
            dataContext = dataContext ?? (dataContext = new DatabaseContext());
            dataContext.Database.EnsureCreated();
            return dataContext;
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }

}
