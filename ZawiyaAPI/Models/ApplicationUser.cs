using Microsoft.AspNetCore.Identity;

namespace ZawiyaAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
