using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private IColaboradorRepository _colaborador;
        private IMapper _mapper;

        public ColaboradorController(IMapper mapper,
            IColaboradorRepository colaborador)
        {
            _colaborador = colaborador;
            _mapper = mapper;
        }

        // GET: api/Colaborador
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _colaborador.SelectAllColaboradorAsync();
                if (results != null)
                    return Ok(_mapper.Map<IList<ColaboradorViewModel>>(results));

                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var results = await _colaborador.SelectColaboradorById(id);
                if (results != null)
                    return Ok(_mapper.Map<ColaboradorViewModel>(results));

                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(int id,[FromBody] ColaboradorViewModel colaborador)
        {
            try
            {
                await _colaborador.UpdateColaborador(id, _mapper.Map<Colaborador>(colaborador));

                return NoContent();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
