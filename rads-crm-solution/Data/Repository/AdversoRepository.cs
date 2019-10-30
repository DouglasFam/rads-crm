using Data.Repository.Base;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repository
{
    public class AdversoRepository : BaseRepository<Adverso>, IAdversoRepository
    {
        public AdversoRepository()
        {
        }
    }
}
