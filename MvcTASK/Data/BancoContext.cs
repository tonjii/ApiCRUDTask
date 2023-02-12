using Microsoft.EntityFrameworkCore;
using MVCTask.Models;

namespace MVCTask.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) 
        { 

        }

        public DbSet<ContatoModel> Contato { get; set; }
    }
}
