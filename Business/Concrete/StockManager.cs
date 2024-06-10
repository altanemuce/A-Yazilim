using AutoMapper;
using AutoMapper.QueryableExtensions;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs.Current;
using Entities.DTOs.Stock;
using Entities.DTOs.StockPrice;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        private readonly IStockDal _stockDal;
        private readonly IMapper _mapper;
        private readonly IStockPriceService _stockPriceService;
        public StockManager(IStockDal stockDal, IMapper mapper, IStockPriceService stockPriceService)
        {
            _mapper = mapper;
            _stockDal = stockDal;
            _stockPriceService = stockPriceService;

        }
        public async Task<AddStock> AddStock(AddStock addStock)
        {

            Stock stock = _mapper.Map<Stock>(addStock);
            Stock createdStock = await _stockDal.Add(stock);
            AddStockPrice stockPrice = new AddStockPrice { StockId = createdStock.Id, Price = addStock.Price };
            await _stockPriceService.AddStockPrice(stockPrice);
            AddStock add = _mapper.Map<AddStock>(createdStock);
            return add;
        }

        public IQueryable<ListStock> GetAll(bool tracking = false)
        {
            var query = _stockDal.GetAll().AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            var mapped = query.ProjectTo<ListStock>(_mapper.ConfigurationProvider);
            return mapped;
        }

        public async Task Remove(int id)
        {
            var result = _stockDal.GetAll().Where(x => x.Id == id).FirstOrDefault();
            await _stockPriceService.Remove(result.Id);
            var deleted = await _stockDal.Delete(result);
            return;
        }
    }
}
