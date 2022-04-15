using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class ZiraatEntityRepository : GenericRepository<ZiraatEntity>, IZiraatEntityRepository
    {
        public ZiraatEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
