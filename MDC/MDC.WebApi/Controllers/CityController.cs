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
    [Route("city")]
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        // GET: city
        [HttpGet]
        public IEnumerable<City> Get()
        {
            return _cityRepository.GetAll();
        }

        // GET: city/5
        [HttpGet("{id}", Name = "GetCity")]
        public City Get(string id)
        {
            return _cityRepository.GetById(id);
        }
        
        // POST: city
        [HttpPost]
        public void Post([FromBody]City value)
        {
            value.Id = GuidSqlite.getGuid();
            _cityRepository.Add(value);
        }
        
        // PUT: city/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]City value)
        {
            _cityRepository.Update(value);
        }

        // DELETE: city/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _cityRepository.Remove(id);
        }
    }
}
