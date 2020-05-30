using EgitimPortal.Entities.Concrete;
using FluentValidation;

namespace EgitimPortal.Business.ValidationRules.FluentValidation
{
    public class ExamTypeValidatior : AbstractValidator<ExamType>
    {
        public ExamTypeValidatior()
        {
        }
    }
}