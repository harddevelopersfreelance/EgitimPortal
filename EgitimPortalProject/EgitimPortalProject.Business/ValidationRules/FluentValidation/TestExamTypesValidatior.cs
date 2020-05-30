using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class TestExamTypesValidatior : AbstractValidator<TestExamTypes>
    {
        public TestExamTypesValidatior()
        {
            RuleFor(p => p.TestTypeName).NotEmpty().WithMessage("Boş Geçilemez !!!");
        }
    }
}