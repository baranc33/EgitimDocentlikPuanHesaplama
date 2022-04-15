using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class MimarlikEntityRepository : GenericRepository<MimarlikEntity>, IMimarlikEntityRepository
    {
        public MimarlikEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
