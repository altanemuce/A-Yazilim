using AutoMapper;
using AutoMapper.QueryableExtensions;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs.Current;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
	public class CurrentManager : ICurrentService
	{
		private readonly ICurrentDal _currentDal;
		private readonly ExampleDbContext _exampleDbContext;
		private readonly IMapper _mapper;
		private readonly ICurrentLogService _currentLogService;
		public CurrentManager(ICurrentDal currentDal, ExampleDbContext exampleDbContext, IMapper mapper, ICurrentLogService currentLogService)
		{
			_currentDal = currentDal;
			_exampleDbContext = exampleDbContext;
			_mapper = mapper;
			_currentLogService = currentLogService;
		}
		public async Task<AddCurrent> AddCurrent(AddCurrent addCurrent)
		{
			Current current = _mapper.Map<Current>(addCurrent);
			AddCurrent add = null;

			using (var transaction = await _exampleDbContext.Database.BeginTransactionAsync())
			{
				try
				{
					Current createdCurrent = await _currentDal.Add(current);
					add = _mapper.Map<AddCurrent>(createdCurrent);

					CurrentLog currentLog=new CurrentLog { Action="Add",ActionDate=DateTime.Now,CurrentId=createdCurrent.Id,};

					await _currentLogService.Log(currentLog);

					await transaction.CommitAsync(); // Transaction'ı commit et
				}
				catch (Exception ex)
				{
					await transaction.RollbackAsync(); // Hata durumunda transaction'ı geri al
													   // Hata yönetimi: ex üzerinde gerekli işlemleri yapabilirsiniz, örneğin logging
				}
			}
			return add;
		}

		public IQueryable<ListCurrent> GetAll(bool tracking = false)
		{
			var query = _currentDal.GetAll().AsQueryable();
			if (!tracking)
			{
				query = query.AsNoTracking();
			}
			var mapped = query.ProjectTo<ListCurrent>(_mapper.ConfigurationProvider);
			return mapped;
		}
	}
}
