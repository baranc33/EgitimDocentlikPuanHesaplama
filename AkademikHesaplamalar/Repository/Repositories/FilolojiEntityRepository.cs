using Core.Models.Entities;
using Core.Repositories;

namespace Repository.Repositories
{
    public class FilolojiEntityRepository : GenericRepository<FilolojiEntity>, IFilolojiEntityRepository
    {
        public FilolojiEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
