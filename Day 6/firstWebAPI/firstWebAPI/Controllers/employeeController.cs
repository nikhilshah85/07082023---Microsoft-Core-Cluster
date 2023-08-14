using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using firstWebAPI.Models.EF;

namespace firstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employeeController : ControllerBase
    {
        private readonly EmployeeDbContext _context = new EmployeeDbContext();

      

        // GET: api/employee
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employeedetail>>> GetEmployeedetails()
        {
          if (_context.Employeedetails == null)
          {
              return NotFound();
          }
            return await _context.Employeedetails.ToListAsync();
        }

        // GET: api/employee/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employeedetail>> GetEmployeedetail(int id)
        {
          if (_context.Employeedetails == null)
          {
              return NotFound();
          }
            var employeedetail = await _context.Employeedetails.FindAsync(id);

            if (employeedetail == null)
            {
                return NotFound();
            }

            return employeedetail;
        }

        // PUT: api/employee/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeedetail(int id, Employeedetail employeedetail)
        {
            if (id != employeedetail.EmpNo)
            {
                return BadRequest();
            }

            _context.Entry(employeedetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeedetailExists(id))
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

        // POST: api/employee
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employeedetail>> PostEmployeedetail(Employeedetail employeedetail)
        {
          if (_context.Employeedetails == null)
          {
              return Problem("Entity set 'EmployeeDbContext.Employeedetails'  is null.");
          }
            _context.Employeedetails.Add(employeedetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeedetailExists(employeedetail.EmpNo))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeedetail", new { id = employeedetail.EmpNo }, employeedetail);
        }

        // DELETE: api/employee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeedetail(int id)
        {
            if (_context.Employeedetails == null)
            {
                return NotFound();
            }
            var employeedetail = await _context.Employeedetails.FindAsync(id);
            if (employeedetail == null)
            {
                return NotFound();
            }

            _context.Employeedetails.Remove(employeedetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeedetailExists(int id)
        {
            return (_context.Employeedetails?.Any(e => e.EmpNo == id)).GetValueOrDefault();
        }
    }
}
