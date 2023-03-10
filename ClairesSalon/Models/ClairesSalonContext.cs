using Microsoft.EntityFrameworkCore;

namespace ClairesSalon.Models
{
  public class ClairesSalonContext : DbContext
  {
    public DbSet<Stylist> Stylists { get; set; }
    public DbSet<Client> Clients { get; set; }

    public ClairesSalonContext(DbContextOptions options) : base(options) { }
  }
}
