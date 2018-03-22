using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MDC.Domain.Entities;
using MDC.Domain.Interfaces.Repository;
using MDC.Domain.Tools;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MDC.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("state")]
    public class StateController : Controller
    {
        private readonly IStateRepository _stateRepository;

        public StateController(IStateRepository stateRepository)
        {
            _stateRepository = stateRepository;
        }

        // GET: state
        [HttpGet]
        public IEnumerable<State> Get()
        {
            return _stateRepository.GetAll();
        }

        // GET: state/5
        [HttpGet("{id}", Name = "GetState")]
        public State Get(string id)
        {
            return _stateRepository.GetById(id);
        }
        
        // POST: state
        [HttpPost]
        public void Post([FromBody]State value)
        {
            value.Id = GuidSqlite.getGuid();
            _stateRepository.Add(value);
        }
        
        // PUT: state/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]State value)
        {
            _stateRepository.Update(value);
        }

        // DELETE: state/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _stateRepository.Remove(id);
        }
    }
}
