using Mahesh.Entities;
using Mahesh.Data;
using Microsoft.EntityFrameworkCore;
 
namespace Mahesh.Types;
 
public class QueryType
{
    public async Task<List<User>> AllUsersAsync([Service] UserDbContext context) 
    { 
        return await context.User.ToListAsync();
    }
}