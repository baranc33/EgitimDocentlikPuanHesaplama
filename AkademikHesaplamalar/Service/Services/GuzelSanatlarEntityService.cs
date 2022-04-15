using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class GuzelSanatlarEntityService : Service<GuzelSanatlarEntity>, IGuzelSanatlarEntityService
    {
        public GuzelSanatlarEntityService(IGenericRepository<GuzelSanatlarEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
