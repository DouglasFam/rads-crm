using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task Insert(TEntity obj);

        Task Update(int id, TEntity obj);

        Task Remove(int id);

        Task<TEntity> Select(int id);

        Task<IList<TEntity>> SelectAllAsync();
    }
}
