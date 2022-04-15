using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class ZiraatEntityService : Service<ZiraatEntity>, IZiraatEntityService
    {
        public ZiraatEntityService(IGenericRepository<ZiraatEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
