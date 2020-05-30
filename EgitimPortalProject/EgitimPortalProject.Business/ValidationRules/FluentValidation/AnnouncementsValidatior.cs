using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class AnnouncementsValidatior : AbstractValidator<Announcements>
    {
        public AnnouncementsValidatior()
        {
            RuleFor(p => p.IsShared).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}