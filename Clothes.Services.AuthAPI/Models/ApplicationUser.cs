using Microsoft.AspNetCore.Identity;

namespace Clothes.Services.AuthAPI.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
    }
}
