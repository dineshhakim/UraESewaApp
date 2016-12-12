


using UraEsewaApp.API.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Infrastructure
{
   public class DatabaseFactory: Disposable, IDatabaseFactory
    {
        private DatabaseContext dataContext;
        public DatabaseContext Get()
        {
            return dataContext ?? (dataContext = new DatabaseContext());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
    
}
