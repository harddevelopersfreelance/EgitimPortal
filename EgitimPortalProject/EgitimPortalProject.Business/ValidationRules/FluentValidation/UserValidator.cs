using EgitimPortalProject.Core.Entities.Concrete;
using FluentValidation;

namespace Project.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<Users>
    {
        public UserValidator()
        {
            //burada yapılan işler dataannotations işlemleridir. boş geçilez, max min degerleri falan filan düzenlenecek
            // yazılacak yer - örnek amaclı
            RuleFor(p => p.Email).NotEmpty().WithMessage("E Mail adresi boş geçilemez");
        }
    }
}