using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MuhendislikEntityService : Service<MuhendislikEntity>, IMuhendislikEntityService
    {
        public MuhendislikEntityService(IGenericRepository<MuhendislikEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
