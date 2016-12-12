using System.Collections.Generic;
using UraEsewaApp.Models;
using UraEsewaApp.Models.Entities;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services.Abstract;

namespace UraEsewaApp.Services.Impl
{
    public class RequestService : IRequestService
    {
        private readonly IRequestRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public RequestService(IRequestRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public Request Add(Request entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;

        }

        public Request Update(Request entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(Request entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<Request> GetAll()
        {
            return repository.GetAll();
        }

        public Request GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}
