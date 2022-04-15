using Core.Models;
using Core.Repositories;

namespace Repository.Repositories
{
    public class MyContactRepository : GenericRepository<MyContact>, IMyContactRepository
    {
        public MyContactRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
