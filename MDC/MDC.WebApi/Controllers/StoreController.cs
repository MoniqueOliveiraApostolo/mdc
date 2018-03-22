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
    [Route("store")]
    public class StoreController : Controller
    {
        private readonly IStoreRepository _storeRepository;

        public StoreController(IStoreRepository storeRepository)
        {
            _storeRepository = storeRepository;
        }

        // GET: store
        [HttpGet]
        public IEnumerable<Store> Get()
        {
            return _storeRepository.GetAll();
        }

        // GET: store/5
        [HttpGet("{id}", Name = "GetStore")]
        public Store Get(string id)
        {
            return _storeRepository.GetById(id);
        }
        
        // POST: store
        [HttpPost]
        public void Post([FromBody]Store value)
        {
            value.Id = GuidSqlite.getGuid();
            _storeRepository.Add(value);
        }
        
        // PUT: api/store/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Store value)
        {
            _storeRepository.Update(value);
        }

        // DELETE: store/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _storeRepository.Remove(id);
        }
    }
}
