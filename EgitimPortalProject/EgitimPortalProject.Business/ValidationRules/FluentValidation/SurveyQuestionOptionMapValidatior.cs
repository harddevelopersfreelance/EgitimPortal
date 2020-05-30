using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SurveyQuestionOptionMapValidatior : AbstractValidator<SurveyQuestionOptionMap>
    {
        public SurveyQuestionOptionMapValidatior()
        {
        }
    }
}