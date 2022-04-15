using Core;
using Core.Models.Entities;
using Core.Repositories;
using Core.Serviecs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class FenEntityService : Service<FenEntity>, IFenEntityService
    {
        public FenEntityService(IGenericRepository<FenEntity> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {}}
}
