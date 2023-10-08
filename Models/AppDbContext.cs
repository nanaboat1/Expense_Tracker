using Microsoft.EntityFrameworkCore;


namespace expense_tracker.Models
{
	public class AppDbContext : DbContext 
	{
		public DbSet<Transaction> Transactions { get; set; }
		public DbSet<Category> Categories { get; set; }

		public AppDbContext(DbContextOptions options) : base (options)
		{
		}
	}
}

