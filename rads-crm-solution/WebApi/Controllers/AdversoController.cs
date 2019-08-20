using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using WebApi.ModelView;
using Domain.Entities;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdversoController : ControllerBase
    {

        private AdversoRepository _adverso;
        private IMapper _mapper;

        public AdversoController(   IMapper mapper)
        {
            _adverso = new AdversoRepository();
            _mapper = mapper;
        }

        // GET: api/Adverso
        [HttpGet]
        public IList<AdversoViewModel> Get()
        {
            return _mapper.Map<IList<AdversoViewModel>>(_adverso.SelectAll());
        }

        // GET: api/Adverso/5
        [HttpGet("{id}", Name = "GetAdverso")]
        public AdversoViewModel Get(int id)
        {
            return _mapper.Map<AdversoViewModel>(_adverso.Select(id));
        }

        // POST: api/Adverso
        [HttpPost]
        public void Post([FromBody] AdversoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _adverso.Insert(_mapper.Map<Adverso>(obj));
            }
        }

        // PUT: api/Adverso/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] AdversoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _adverso.Select(id);
                if (toUpdate != null)
                {
                    _adverso.Update(toUpdate);
                }
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _adverso.Remove(id);
        }
    }
}
