using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Order_API;
using Order_API.Models;

namespace Order_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderDbContext _context;

        public OrderController(OrderDbContext context)
        {
            _context = context;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrderTbl()
        {
          if (_context.OrderTbl == null)
          {
              return NotFound();
          }
            return await _context.OrderTbl.ToListAsync();
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
          if (_context.OrderTbl == null)
          {
              return NotFound();
          }
            var order = await _context.OrderTbl.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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

        // POST: api/Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
          if (_context.OrderTbl == null)
          {
              return Problem("Entity set 'OrderDbContext.OrderTbl'  is null.");
          }
            _context.OrderTbl.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Order/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            if (_context.OrderTbl == null)
            {
                return NotFound();
            }
            var order = await _context.OrderTbl.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.OrderTbl.Remove(order);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return (_context.OrderTbl?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
