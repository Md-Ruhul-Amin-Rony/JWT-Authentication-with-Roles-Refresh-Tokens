using JwtAuthDotNet.Entities;
using Microsoft.EntityFrameworkCore;

namespace JwtAuthDotNet.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
    {
        public DbSet<User> Users { get; set; }
    }
}
