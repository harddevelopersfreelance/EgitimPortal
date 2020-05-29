using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionTypesValidatior : AbstractValidator<QuestionTypes>
    {
        public QuestionTypesValidatior()
        {
        }
    }
}