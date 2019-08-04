using Domain.Entities;
using System.Collections.Generic;

namespace Data.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity obj);

        void Update(TEntity obj);

        void Remove(int id);

        TEntity Select(int id);

        IList<TEntity> SelectAll();
    }
}
