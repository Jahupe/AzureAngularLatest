using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevOpsAngular.Api.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AzureDevOpsAngular.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private List<Product> _products;

        public ProductController()
        {
            GenereateProducts();
        }

        // GET: api/<ProductController>
        [HttpGet]
        public List<Product> Get()
        {
            return _products;
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.Where(p => p.ProductId == id).FirstOrDefault();
        }

        // POST api/<ProductController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private void GenereateProducts()
        {
            _products = new List<Product>();
            _products.Add(new Product
            {
                ProductId = 1,
                Description = "Laptop HP 17 Pulgadas",
                Price = 12000,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 2,
                Description = "Monitor 19 Pulgadas",
                Price = 15000,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 3,
                Description = "Mouse Logitech Optical",
                Price = 450,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 4,
                Description = "Maletin para Laptop HP 17 Pulgadas",
                Price = 300,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 5,
                Description = "Impresora Epson LaserJet",
                Price = 1260,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });
            _products.Add(new Product
            {
                ProductId = 6,
                Description = "Estabilizador de corriente",
                Price = 780,
                Created = DateTime.Now,
                Updated = DateTime.Now
            });

        }
    }
}
