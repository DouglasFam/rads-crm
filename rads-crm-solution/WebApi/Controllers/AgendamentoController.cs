using System;
using System.Collections;
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
    public class AgendamentoController : ControllerBase
    {
        private AgendamentoRepository _agendamento;
        private IMapper _mapper;
        public AgendamentoController(IMapper mapper)
        {
            _agendamento = new AgendamentoRepository();
            _mapper = mapper;
        }


        // GET: api/Agendamento
        [HttpGet]
        public IList<AgendamentoViewModel> Get()
        {
            return _mapper.Map<IList<AgendamentoViewModel>>(_agendamento.SelectAllAsync());
        }

        // GET: api/Agendamento/5
        [HttpGet("{id}", Name = "GetAgendamento")]
        public AgendamentoViewModel Get(int id)
        {
            return _mapper.Map<AgendamentoViewModel>(_agendamento.Select(id));
        }

        // POST: api/Agendamento
        [HttpPost]
        public void Post([FromBody] AgendamentoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _agendamento.Insert(_mapper.Map<Agendamento>(obj));
            }
        }

        // PUT: api/Agendamento/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AgendamentoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _agendamento.Select(id);
                if (toUpdate != null)
                {
                    _agendamento.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _agendamento.Remove(id);
        }
    }
}
