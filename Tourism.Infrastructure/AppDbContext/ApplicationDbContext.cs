using Microsoft.EntityFrameworkCore;
using Tourism.Domain.Models;

namespace Tourism.Infrastructure.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Ticket> Tickets { get; set; }
    }
}