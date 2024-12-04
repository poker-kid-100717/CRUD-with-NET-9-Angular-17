using CRUD_with_NET_9_Angular_17.Server.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CRUD_with_NET_9_Angular_17.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Case> Cases { get; set; }
    }
}
