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
    public class ProcessoController : ControllerBase
    {
        private ProcessoRepository _processo;
        private IMapper _mapper;
        public ProcessoController(IMapper mapper)
        {
            _processo = new ProcessoRepository();
            _mapper = mapper;
        }


        // GET: api/Processo
        [HttpGet]
        public IList<ProcessoViewModel> Get()
        {
            return _mapper.Map<IList<ProcessoViewModel>>(_processo.SelectAll());
        }

        // GET: api/Processo/5
        [HttpGet("{id}", Name = "GetProcesso")]
        public ProcessoViewModel Get(int id)
        {
            return _mapper.Map<ProcessoViewModel>(_processo.Select(id));
        }

        // POST: api/Processo
        [HttpPost]
        public void Post([FromBody] ProcessoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _processo.Insert(_mapper.Map<Processo>(obj));
            }
        }

        // PUT: api/Processo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ProcessoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _processo.Select(id);
                if(toUpdate != null)
                {
                    _processo.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _processo.Remove(id);
        }
    }
}
