using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace Podterob.UI.Data
{
	public class DbInit
	{
		public static async Task SetupIdentityAdmin(WebApplication application)
		{
			using var scope = application.Services.CreateScope();
			var userManager = scope
				.ServiceProvider
				.GetRequiredService<UserManager<ApplicationUser>>();

			var user = await userManager.FindByEmailAsync("admin@gmail.com");

			if (user == null)
			{
				user = new ApplicationUser
				{
					UserName = "admin@gmail.com",
					Email = "admin@gmail.com",
					EmailConfirmed = true
				};

				var result = await userManager.CreateAsync(user, "123456");

				if (result.Succeeded)
				{
					var claim = new Claim(ClaimTypes.Role, "admin");
					await userManager.AddClaimAsync(user, claim);
				}
				else
				{
					// Handle creation errors
					foreach (var error in result.Errors)
					{
						Console.WriteLine($"Error: {error.Description}");
					}
				}
			}
		}
	}
}
