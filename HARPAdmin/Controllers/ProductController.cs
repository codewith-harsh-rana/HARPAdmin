using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public ProductController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            if (_adminContext.Products == null)
            {
                return NotFound();
            }
            return await _adminContext.Products.ToListAsync();
        }



        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            
            _adminContext.Products.Add(product);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutProduct(int Id, Product product)
        {
            if (Id != product.ProductId)
            {
                return BadRequest();
            }

            _adminContext.Entry(product).State = EntityState.Modified;
            try
            {
                await _adminContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok();
        }

        [HttpDelete("soft/{Id}")]

        public async Task<IActionResult> Delete(int Id)
        {

            var entityToDelete = await _adminContext.Products.FindAsync(Id);
            if (entityToDelete == null)
            {
                return NotFound();
            }
            entityToDelete.IsDeleted = true;
            await _adminContext.SaveChangesAsync();

            return Ok();
        }
    }

}
