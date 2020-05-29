using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SurveyQuestionAnswersValidatior : AbstractValidator<SurveyQuestionAnswers>
    {
        public SurveyQuestionAnswersValidatior()
        {
        }
    }
}