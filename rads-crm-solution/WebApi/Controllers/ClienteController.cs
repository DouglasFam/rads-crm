using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Data.Repository;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using WebApi.ModelView;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class ClienteController : ControllerBase
    {
        private ClienteRepository _cliente;
        private IMapper _mapper;
        public ClienteController(IMapper mapper)
        {
            _cliente = new ClienteRepository();
            _mapper = mapper;
        }

        // GET: api/Cliente
        [HttpGet]
        public IList<ClienteViewModel> Get()
        {
            return _mapper.Map<IList<ClienteViewModel>>(_cliente.SelectAllAsync());
        }

        // GET: api/Cliente/5
        [HttpGet("{id}", Name = "GetCliente")]
        public ClienteViewModel Get(int id)
        {
            return _mapper.Map<ClienteViewModel>(_cliente.Select(id));
        }

        // POST: api/Cliente
        [HttpPost]
        public void Post([FromBody] ClienteViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _cliente.Insert(_mapper.Map<Cliente>(obj));
            }
        }

        // PUT: api/Cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] ClienteViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _cliente.Select(id);
                if(toUpdate != null)
                {
                    _cliente.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _cliente.Remove(id);
        }
    }
}
