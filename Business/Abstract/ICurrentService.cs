using Entities.DTOs.Current;

namespace Business.Abstract
{
	public interface ICurrentService
	{
		Task<AddCurrent> AddCurrent(AddCurrent addCurrent);
		IQueryable<ListCurrent> GetAll(bool tracking=false);
	}
}
