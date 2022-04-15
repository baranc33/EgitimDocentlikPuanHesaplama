using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MyUserService : Service<MyUser>, IMyUserService
    {
        public MyUserService(IGenericRepository<MyUser> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
