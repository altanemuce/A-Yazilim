using Entities.DTOs.StockPrice;

namespace Business.Abstract
{
    public interface IStockPriceService
    {
        Task<AddStockPrice> AddStockPrice(AddStockPrice addStockPrice);
        Task Remove(int stockId);
    }
}
