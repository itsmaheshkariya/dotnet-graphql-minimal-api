using Mahesh.Entities;
using Mahesh.Data;

namespace Mahesh.Types;
public class MutationType
{
    public async Task<User> CreateUserAsync([Service] UserDbContext context,
    User user)
    {
        context.User.Add(user);
        await context.SaveChangesAsync();
        return user;
    }
    public async Task<User> UpdateUserAsync([Service] UserDbContext context, User updateUser)
    {
        context.User.Update(updateUser);
        await context.SaveChangesAsync();
        return updateUser;
    }
    public async Task<string> DeleteUserAsync([Service] UserDbContext context, int id)
    {
        var userToDelete = await context.User.FindAsync(id);
        if (userToDelete == null)
        {
            return "Invalid Operation";
        }
        context.User.Remove(userToDelete);
        await context.SaveChangesAsync();
        return "Record Deleted!";
    }
}