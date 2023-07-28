using RoleplaySanctuary.Domain.User;

namespace RoleplaySanctuary.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
    }
}
