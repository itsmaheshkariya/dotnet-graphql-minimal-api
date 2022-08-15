using Mahesh.Entities;
using Microsoft.EntityFrameworkCore;
 
namespace Mahesh.Data;
 
public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {
 
    }
    public DbSet<User> User { get; set; }
}