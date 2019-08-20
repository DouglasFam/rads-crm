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
    public class RamoController : ControllerBase
    {
        private RamoRepository _ramo;
        private IMapper _mapper;
        public RamoController(IMapper mapper)
        {
            _ramo = new RamoRepository();
            _mapper = mapper;
        }
        // GET: api/Ramo
        [HttpGet]
        public IList<RamoViewModel> Get()
        {
            return _mapper.Map<IList<RamoViewModel>>(_ramo.SelectAll());
        }

        // GET: api/Ramo/5
        [HttpGet("{id}", Name = "GetRamo")]
        public RamoViewModel Get(int id)
        {
            return _mapper.Map<RamoViewModel>(_ramo.Select(id));
        }

        // POST: api/Ramo
        [HttpPost]
        public void Post([FromBody] RamoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                _ramo.Insert(_mapper.Map<Ramo>(obj));
            }
        }

        // PUT: api/Ramo/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RamoViewModel obj)
        {
            if (ModelState.IsValid)
            {
                var toUpdate = _ramo.Select(id);
                if(toUpdate != null)
                {
                    _ramo.Update(toUpdate);
                }

            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ramo.Remove(id);
        }
    }
}
