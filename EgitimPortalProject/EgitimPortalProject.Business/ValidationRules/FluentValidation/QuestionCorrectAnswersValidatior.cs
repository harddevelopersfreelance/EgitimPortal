using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class QuestionCorrectAnswersValidatior : AbstractValidator<QuestionCorrectAnswers>
    {
        public QuestionCorrectAnswersValidatior()
        {
        }
    }
}