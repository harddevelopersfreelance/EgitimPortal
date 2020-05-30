using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionAnswersService
    {
        List<QuestionAnswers> GetAll();

        QuestionAnswers GetById(int id);

        QuestionAnswers Add(QuestionAnswers questionanswers);

        QuestionAnswers Update(QuestionAnswers questionanswers);

        void Delete(QuestionAnswers questionanswers);

        List<QuestionAnswers> GetListByQuestionId(int questionid);

        List<QuestionAnswers> GetListByOptionId(int optionid);
    }
}