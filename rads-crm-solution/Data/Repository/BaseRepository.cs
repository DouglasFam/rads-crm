using Data.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private pmaContext _context;
        public BaseRepository()
        {
            _context = new pmaContext();
        }


        public void Insert(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Set<TEntity>().Remove(Select(id));
            _context.SaveChanges();
        }

        public TEntity Select(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> SelectAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
