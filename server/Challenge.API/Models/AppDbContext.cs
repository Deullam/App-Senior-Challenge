using client.Models;
using contact.Models;
using Microsoft.EntityFrameworkCore;

namespace livraria.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<Client>? Clients { get; set; }
    public DbSet<Contact>? Contacts { get; set; }


}
