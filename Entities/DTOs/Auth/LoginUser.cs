namespace Entities.DTOs.Auth
{
	public class LoginUser
	{
		public string? VerificationCode { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
	}
}
