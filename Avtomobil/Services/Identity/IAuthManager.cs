using Avtomobil.DTO.Identity;

namespace Avtomobil.Services.Identity
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginDto dto);
        Task<string> CreateToken();
    }
}
