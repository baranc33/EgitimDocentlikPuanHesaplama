using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class AdminMemberService : Service<AdminMember>, IAdminMemberService
    {
        public AdminMemberService(IGenericRepository<AdminMember> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
