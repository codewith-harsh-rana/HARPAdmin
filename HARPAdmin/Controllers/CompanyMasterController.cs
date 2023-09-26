using HARPAdmin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HARPAdmin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyMasterController : ControllerBase
    {
        private readonly AdminContext _adminContext;

        public CompanyMasterController(AdminContext adminContext)
        {
            _adminContext = adminContext;
        }

        [HttpGet]

        public async Task<ActionResult<IEnumerable<CompanyMaster>>> GetCompanyMaster()
        {
            if (_adminContext.companyMasters == null)
            {
                return NotFound();
            }
            return await _adminContext.companyMasters.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<CompanyMaster>> PostCompanyMaster(CompanyMaster companyMaster)
        {

            _adminContext.companyMasters.Add(companyMaster);
            await _adminContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPut("{Id}")]

        public async Task<ActionResult> PutCompanyMaster(int Id, CompanyMaster companyMaster)
        {
            if (Id != companyMaster.CompanyId)
            {
                return BadRequest();
            }

            _adminContext.Entry(companyMaster).State = EntityState.Modified;
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

        [HttpDelete("{id}")]

        public async Task<IActionResult> DeleteCompanyMaster(int id)
        {
            if (_adminContext.companyMasters == null)
            {
                return NotFound();
            }

            var company = await _adminContext.companyMasters.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _adminContext.companyMasters.Remove(company);
            await _adminContext.SaveChangesAsync();

            return Ok();

        }
    }
}
