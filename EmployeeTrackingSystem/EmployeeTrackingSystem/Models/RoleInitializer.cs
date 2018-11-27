using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeTrackingSystem.Models
{
    public class RoleInitializer
    {
        public static async Task Initialize(RoleManager<IdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var role = new IdentityRole("Admin");
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("Manager"))
            {
                var role = new IdentityRole("Manager");
                await roleManager.CreateAsync(role);
            }
            if (!await roleManager.RoleExistsAsync("User"))
            {
                var role = new IdentityRole("User");
                await roleManager.CreateAsync(role);
            }
        }
    }
}
