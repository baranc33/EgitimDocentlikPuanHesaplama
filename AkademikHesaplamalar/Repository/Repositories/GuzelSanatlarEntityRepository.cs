using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class GuzelSanatlarEntityRepository : GenericRepository<GuzelSanatlarEntity>, IGuzelSanatlarEntityRepository
    {
        public GuzelSanatlarEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
