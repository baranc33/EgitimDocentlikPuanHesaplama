using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class MuhendislikEntityRepository : GenericRepository<MuhendislikEntity>, IMuhendislikEntityRepository
    {
        public MuhendislikEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
