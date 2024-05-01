using Microsoft.EntityFrameworkCore;


namespace FinalProject.Models
{
	public class ShoeDbContext : DbContext
	{
		public ShoeDbContext (DbContextOptions<ShoeDbContext> options)
			: base(options)
		{
		}
		public DbSet<Shoe> Shoe {get; set;}
		public DbSet<Shop> Shop {get; set;}
	}
}