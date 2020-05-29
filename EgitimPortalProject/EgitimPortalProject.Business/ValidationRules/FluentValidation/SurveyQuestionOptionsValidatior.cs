using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SurveyQuestionOptionsValidatior : AbstractValidator<SurveyQuestionOptions>
    {
        public SurveyQuestionOptionsValidatior()
        {
        }
    }
}