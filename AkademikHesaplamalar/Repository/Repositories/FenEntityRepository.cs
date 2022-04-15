using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class FenEntityRepository : GenericRepository<FenEntity>, IFenEntityRepository
    {
        public FenEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
