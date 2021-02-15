using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionAnswersValidatior : AbstractValidator<QuestionAnswers>
    {
        public QuestionAnswersValidatior()
        {
        }
    }
}