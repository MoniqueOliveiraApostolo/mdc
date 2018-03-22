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
    [Route("product")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // GET: product
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _productRepository.GetAll();
        }

        // GET: product/5
        [HttpGet("{id}", Name = "GetProduct")]
        public Product Get(string id)
        {
            return _productRepository.GetById(id);
        }
        
        // POST: product
        [HttpPost]
        public void Post([FromBody]Product value)
        {
            value.Id = GuidSqlite.getGuid();
            if (TryValidateModel(value)) _productRepository.Add(value);
        }
        
        // PUT: product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Product value)
        {
            _productRepository.Update(value);
        }

        // DELETE: product/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _productRepository.Remove(id);
        }
    }
}
