using Core.Models;
using Core.Repositories;

namespace Repository.Repositories
{
    public class AdminMemberRepository : GenericRepository<AdminMember>, IAdminMemberRepository
    {
        public AdminMemberRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
