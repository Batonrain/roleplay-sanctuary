using RoleplaySanctuary.Domain.Models.User;
using RoleplaySanctuary.Domain.Models.ViewModels;

namespace RoleplaySanctuary.Domain.Services.Interfaces;

public interface IUserRegistrationService
{
    Task<int> RegisterNewUser(RegisterViewModel user);
}

