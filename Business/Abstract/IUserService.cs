using Entities.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IUserService
	{
		IQueryable<ListUser> GetAllUser(bool tracking = true);
	}
}
