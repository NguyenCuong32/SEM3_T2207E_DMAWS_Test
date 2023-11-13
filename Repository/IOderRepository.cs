using DMAWS.Data;

namespace DMAWS.Repository;

public interface IOderRepository
{
    Task<List<OrderTbl>> GetList();
    Task<OrderTbl> Get(int id);
    Task Update(int id, OrderTbl orderTbl);
    Task<int> Add(OrderTbl orderTbl);
}