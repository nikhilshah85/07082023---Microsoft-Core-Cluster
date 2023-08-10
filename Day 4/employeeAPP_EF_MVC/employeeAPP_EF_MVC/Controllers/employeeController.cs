using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using employeeAPP_EF_MVC.Models.EF;

namespace employeeAPP_EF_MVC.Controllers
{
    public class employeeController : Controller
    {
        private readonly EmployeeDbContext _context = new EmployeeDbContext();

        //public employeeController(EmployeeDbContext context)
        //{
        //    _context = context;
        //}

        // GET: employee
        public async Task<IActionResult> Index()
        {
              return _context.EmployeeInfos != null ? 
                          View(await _context.EmployeeInfos.ToListAsync()) :
                          Problem("Entity set 'EmployeeDbContext.EmployeeInfos'  is null.");
        }

        // GET: employee/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.EmployeeInfos == null)
            {
                return NotFound();
            }

            var employeeInfo = await _context.EmployeeInfos
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            return View(employeeInfo);
        }

        // GET: employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: employee/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmpNo,EmpName,EmpDesignation,EmpSalary,EmpIsPermenant")] EmployeeInfo employeeInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeeInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeeInfo);
        }

        // GET: employee/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.EmployeeInfos == null)
            {
                return NotFound();
            }

            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
            if (employeeInfo == null)
            {
                return NotFound();
            }
            return View(employeeInfo);
        }

        // POST: employee/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmpNo,EmpName,EmpDesignation,EmpSalary,EmpIsPermenant")] EmployeeInfo employeeInfo)
        {
            if (id != employeeInfo.EmpNo)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeeInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeInfoExists(employeeInfo.EmpNo))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employeeInfo);
        }

        // GET: employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.EmployeeInfos == null)
            {
                return NotFound();
            }

            var employeeInfo = await _context.EmployeeInfos
                .FirstOrDefaultAsync(m => m.EmpNo == id);
            if (employeeInfo == null)
            {
                return NotFound();
            }

            return View(employeeInfo);
        }

        // POST: employee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.EmployeeInfos == null)
            {
                return Problem("Entity set 'EmployeeDbContext.EmployeeInfos'  is null.");
            }
            var employeeInfo = await _context.EmployeeInfos.FindAsync(id);
            if (employeeInfo != null)
            {
                _context.EmployeeInfos.Remove(employeeInfo);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeInfoExists(int id)
        {
          return (_context.EmployeeInfos?.Any(e => e.EmpNo == id)).GetValueOrDefault();
        }
    }
}
