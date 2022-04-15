using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MimarlikEntityService : Service<MimarlikEntity>, IMimarlikEntityService
    {
        public MimarlikEntityService(IGenericRepository<MimarlikEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
