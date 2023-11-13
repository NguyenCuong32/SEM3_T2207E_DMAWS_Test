using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using exam_api_nguyenmanhhieu.Data;
using exam_api_nguyenmanhhieu.Models;

namespace exam_api_nguyenmanhhieu
{
    [Route("api/[controller]")]
    [ApiController]
    public class InforClientController : ControllerBase
    {
        private readonly InforClientModelDBContext _context;

        public InforClientController(InforClientModelDBContext context)
        {
            _context = context;
        }

        // GET: api/InforClient
        [HttpGet]
        public async Task<ActionResult<IEnumerable<InforClientModel>>> GetInforClients()
        {
          if (_context.InforClients == null)
          {
              return NotFound();
          }
            return await _context.InforClients.ToListAsync();
        }

        // GET: api/InforClient/5
        [HttpGet("{id}")]
        public async Task<ActionResult<InforClientModel>> GetInforClientModel(int id)
        {
          if (_context.InforClients == null)
          {
              return NotFound();
          }
            var inforClientModel = await _context.InforClients.FindAsync(id);

            if (inforClientModel == null)
            {
                return NotFound();
            }

            return inforClientModel;
        }

        // PUT: api/InforClient/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInforClientModel(int id, InforClientModel inforClientModel)
        {
            if (id != inforClientModel.Client)
            {
                return BadRequest();
            }

            _context.Entry(inforClientModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InforClientModelExists(id))
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

        // POST: api/InforClient
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<InforClientModel>> PostInforClientModel(InforClientModel inforClientModel)
        {
          if (_context.InforClients == null)
          {
              return Problem("Entity set 'InforClientModelDBContext.InforClients'  is null.");
          }
            _context.InforClients.Add(inforClientModel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInforClientModel", new { id = inforClientModel.Client }, inforClientModel);
        }

        // DELETE: api/InforClient/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInforClientModel(int id)
        {
            if (_context.InforClients == null)
            {
                return NotFound();
            }
            var inforClientModel = await _context.InforClients.FindAsync(id);
            if (inforClientModel == null)
            {
                return NotFound();
            }

            _context.InforClients.Remove(inforClientModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InforClientModelExists(int id)
        {
            return (_context.InforClients?.Any(e => e.Client == id)).GetValueOrDefault();
        }
    }
}
