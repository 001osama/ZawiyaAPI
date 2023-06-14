using System.Security.Claims;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        Task<ApplicationUser> GetUser(int buyerId);
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<int> GetRoleIdAsync(string userId, string role);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);    
    }
}
