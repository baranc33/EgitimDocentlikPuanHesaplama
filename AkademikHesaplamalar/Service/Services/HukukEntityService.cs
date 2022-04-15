using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class HukukEntityService : Service<HukukEntity>, IHukukEntityService
    {
        public HukukEntityService(IGenericRepository<HukukEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
