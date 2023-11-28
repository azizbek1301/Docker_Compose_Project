using Car.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Car.Infrastructure.AppDbContext
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public virtual DbSet<Cars> Cars { get; set; }
    }
}

