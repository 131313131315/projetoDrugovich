using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Context;
using Teste.Domain.Interfaces;
using Teste.Domain;

namespace Teste.Data.Repositories
{
    public sealed class UnitOfWork<T> : IUnitOfWork<T>, IDisposable where T : BaseEntity
    {
        private readonly MyContext _context;
        public UnitOfWork(MyContext context, IRepository<T> repository)
        {
            _context = context;
            Repository = repository;
        }
        public IRepository<T> Repository { get; }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
