using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Persistence
{
    public static class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultUserAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var administratorRole = new IdentityRole("Administrator");

            if (roleManager.Roles.All(r => r.Name != administratorRole.Name))
            {
                await roleManager.CreateAsync(administratorRole);
            }

            var administrator = new ApplicationUser { UserName = "zosia@localhost", Email = "zosia@localhost" };

            if (userManager.Users.All(u => u.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Administrator1!");
                await userManager.AddToRolesAsync(administrator, new [] { administratorRole.Name });
            }
        }

        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Companies.Any())
            {
                context.Companies.Add(new Company
                {
                    Adress = "Super ulica 23",
                    Name = "Fajna firma 1"
                });

                context.Companies.Add(new Company
                {
                    Adress = "Boczna 45",
                    Name = "Ciekawa firma"
                });

                context.Companies.Add(new Company
                {
                    Adress = "Klonowa 12",
                    Name = "Szemrana firma"
                });
                
                context.Companies.Add(new Company
                {
                    Adress = "Krótka 50",
                    Name = "Długa firma"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
