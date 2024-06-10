using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfAddressDal : EntityRepositoryBase<Address, ExampleDbContext>, IAddressDal
    {
        public EfAddressDal(ExampleDbContext exampleDbContext) : base(exampleDbContext)
        {

        }
    }
}
