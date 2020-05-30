using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class ExamsValidatior : AbstractValidator<Exams>
    {
        public ExamsValidatior()
        {
            RuleFor(p => p.TestName).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.Title).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.IsActive).NotEmpty().WithMessage("Boş Geçilemez !!!");
            RuleFor(p => p.CreatedDate).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}