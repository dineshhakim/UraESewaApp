using System;

namespace UraEsewaApp.Repository.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DatabaseContext Get();
    }
}