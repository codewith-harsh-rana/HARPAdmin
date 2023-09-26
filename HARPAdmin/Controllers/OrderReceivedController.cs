using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderReceivedController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public OrderReceivedController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<OrderReceivedDetail>>> GetOrderreceiveddetail()
        {
            if (_adminContext.OrderReceivedDetails == null)
            {
                return NotFound();
            }
            return await _adminContext.OrderReceivedDetails.ToListAsync();
        }


        [HttpPost]
        public async Task<ActionResult<OrderReceivedDetail>> PostOrderrreceiveddetail(OrderReceivedDetail orderreceiveddetail)
        {

            _adminContext.OrderReceivedDetails.Add(orderreceiveddetail);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutOrderReceiveddetail(int Id, OrderReceivedDetail orderreceiveddetail)
        {
            if (Id != orderreceiveddetail.OrderReceivedDetailId)
            {
                return BadRequest();
            }

            _adminContext.Entry(orderreceiveddetail).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.OrderReceivedDetails.FindAsync(Id);
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
