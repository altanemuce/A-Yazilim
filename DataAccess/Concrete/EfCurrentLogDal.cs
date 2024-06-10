using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class EfCurrentLogDal : EntityRepositoryBase<CurrentLog, ExampleDbContext>, ICurrentLogDal
	{
		public EfCurrentLogDal(ExampleDbContext exampleDbContext) : base(exampleDbContext)
		{

		}
	}
}
