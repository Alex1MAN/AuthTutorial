using Microsoft.AspNetCore.Identity;

namespace AuthTutorial.Core.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MificName { get; set; }
        public string MificName2 { get; set; }
    }
}
