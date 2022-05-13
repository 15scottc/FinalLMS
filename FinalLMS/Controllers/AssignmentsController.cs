#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using FinalLMS.Data;
using FinalLMS.Models;

namespace FinalLMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentsController : ControllerBase
    {
        private readonly JwtAuthenticationManager jwtAuthenticationManager;
        private readonly FinalLMSContext _context;

        public AssignmentsController(JwtAuthenticationManager jwtAuthenticationManager,  FinalLMSContext context)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
            _context = context;
        }

        [Authorize]

        // GET: api/Assignments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Assignments>>> GetAssignments()
        {
            return await _context.Assignments.ToListAsync();
        }

        [AllowAnonymous]
        [HttpPost("Authorize")]

        public IActionResult AuthUser([FromBody] User user)
        {
            var token = jwtAuthenticationManager.Authenticate(user.username, user.password);
            if (token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }

        public class User
        {
            public string username { get; set; }
            public string password { get; set; }
        }


        [Authorize]
        // GET: api/Assignments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Assignments>> GetAssignments(int id)
        {
            var assignments = await _context.Assignments.FindAsync(id);

            if (assignments == null)
            {
                return NotFound();
            }

            return assignments;
        }

        [Authorize]

        // PUT: api/Assignments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAssignments(int id, Assignments assignments)
        {
            if (id != assignments.AssignmentId)
            {
                return BadRequest();
            }

            _context.Entry(assignments).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AssignmentsExists(id))
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

        [Authorize]

        // POST: api/Assignments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Assignments>> PostAssignments(Assignments assignments)
        {
            _context.Assignments.Add(assignments);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAssignments", new { id = assignments.AssignmentId }, assignments);
        }

        [Authorize]
        // DELETE: api/Assignments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAssignments(int id)
        {
            var assignments = await _context.Assignments.FindAsync(id);
            if (assignments == null)
            {
                return NotFound();
            }

            _context.Assignments.Remove(assignments);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AssignmentsExists(int id)
        {
            return _context.Assignments.Any(e => e.AssignmentId == id);
        }
    }
}
