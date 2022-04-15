using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class FilolojiEntityService : Service<FilolojiEntity>, IFilolojiEntityService
    {
        public FilolojiEntityService(IGenericRepository<FilolojiEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
