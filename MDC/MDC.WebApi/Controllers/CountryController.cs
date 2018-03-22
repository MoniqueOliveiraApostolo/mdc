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
    [Route("country")]
    public class CountryController : Controller
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        // GET: country
        [HttpGet]
        public IEnumerable<Country> Get()
        {
            return _countryRepository.GetAll();
        }

        // GET: country/5
        [HttpGet("{id}", Name = "GetCountry")]
        public Country Get(string id)
        {
            return _countryRepository.GetById(id);
        }
        
        // POST: country
        [HttpPost]
        public void Post([FromBody]Country value)
        {
            value.Id = GuidSqlite.getGuid();
            _countryRepository.Add(value);
        }
        
        // PUT: country/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Country value)
        {
            _countryRepository.Update(value);
        }

        // DELETE: country/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _countryRepository.Remove(id);
        }
    }
}
