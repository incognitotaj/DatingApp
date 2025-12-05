using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class ApiDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<AppUser> Users { get; set; }
}
