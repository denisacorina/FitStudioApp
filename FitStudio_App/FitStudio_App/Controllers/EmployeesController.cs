using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FitStudio_App.Context;
using FitStudio_App.Models;
using NuGet.Protocol;

namespace FitStudio_App.Controllers
{
    public class EmployeesController : BaseApiController
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

       
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
          
            return await _context.Employees
                .Where(r => r.RoleId == 4)
                .ToListAsync();
        }

        [HttpGet("trainers")]
        public ActionResult GetEmployeeTrainer()
        {
            var trainer = _context.Employees
                .Include(c => c.Class)
                .Where(e => e.RoleId == 4)
                .OrderBy(c => c.Class.WeekDay);
                
            return Ok(trainer);
        }

        [HttpGet("trainers/monday")]
        public ActionResult GetEmployeeTrainerMonday()
        {
            var trainer = _context.Employees
                .Include(c => c.Class)
                .Where(e => e.RoleId == 4)
                .Where(e => e.Class.WeekDay == "Monday");
            return Ok(trainer);
        }

        [HttpGet("trainers/tuesday")]
        public ActionResult GetEmployeeTrainerTuesday()
        {
            var trainer = _context.Employees
                .Include(c => c.Class)
                .Where(e => e.RoleId == 4)
                .Where(e => e.Class.WeekDay == "Tuesday");
            return Ok(trainer);
        }

        [HttpGet("trainers/wednesday")]
        public ActionResult GetEmployeeTrainerWednesday()
        {
            var trainer = _context.Employees
                .Include(c => c.Class)
                .Where(e => e.RoleId == 4)
                .Where(e => e.Class.WeekDay == "Wednesday");
            return Ok(trainer);
        }



        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            if (id != employee.EmployeeId)
            {
                return BadRequest();
            }

            _context.Entry(employee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeExists(id))
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

      
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.EmployeeId }, employee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeId == id);
        }
    }
}
