using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfStockPriceDal : EntityRepositoryBase<StockPrice, ExampleDbContext>, IStockPriceDal
    {
        public EfStockPriceDal(ExampleDbContext exampleDbContext) : base(exampleDbContext)
        {

        }
    }
}
