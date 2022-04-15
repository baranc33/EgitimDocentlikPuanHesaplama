using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class EgitimEntityService : Service<EgitimEntity>, IEgitimEntityService
    {
        public EgitimEntityService(IGenericRepository<EgitimEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
