using AutoMapper;
using AutoMapper.QueryableExtensions;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.DTOs.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Business.Concrete
{
	public class UserManager : IUserService
	{
		private readonly UserManager<AppUser> _userManager;
		private readonly IMapper _mapper;
		public UserManager(UserManager<AppUser> userManager, IMapper mapper)
		{
			_userManager = userManager;
			_mapper = mapper;
		}
		public   IQueryable<ListUser> GetAllUser(bool tracking = true)
		{
			var query =  _userManager.Users.AsQueryable();
			if (!tracking)
			{
				query = query.AsNoTracking();
			}
			var mapped = query.ProjectTo<ListUser>(_mapper.ConfigurationProvider);
			return mapped;

		}
	}
}
