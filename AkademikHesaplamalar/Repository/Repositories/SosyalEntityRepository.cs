using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class SosyalEntityRepository : GenericRepository<SosyalEntity>, ISosyalEntityRepository
    {
        public SosyalEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
