using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfStockDal : EntityRepositoryBase<Stock, ExampleDbContext>, IStockDal
    {
        public EfStockDal(ExampleDbContext exampleDbContext) : base(exampleDbContext)
        {

        }
    }
}
