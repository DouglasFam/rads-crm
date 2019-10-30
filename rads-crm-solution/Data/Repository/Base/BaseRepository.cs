using Data.Context;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected pmaContext _context;
        public BaseRepository()
        {
            _context = new pmaContext();
        }


        public async Task Insert(TEntity obj)
        {
            await _context.Set<TEntity>().AddAsync(obj);
            await _context.SaveChangesAsync();
        }

        public async Task Remove(int id)
        {
             _context.Set<TEntity>().Remove(await Select(id));
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> Select(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IList<TEntity>> SelectAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task Update(int id, TEntity obj)
        {
            var objExist = await Select(id);
            if(objExist != null)
            {
                _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}
