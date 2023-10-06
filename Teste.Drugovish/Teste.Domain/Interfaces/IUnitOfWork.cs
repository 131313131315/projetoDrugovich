using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Domain.Interfaces
{
    public interface IUnitOfWork<T> where T : BaseEntity
    {
        IRepository<T> Repository { get; }
        Task<int> CommitAsync();
    }
}
