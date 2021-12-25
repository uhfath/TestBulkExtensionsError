using Microsoft.EntityFrameworkCore;

namespace TestBulkExtensionsError;

internal class TestDbContext : DbContext
{
	private const string ConnectionString = @"Server=(localdb)\mssqllocaldb;Database=MedServiceCard;";

	public DbSet<Client> Clients { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(ConnectionString);
		base.OnConfiguring(optionsBuilder);
	}
}
