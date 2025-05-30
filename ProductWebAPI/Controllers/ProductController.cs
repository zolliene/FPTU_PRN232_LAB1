using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessObjects.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;


namespace LAB01_COMESTICS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _context;

      

        public ProductController(IProductService context)
        {
            _context = context;
        }

        // GET: api/CosmeticInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return _context.GetProducts();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = _context.GetProductById(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        // PUT: api/CosmeticInformations/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }

            try
            {
                _context.UpdateProduct(product);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_context.GetProductById(id) == null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST: api/CosmeticInformations
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.SaveProduct(product);
            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }


        // DELETE: api/CosmeticInformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = _context.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.DeleteProduct(product);

            return NoContent();
        }


    }
}
