using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly AdminContext _adminContext;

        public UserController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            if (_adminContext.Users == null)
            {
                return NotFound();
            }
            return await _adminContext.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<User>> PostUser(User user)
        {

            _adminContext.Users.Add(user);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutUser(int Id, User user)
        {
            if (Id != user.UserId)
            {
                return BadRequest();
            }

            _adminContext.Entry(user).State = EntityState.Modified;
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

            var entityToDelete = await _adminContext.Users.FindAsync(Id);
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
