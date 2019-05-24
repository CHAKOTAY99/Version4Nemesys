using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Version4Nemesys.Data
{
    public class DBInitilizer
    {
        public static async void Seed(ApplicationDbContext context, IServiceProvider serviceManager)
        {
            var roleManager = serviceManager.GetRequiredService<RoleManager<IdentityRole>>();
            
            string[] roleNames = { "Admin", "Investigator", "Reporter" };
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }
        }
    }
}
