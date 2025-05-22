namespace SistemaVendas.Data
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Design;

	namespace SistemaVendas.Data
	{
		public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
		{
			public AppDbContext CreateDbContext(string[] args)
			{
				var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
				optionsBuilder.UseSqlite("Data Source=SistemaVendas.db"); // ** -> mesmo nome do meu appsettings.json

				return new AppDbContext(optionsBuilder.Options);
			}
		}
	}

}
