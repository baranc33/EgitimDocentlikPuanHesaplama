using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class SporEntityService : Service<SporEntity>, ISporEntityService
    {
        public SporEntityService(IGenericRepository<SporEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
