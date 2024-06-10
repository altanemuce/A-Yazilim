using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfCurrentDal : EntityRepositoryBase<Current, ExampleDbContext>, ICurrentDal
    {
        public EfCurrentDal(ExampleDbContext exampleDbContext) : base(exampleDbContext)
        {

        }
    }
}
