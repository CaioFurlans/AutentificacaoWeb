using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoBanco.Models;
using static System.Net.Mime.MediaTypeNames;

namespace ProjetoBanco.Data
{
    public class IESContext : IdentityDbContext
    {
        public IESContext(DbContextOptions<IESContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Banco> Bancos { get; set; }
    }
}
