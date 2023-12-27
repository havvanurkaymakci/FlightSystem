using Microsoft.AspNetCore.Identity;
namespace FlightSystem.Models
{
    public class ApplicationUser : IdentityUser 
    {
        public string Name { get; set; }

    }
}
