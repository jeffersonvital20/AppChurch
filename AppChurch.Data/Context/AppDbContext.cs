using AppChurch.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AppChurch.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {}

        public DbSet<MembroModel>? Membro { get; set; }
        public DbSet<EnderecoModel>? Endereco { get; set; }
        public DbSet<DizimoModel>? Dizimo { get; set; }
    }
}
