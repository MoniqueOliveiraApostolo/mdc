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
    [Route("category")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        // GET: category
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return _categoryRepository.GetAll();
        }

        // GET: category/5
        [HttpGet("{id}", Name = "GetCategory")]
        public Category Get(string id)
        {
            return _categoryRepository.GetById(id);
        }
        
        // POST: category
        [HttpPost]
        public void Post([FromBody]Category value)
        {
            value.Id = GuidSqlite.getGuid();
            _categoryRepository.Add(value);
        }
        
        // PUT: category/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]Category value)
        {
            _categoryRepository.Update(value);
        }

        // DELETE: category/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _categoryRepository.Remove(id);
        }
    }
}
