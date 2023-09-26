using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public OrderController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            if (_adminContext.Orders == null)
            {
                return NotFound();
            }
            return await _adminContext.Orders.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {

            _adminContext.Orders.Add(order);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutOrder(int Id, Order order)
        {
            if (Id != order.OrderId)
            {
                return BadRequest();
            }

            _adminContext.Entry(order).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.Orders.FindAsync(Id);
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
