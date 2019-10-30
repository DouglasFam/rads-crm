using Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IColaboradorRepository
    {
        Task<IList<Colaborador>> SelectAllColaboradorAsync();
        Task<Colaborador> SelectColaboradorById(int Id);
        Task CreateColaborador(Colaborador colaborador);
        Task UpdateColaborador(int id, Colaborador colaborador);
    }
}
