using AutoMapper;
using RoleplaySanctuary.Domain.Models.User;
using RoleplaySanctuary.Domain.Models.ViewModels;

namespace RoleplaySanctuary
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<RegisterViewModel, User>();
        }
    }
}
