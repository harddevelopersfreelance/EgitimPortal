using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class ExamTestValidatior : AbstractValidator<ExamTest>
    {
        public ExamTestValidatior()
        {
        }
    }
}