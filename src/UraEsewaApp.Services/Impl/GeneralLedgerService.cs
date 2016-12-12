using System.Collections.Generic;
using UraEsewaApp.Models.Entities;
using UraEsewaApp.Repository.Abstract;
using UraEsewaApp.Repository.Infrastructure;
using UraEsewaApp.Services.Abstract;

namespace UraEsewaApp.Services.Impl
{
    public class GeneralLedgerService : IGeneralLedgerService
    {
        private readonly IGeneralLedgerRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public GeneralLedgerService(IGeneralLedgerRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public GeneralLedger Add(GeneralLedger entity)
        {
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;

        }

        public GeneralLedger Update(GeneralLedger entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(GeneralLedger entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<GeneralLedger> GetAll()
        {
            return repository.GetAll();
        }

        public GeneralLedger GetById(long id)
        {
            return repository.GetById(id);
        }
    }
}
