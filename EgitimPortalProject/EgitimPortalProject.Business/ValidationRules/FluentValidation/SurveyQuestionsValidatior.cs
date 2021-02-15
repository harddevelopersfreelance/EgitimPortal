using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SurveyQuestionsValidatior : AbstractValidator<SurveyQuestions>
    {
        public SurveyQuestionsValidatior()
        {
        }
    }
}