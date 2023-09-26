using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippedController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public ShippedController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Shipped>>> GetShipped()
        {
            if (_adminContext.shippeds == null)
            {
                return NotFound();
            }
            return await _adminContext.shippeds.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Shipped>> PostShipped(Shipped shipped)
        {

            _adminContext.shippeds.Add(shipped);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutShipped(int Id, Shipped shipped)
        {
            if (Id != shipped.ShippedId)
            {
                return BadRequest();
            }

            _adminContext.Entry(shipped).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.shippeds.FindAsync(Id);
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
