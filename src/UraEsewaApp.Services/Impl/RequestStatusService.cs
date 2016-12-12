using System.Collections.Generic;
using UraEsewaApp.Models;
using UraEsewaApp.Models.Entities;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services.Abstract;


namespace UraEsewaApp.Services.Impl
{
    public class RequestStatusService : IRequestStatusService
    {
        private readonly IRequestStatusRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public RequestStatusService(IRequestStatusRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public RequestStatus Add(RequestStatus entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;

        }

        public RequestStatus Update(RequestStatus entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(RequestStatus entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<RequestStatus> GetAll()
        {
            return repository.GetAll();
        }

        public RequestStatus GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}
