using EgitimPortalProject.Core.Entities.Abstract;

namespace EgitimPortalProject.Business.ObjectDtos.UserDtos
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}