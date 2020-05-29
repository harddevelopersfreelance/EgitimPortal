using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionLevelsValidatior : AbstractValidator<QuestionLevels>
    {
        public QuestionLevelsValidatior()
        {
        }
    }
}