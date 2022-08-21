using Microsoft.AspNetCore.Identity;

namespace School.Models.DbModels
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
