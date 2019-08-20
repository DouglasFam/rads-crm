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
    public class ContatoController : ControllerBase
    {
        private ContatoRepository _contato;
        private IMapper _mapper;

        public ContatoController(IMapper mapper)
        {
            _contato = new ContatoRepository();
            _mapper = mapper;
        }


        // GET: api/Contato
        [HttpGet]
        public IList<ContatoViewModel> Get()
        {
            return _mapper.Map<IList<ContatoViewModel>>(_contato.SelectAll());
        }

        // GET: api/Contato/5
        [HttpGet("{id}", Name = "GetContato")]
        public ContatoViewModel Get(int id)
        {
            return _mapper.Map<ContatoViewModel>(_contato.Select(id));
        }

        // POST: api/Contato
        [HttpPost]
        public void Post([FromBody]ContatoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _contato.Insert(_mapper.Map<Contato>(obj));
            }
        }

        // PUT: api/Contato/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ContatoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _contato.Select(id);
                if(toUpdate != null)
                {
                    _contato.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _contato.Remove(id);
        }
    }
}
