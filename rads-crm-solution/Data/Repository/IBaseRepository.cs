using Domain.Entities;
using System.Collections.Generic;

namespace Data.Repository
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Insert(T obj);

        void Update(T obj);

        void Remove(int id);

        T Select(int id);

        IList<T> SelectAll();
    }
}
