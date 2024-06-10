using AutoMapper;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs.StockPrice;

namespace Business.Concrete
{
    public class StockPriceManager : IStockPriceService
    {
        private readonly IStockPriceDal _stockPriceDal;
        private readonly IMapper _mapper;
        public StockPriceManager(IStockPriceDal stockPriceDal, IMapper mapper)
        {
            _stockPriceDal = stockPriceDal;
            _mapper = mapper;
        }
        public async Task<AddStockPrice> AddStockPrice(AddStockPrice addStockPrice)
        {
            StockPrice stockPrice = _mapper.Map<StockPrice>(addStockPrice);
            StockPrice createdStockPrice = await _stockPriceDal.Add(stockPrice);

            AddStockPrice add = _mapper.Map<AddStockPrice>(createdStockPrice);
            return add;
        }

        public async Task Remove(int stockId)
        {
            var result = _stockPriceDal.GetAll().Where(x => x.StockId == stockId).FirstOrDefault();
            await _stockPriceDal.Delete(result);
            return;
        }
    }
}
