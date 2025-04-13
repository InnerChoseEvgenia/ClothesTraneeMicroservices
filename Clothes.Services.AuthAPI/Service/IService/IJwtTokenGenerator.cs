using Clothes.Services.AuthAPI.Models;

namespace Clothes.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string>roles);
    }
}
