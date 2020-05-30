using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class UsersValidatior : AbstractValidator<Users>
    {
        public UsersValidatior()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.LastName).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.PasswordSalt).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.PasswordHash).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.Email).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}