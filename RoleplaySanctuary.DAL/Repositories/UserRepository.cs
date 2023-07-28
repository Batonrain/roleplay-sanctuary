using Microsoft.EntityFrameworkCore;
using RoleplaySanctuary.DAL.Repositories.Interfaces;
using RoleplaySanctuary.Domain.User;

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
}

