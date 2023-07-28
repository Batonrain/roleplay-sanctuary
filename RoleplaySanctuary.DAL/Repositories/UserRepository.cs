using Microsoft.EntityFrameworkCore;
using RoleplaySanctuary.DAL.Repositories.Interfaces;
using RoleplaySanctuary.Domain.Models.User;

namespace RoleplaySanctuary.DAL.Repositories;

public class UserRepository : IUserRepository
{
    private readonly RoleplaySanctuaryDbContext _dbContext;

    public UserRepository(RoleplaySanctuaryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<User>> GetUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<int> SaveUserAsync(User user)
    {
        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync();
        return user.Id;
    }
}

