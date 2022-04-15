using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MyContactService : Service<MyContact>, IMyContactService
    {
        public MyContactService(IGenericRepository<MyContact> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
