using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class AppDbConetx : DbContext
    {
        public AppDbConetx(DbContextOptions<AppDbConetx> options) : base(options)  { }

        public DbSet<Veiculo> Veiculos { get; set; }
    }
}
