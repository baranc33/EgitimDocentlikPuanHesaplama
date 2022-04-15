using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class ilahiyatEntityRepository : GenericRepository<ilahiyatEntity>, IilahiyatEntityRepository
    {
        public ilahiyatEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
