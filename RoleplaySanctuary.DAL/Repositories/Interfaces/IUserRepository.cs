using RoleplaySanctuary.Domain.Models.User;

namespace RoleplaySanctuary.DAL.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();
        Task<int> SaveUserAsync(User user);
    }
}
