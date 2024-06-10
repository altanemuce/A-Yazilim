using Entities.DTOs.Auth;

namespace Business.Abstract
{
	public interface IAuthService
	{
		Task<RegisterUser> RegisterUser(RegisterUser registerUser);
		Task<LoginUser> LoginUser(LoginUser loginUser);
	}
}
