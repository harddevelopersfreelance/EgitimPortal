using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class SurveyQuestionOptionsTypesValidatior : AbstractValidator<SurveyQuestionOptionsTypes>
    {
        public SurveyQuestionOptionsTypesValidatior()
        {
        }
    }
}