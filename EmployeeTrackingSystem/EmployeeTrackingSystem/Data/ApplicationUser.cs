using Microsoft.AspNetCore.Identity;

namespace EmployeeTrackingSystem.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}