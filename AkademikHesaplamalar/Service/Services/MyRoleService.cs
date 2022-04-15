using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MyRoleService : Service<MyRole>, IMyRoleService
    {
        public MyRoleService(IGenericRepository<MyRole> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
