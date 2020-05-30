using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class AnnouncementUsersValidatior : AbstractValidator<AnnouncementUsers>
    {
        public AnnouncementUsersValidatior()
        {
        }
    }
}