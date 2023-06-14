using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ZawiyaAPI.Data;
using ZawiyaAPI.Models;
using ZawiyaAPI.Models.Dto;
using ZawiyaAPI.Repository.IRepository;

namespace ZawiyaAPI.Repository
{
    public class UserRepository: IUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private string secretKey;
        private readonly IMapper _mapper;

        public UserRepository(ApplicationDbContext db, IConfiguration configuration, 
            UserManager<ApplicationUser> userManager, IMapper mapper, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _mapper = mapper;
            secretKey = configuration.GetValue<string>("ApiSettings:Secret");
            _userManager = userManager;
            _roleManager = roleManager;

        }

        public async Task<ApplicationUser> GetUser(int buyerId)
        {
            var buyer = _db.Buyers.FirstOrDefault(x => x.BuyerId == buyerId);
            if (buyer == null)
            {
                return null;
            }
            var user = _db.ApplicationUsers.FirstOrDefault(x => x.Id == buyer.UserId);
            if(user != null)
            {
                return user;
            }
            return null;
        }

        public async Task<int> GetRoleIdAsync(string userId, string role)
        {
            if(role == "seller")
            {
                var seller = _db.Sellers.FirstOrDefault(x => x.UserId == userId);
                if (seller != null)
                {
                    return seller.SellerId;
                }
                return 0;
            }
            if (role == "buyer")
            {
                var buyer = _db.Buyers.FirstOrDefault(x => x.UserId == userId);
                if (buyer != null)
                {
                    return buyer.BuyerId;
                }
                return 0;
            }
            return 0;
        }

        public bool IsUniqueUser(string username)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(x => x.UserName == username);
            if (user == null)
            {
                return true;
            }
            else return false;
        }

        public async Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO)
        {
            var user = _db.ApplicationUsers.FirstOrDefault(u=>u.UserName.ToLower() == loginRequestDTO.Username.ToLower());

            bool isValid = await _userManager.CheckPasswordAsync(user, loginRequestDTO.Password);
            if(user == null || isValid == false)
            {
                return new LoginResponseDTO()
                {
                    Token = "",
                    User = null,
                };
            }

            //if user was found generate jwt token
            var roles = await _userManager.GetRolesAsync(user);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email.ToString()),
                    new Claim(ClaimTypes.Role, roles.FirstOrDefault())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            LoginResponseDTO loginResponseDTO = new LoginResponseDTO()
            {
                Token = tokenHandler.WriteToken(token),
                User = _mapper.Map<UserDTO>(user),
                Role = roles.FirstOrDefault()
            };
            return loginResponseDTO;
        }

        public async Task<UserDTO> Register(RegistrationRequestDTO registrationRequestDTO)
        {
            ApplicationUser user = new()
            {
                UserName = registrationRequestDTO.Username,
                Name = registrationRequestDTO.Username,
                Email = registrationRequestDTO.Email,
                NormalizedEmail = registrationRequestDTO.Email.ToUpper()
            };
            try
            {
                var result = await _userManager.CreateAsync(user, registrationRequestDTO.Password);
                if(result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("admin").GetAwaiter().GetResult())
                    {
                        await _roleManager.CreateAsync(new IdentityRole("admin"));
                        await _roleManager.CreateAsync(new IdentityRole("buyer"));
                        await _roleManager.CreateAsync(new IdentityRole("seller"));
                    }

                    await _userManager.AddToRoleAsync(user,registrationRequestDTO.Role);
                    var userToReturn = _db.ApplicationUsers
                        .FirstOrDefault(u=> u.UserName == registrationRequestDTO.Username);
                    return _mapper.Map<UserDTO>(userToReturn);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"An error occurred during user registration: {ex.Message}");
            }
            return new UserDTO();
        }
    }
}
