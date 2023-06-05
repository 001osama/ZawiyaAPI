using System.Security.Claims;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;

namespace ZawiyaAPI.Repository.IRepository
{
    public interface IUserRepository
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<int> GetSellerIdAsync(string userId);
        Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO);    
    }
}
