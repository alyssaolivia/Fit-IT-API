using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fit_IT_API.Data;
using Fit_IT_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Fit_IT_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(AuthenticationSchemes = "Bearer")]
    public class ProgressController : ControllerBase
    {
        private readonly Fit_IT_APIContext _context;

        public ProgressController(Fit_IT_APIContext context)
        {
            _context = context;
        }

        // GET: api/Progress/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProgress(int id)
        {
            var progress = await _context.Progress.Where(p => p.UserId == id).ToListAsync();

            if (progress == null)
            {
                return NotFound();
            }

            return Ok(progress);
        }

        // PUT: api/Progress/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProgress(int id, Progress progress)
        {
            if (id != progress.Id)
            {
                return BadRequest();
            }

            _context.Entry(progress).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgressExists(id))
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

        // POST: api/Progress
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Progress>> PostProgress(Progress progress)
        {
            _context.Progress.Add(progress);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProgress", new { id = progress.Id }, progress);
        }

        // DELETE: api/Progress/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProgress(int id)
        {
            var progress = await _context.Progress.FindAsync(id);
            if (progress == null)
            {
                return NotFound();
            }

            _context.Progress.Remove(progress);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProgressExists(int id)
        {
            return _context.Progress.Any(e => e.Id == id);
        }
    }
}
