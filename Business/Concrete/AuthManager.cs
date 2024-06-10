using Business.Abstract;
using Core.Entities.Concrete;
using Entities.DTOs.Auth;
using Microsoft.AspNetCore.Identity;

namespace Business.Concrete
{
	public class AuthManager : IAuthService
	{
		private readonly SignInManager<AppUser> _signInManager;
		private readonly UserManager<AppUser> _userManager;
		public AuthManager(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
		{
			_signInManager = signInManager;
			_userManager = userManager;
		}

		public async Task<LoginUser> LoginUser(LoginUser loginUser)
		{
			AppUser appUser = await _userManager.FindByEmailAsync(loginUser.Email);
			if (appUser == null)
				throw new Exception("Kullanıcı Bulunamadı");

			SignInResult result = await _signInManager.CheckPasswordSignInAsync(appUser, loginUser.Password, false);
			if (result.Succeeded == false)
			{
				throw new Exception("Giriş Başarısız");
			}
			return loginUser;
		}

		public async Task<RegisterUser> RegisterUser(RegisterUser registerUser)
		{
			var appUser = new AppUser { UserName = registerUser.UserName, Email = registerUser.Email };
			var result = await _userManager.CreateAsync(appUser, registerUser.Password);
			if (result.Succeeded == false)
			{
				throw new Exception("Hata");
			}
			return registerUser;
		}
	}
}
