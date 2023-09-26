using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public OrderDetailController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<OrderDetail>>> GetOrdersdetail()
        {
            if (_adminContext.OrderDetails == null)
            {
                return NotFound();
            }
            return await _adminContext.OrderDetails.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<OrderDetail>> PostOrderdetail(OrderDetail orderdetail)
        {

            _adminContext.OrderDetails.Add(orderdetail);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutOrderdetail(int Id, OrderDetail orderdetail)
        {
            if (Id != orderdetail.OrderDetailId)
            {
                return BadRequest();
            }

            _adminContext.Entry(orderdetail).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.OrderDetails.FindAsync(Id);
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
