namespace SistemaVendas.Data
{
	using global::SistemaVendas.Model;
	using Microsoft.EntityFrameworkCore;

	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options) { }

		public DbSet<SistemaVendas_Modelo> Modelo_DB_Projeto { get; set; }
	}
}
