using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippedDetailController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public ShippedDetailController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<ShippedDetail>>> GetShippedDetail()
        {
            if (_adminContext.shippedDetails == null)
            {
                return NotFound();
            }
            return await _adminContext.shippedDetails.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<ShippedDetail>> PostShippeddetail(ShippedDetail shippedDetail)
        {

            _adminContext.shippedDetails.Add(shippedDetail);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutShippedDetail(int Id, ShippedDetail shippedDetail)
        {
            if (Id != shippedDetail.ShippedDetailId)
            {
                return BadRequest();
            }

            _adminContext.Entry(shippedDetail).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.shippedDetails.FindAsync(Id);
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
