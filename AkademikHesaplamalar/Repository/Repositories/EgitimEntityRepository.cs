using Core.Models.Entities;
using Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{

    public class EgitimEntityRepository : GenericRepository<EgitimEntity>, IEgitimEntityRepository
    {
        public EgitimEntityRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
