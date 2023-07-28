using RoleplaySanctuary.DAL.Repositories.Interfaces;
using RoleplaySanctuary.Domain.Models.User;

namespace RoleplaySanctuary.DAL.Repositories;

public class UserCredentialRepository : IUserCredentialRepository
{
    private readonly RoleplaySanctuaryDbContext _dbContext;

    public UserCredentialRepository(RoleplaySanctuaryDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<int> AddNewCredential(LoginCredential loginCredential)
    {
        _dbContext.LoginCredentials.Add(loginCredential);
        await _dbContext.SaveChangesAsync();
        return loginCredential.Id;
    }
}

