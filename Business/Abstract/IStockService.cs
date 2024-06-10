using Entities.DTOs.Current;
using Entities.DTOs.Stock;

namespace Business.Abstract
{
    public interface IStockService
    {
        Task<AddStock> AddStock(AddStock addStock);
        IQueryable<ListStock> GetAll(bool tracking = false);
        Task Remove(int id);
    }
}
