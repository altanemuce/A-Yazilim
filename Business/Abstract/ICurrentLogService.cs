using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICurrentLogService
	{
		Task Log(CurrentLog currentLog);
	}
}
