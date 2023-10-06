using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Teste.Data.Context;
using Teste.Domain;
using Teste.Domain.Interfaces;

namespace Teste.Data.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly MyContext _context;
        private readonly DbSet<T> _dataset;
        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataset = _context.Set<T>();
        }


        public async Task<T> InsertAsync(T item)
        {
            try
            {
                _dataset.Add(item);

                await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(t => t.Id == item.Id);
                if (result == null)
                    return null;

                _context.Entry(result).CurrentValues.SetValues(item);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }


        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(t => t.Id == id);
                if (result == null)
                    return false;
                _dataset.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<T> GetDataSet()
        {
            return _context.Set<T>();  //Verificar AsNoTracking 
        }


        public async Task<T> SelectAsync(int id)
        {
            try
            {
                return await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            try
            {
                return await _dataset.ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       
    }
}
