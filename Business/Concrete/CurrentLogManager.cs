using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CurrentLogManager : ICurrentLogService
	{
		private readonly ICurrentLogDal _currentLogDal;
		public CurrentLogManager(ICurrentLogDal currentLogDal)
		{
			_currentLogDal = currentLogDal;
		}
		public Task Log(CurrentLog currentLog)
		{
			var result = _currentLogDal.Add(currentLog);
			return result;
		}
	}
}
