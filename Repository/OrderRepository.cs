using DMAWS.Data;
using Microsoft.EntityFrameworkCore;

namespace DMAWS.Repository;

public class OrderRepository : IOderRepository
{
    private readonly DatabaseContext _context;
    
    public OrderRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    public async Task<List<OrderTbl>> GetList()
    {
        var orders = await _context.OrderTbls.ToListAsync();
        return orders;
    }

    public async Task<OrderTbl> Get(int id)
    {
        var order = await _context.OrderTbls.FindAsync(id);
        return order;
    }

    public async Task Update(int id, OrderTbl model)
    {
        if (id == model.ItemCode)
        {
            var order = _context.OrderTbls.Update(model);
            await _context.SaveChangesAsync();
            
        }
    }

    public async Task<int> Add(OrderTbl orderTbl)
    {
        _context.OrderTbls!.Add(orderTbl);
        await _context.SaveChangesAsync();
        return orderTbl.ItemCode;
    }
}