using Challenge.Domain.Features.Boleto;
using Challenge.Infra.ORM.Features.Boletos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Challenge.Infra.ORM.Contexts
{
    public class ContextChallenge : DbContext
    {
        private readonly string _connectionString;

        public ContextChallenge(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ContextChallenge(DbContextOptions<ContextChallenge> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        public DbSet<Boleto> Boletos { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new BoletoMapper());
        }
    }
}
