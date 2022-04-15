using Core.Dtos;
using Core.Models;
using Microsoft.AspNetCore.Identity;

namespace Core.Serviecs
{
    public interface IMyUserService 
    {
        Task<IdentityResult> CreateUser(UserDto model);
        Task<string> Login(LoginDto model);

    }
}
