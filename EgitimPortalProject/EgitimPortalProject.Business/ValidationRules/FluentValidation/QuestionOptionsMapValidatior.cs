using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionOptionsMapValidatior : AbstractValidator<QuestionOptionsMap>
    {
        public QuestionOptionsMapValidatior()
        {
        }
    }
}