using Microsoft.AspNetCore.Identity;

namespace dgPadCms.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
