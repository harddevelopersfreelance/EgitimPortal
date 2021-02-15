using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionOptionsValidatior : AbstractValidator<QuestionOptions>
    {
        public QuestionOptionsValidatior()
        {
            RuleFor(p => p.QuestionOptionTypeId).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}