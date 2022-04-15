using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class SporEntityRepository : GenericRepository<SporEntity>, ISporEntityRepository
    {
        public SporEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
