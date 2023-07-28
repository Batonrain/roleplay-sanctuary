using AutoMapper;
using RoleplaySanctuary.DAL.Repositories.Interfaces;
using RoleplaySanctuary.Domain.Models.User;
using RoleplaySanctuary.Domain.Models.ViewModels;
using RoleplaySanctuary.Domain.Services.Interfaces;

namespace RoleplaySanctuary.Domain.Services;

public class UserRegistrationService : IUserRegistrationService
{
    private readonly IUserRepository _userRepository;
    private readonly IUserCredentialRepository _userCredentialRepository;
    private readonly IMapper _mapper;
    public UserRegistrationService(IUserRepository userRepository, IMapper mapper, IUserCredentialRepository userCredentialRepository)
    {
        _userRepository = userRepository;
        _mapper = mapper;
        _userCredentialRepository = userCredentialRepository;
    }

    public async Task<int> RegisterNewUser(RegisterViewModel model)
    {
        var user = _mapper.Map<User>(model);
        user.Id =  await _userRepository.SaveUserAsync(user);

        var credentials = new LoginCredential
        {
            UserId = user.Id,
            Username = model.Username,
            Password = model.Password,
        };
        credentials.Id = await _userCredentialRepository.AddNewCredential(credentials);

        return 0;
    }
}

