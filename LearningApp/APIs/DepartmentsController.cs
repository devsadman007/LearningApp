﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LearningApp.Data;
using LearningApp.Models;

namespace LearningApp.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Departments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Departments>>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();
        }

        // GET: api/Departments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Departments>> GetDepartments(int id)
        {
            var departments = await _context.Departments.FindAsync(id);

            if (departments == null)
            {
                return NotFound();
            }

            return departments;
        }

        // PUT: api/Departments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDepartments(int id, Departments departments)
        {
            if (id != departments.id)
            {
                return BadRequest();
            }

            _context.Entry(departments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DepartmentsExists(id))
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

        // POST: api/Departments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Departments>> PostDepartments(Departments departments)
        {
            _context.Departments.Add(departments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDepartments", new { id = departments.id }, departments);
        }

        // DELETE: api/Departments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartments(int id)
        {
            var departments = await _context.Departments.FindAsync(id);
            if (departments == null)
            {
                return NotFound();
            }

            _context.Departments.Remove(departments);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DepartmentsExists(int id)
        {
            return _context.Departments.Any(e => e.id == id);
        }
    }
}
