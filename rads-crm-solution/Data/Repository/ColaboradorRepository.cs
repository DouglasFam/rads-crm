using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Repository.Base;
using Domain.Entities;
using Domain.Interfaces;

namespace Data.Repository
{
    public class ColaboradorRepository : BaseRepository<Colaborador> , IColaboradorRepository
    {
        public ColaboradorRepository()
        {
        }

        public async Task<Colaborador> SelectColaboradorById(int Id)
        {
            try
            {
                return await Select(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IList<Colaborador>> SelectAllColaboradorAsync()
        {
            try
            {
                return await SelectAllAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task CreateColaborador(Colaborador colaborador)
        {
            try
            {
               await Insert(colaborador);
            }
            catch(Exception ex)
            {
                throw ex;
            }

        }

        public async Task UpdateColaborador(int id, Colaborador colaborador)
        {
            try
            {
                await Update(id, colaborador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
