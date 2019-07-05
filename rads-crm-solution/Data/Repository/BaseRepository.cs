using Data.Context;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private pmaContext _context;
        public BaseRepository()
        {
            _context = new pmaContext();
        }


        public void Insert(T obj)
        {
            _context.Set<T>().Add(obj);
            _context.SaveChanges();
        }

        public void Remove(int id)
        {
            _context.Set<T>().Remove(Select(id));
            _context.SaveChanges();
        }

        public T Select(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public IList<T> SelectAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Update(T obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
