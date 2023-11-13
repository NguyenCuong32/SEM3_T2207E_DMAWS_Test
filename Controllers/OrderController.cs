using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DMAWS.Data;
using DMAWS.Repository;

namespace DMAWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOderRepository repository;
        private readonly DatabaseContext context;

        public OrderController(IOderRepository repository, DatabaseContext context)
        {
            this.repository = repository;
            this.context = context;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderTbl>>> GetOrderTbls()
        {
            try
            {
                var books = await repository.GetList();
                return Ok(books);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        // GET: api/Order/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderTbl>> GetOrderTbl(int id)
        {
            var orderTbl = await repository.Get(id);

            if (orderTbl == null)
            {
                return NotFound();
            }

            return orderTbl;
        }

        // PUT: api/Order/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrderTbl(int id, OrderTbl model)
        {
            await repository.Update(id, model);
            var order = await repository.Get(id);
            return order == null ? NotFound() : Ok(order);
        }
        
        // POST: api/Order
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<OrderTbl>> PostOrderTbl(OrderTbl orderTbl)
        {
            await repository.Add(orderTbl);
            return CreatedAtAction("GetOrderTbl", new { id = orderTbl.ItemCode }, orderTbl);
        }
    }
}
