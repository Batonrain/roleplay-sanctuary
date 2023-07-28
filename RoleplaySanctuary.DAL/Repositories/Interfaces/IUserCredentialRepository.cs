using RoleplaySanctuary.Domain.Models.User;

namespace RoleplaySanctuary.DAL.Repositories.Interfaces;

public interface IUserCredentialRepository
{
    Task<int> AddNewCredential(LoginCredential loginCredential);
}

