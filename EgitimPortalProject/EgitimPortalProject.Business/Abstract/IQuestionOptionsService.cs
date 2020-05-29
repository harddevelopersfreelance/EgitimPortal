using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionOptionsService
    {
        List<QuestionOptions> GetAll();

        QuestionOptions GetById(int id);

        QuestionOptions Add(QuestionOptions questionoptions);

        QuestionOptions Update(QuestionOptions questionoptions);

        void Delete(QuestionOptions questionoptions);

        List<QuestionOptions> GetListByQuestionOptionTypeID(int questionoptiontypeid);
    }
}