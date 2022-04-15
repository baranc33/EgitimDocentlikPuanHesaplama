using Core.Models;
using Core.Repositories;

namespace Repository.Repositories
{
    public class MessageRepository : GenericRepository<MyMessage>, IMessageRepository
    {
        public MessageRepository(MyIdentityDbContext context) : base(context)
        { }
    }
}
