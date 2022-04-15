using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class HukukEntityRepository : GenericRepository<HukukEntity>, IHukukEntityRepository
    {
        public HukukEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
