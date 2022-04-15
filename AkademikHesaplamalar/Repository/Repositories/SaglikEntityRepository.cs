using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class SaglikEntityRepository : GenericRepository<SaglikEntity>, ISaglikEntityRepository
    {
        public SaglikEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
