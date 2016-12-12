using System.Collections.Generic;
using UraEsewaApp.Models;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services.Abstract;

namespace UraEsewaApp.Services.Impl
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public ClientService(IClientRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public Client Add(Client entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;

        }

        public Client Update(Client entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(Client entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<Client> GetAll()
        {
            return repository.GetAll();
        }

        public Client GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}
