using Apartment.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Apartment.Infrastructure.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
           
        }
        public virtual DbSet<ApartmentModels> Apartments {  get; set; } 
    }
}
