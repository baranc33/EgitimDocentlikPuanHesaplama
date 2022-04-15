using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class ilahiyatEntityService : Service<ilahiyatEntity>, IIlahiyatEntityService
    {
        public ilahiyatEntityService(IGenericRepository<ilahiyatEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
