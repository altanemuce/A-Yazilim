using Microsoft.AspNetCore.Identity;

namespace Core.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string? VerificationCode { get; set; }
    }
}
