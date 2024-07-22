using Microsoft.AspNetCore.Identity;

namespace TravelTripProje.Models.Siniflar
{
	public static class SeedData
	{
		public static async Task Initialize(IServiceProvider serviceProvider)
		{
			var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
			var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

			string[] roleNames = { "Admin", "User" };
			foreach (var roleName in roleNames)
			{
				var roleExist = await roleManager.RoleExistsAsync(roleName);
				if (!roleExist)
				{
					await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}

			var adminUser = new IdentityUser
			{
				UserName = "admin",
				EmailConfirmed = true
			};

			string adminPassword = "Admin123!";
			var user = await userManager.FindByEmailAsync(adminUser.Email);

			if (user == null)
			{
				var createPowerUser = await userManager.CreateAsync(adminUser, adminPassword);
				if (createPowerUser.Succeeded)
				{
					await userManager.AddToRoleAsync(adminUser, "Admin");
				}
			}
		}
	}
}