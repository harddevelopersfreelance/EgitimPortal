using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionOptionTypesValidatior : AbstractValidator<QuestionOptionTypes>
    {
        public QuestionOptionTypesValidatior()
        {
        }
    }
}