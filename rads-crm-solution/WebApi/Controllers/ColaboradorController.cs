using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Repository;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {
        private ColaboradorRepository _colaborador;
        private IMapper _mapper;

        public ColaboradorController(IMapper mapper)
        {
            _colaborador = new ColaboradorRepository();
            _mapper = mapper;
        }

        // GET: api/Colaborador
        [HttpGet]
        public IList<ColaboradorViewModel> Get()
        {
            return _mapper.Map<IList<ColaboradorViewModel>>(_colaborador.SelectAll());
        }

        // GET: api/Colaborador/5
        [HttpGet("{id}", Name = "GetColaborador")]
        public ColaboradorViewModel Get(int id)
        {
            return _mapper.Map<ColaboradorViewModel>(_colaborador.Select(id));
        }

        // POST: api/Colaborador
        [HttpPost]
        public void Post([FromBody] ColaboradorViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _colaborador.Insert(_mapper.Map<Colaborador>(obj));
            }
        }

        // PUT: api/Colaborador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ColaboradorViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _colaborador.Select(id);
                if (toUpdate != null)
                {
                    _colaborador.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _colaborador.Remove(id);
        }
    }
}
