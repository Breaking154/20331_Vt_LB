using Podterob.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Podterob.API.Data
{
	public class AppDbContext : IdentityDbContext
	{
		public DbSet<Dish> Dishes { get; set; }
		public DbSet<Category> Categories { get; set; }

		public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
		{
		}
	}
}
