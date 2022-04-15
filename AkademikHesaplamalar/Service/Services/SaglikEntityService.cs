using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class SaglikEntityService : Service<SaglikEntity>, ISaglikEntityService
    {
        public SaglikEntityService(IGenericRepository<SaglikEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
