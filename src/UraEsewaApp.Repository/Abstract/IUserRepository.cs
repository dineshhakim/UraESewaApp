using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UraEsewaApp.Models;
using UraEsewaApp.Repository.Infrastructure;

namespace UraEsewaApp.Repository.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
