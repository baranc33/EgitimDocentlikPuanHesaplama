using Core;
using Core.Models;
using Core.Repositories;
using Core.Serviecs;

namespace Service.Services
{
    public class MessageService : Service<MyMessage>, IMessageService
    {
        public MessageService(IGenericRepository<MyMessage> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        { }
    }
}
