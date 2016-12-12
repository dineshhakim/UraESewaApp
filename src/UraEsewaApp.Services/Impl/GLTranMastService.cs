using System.Collections.Generic;
using UraEsewaApp.Models.Entities;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services.Abstract;

namespace UraEsewaApp.Services.Impl
{
    public class GLTranMastService : IGLTranMastService
    {
        private readonly IGLTranMastRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public GLTranMastService(IGLTranMastRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public GLTranMast Add(GLTranMast entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;

        }

        public GLTranMast Update(GLTranMast entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(GLTranMast entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<GLTranMast> GetAll()
        {
            return repository.GetAll();
        }

        public GLTranMast GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}
