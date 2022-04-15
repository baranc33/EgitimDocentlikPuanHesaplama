using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class SosyalEntityService : Service<SosyalEntity>, ISosyalEntityService
    {
        public SosyalEntityService(IGenericRepository<SosyalEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
