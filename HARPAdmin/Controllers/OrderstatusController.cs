using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderstatusController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public OrderstatusController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<Orderstatus>>> GetOrderstatus()
        {
            if (_adminContext.OrderStatuses == null)
            {
                return NotFound();
            }
            return await _adminContext.OrderStatuses.ToListAsync();
        }
    }
}
