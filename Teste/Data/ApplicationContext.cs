using Microsoft.EntityFrameworkCore;
using Teste.Models;

namespace Teste.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public ApplicationContext( DbContextOptions<ApplicationContext> options ) : base(options)
        {

        }
    }
}
