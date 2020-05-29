using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface IQuestionCorrectAnswersService
    {
        List<QuestionCorrectAnswers> GetAll();

        QuestionCorrectAnswers GetById(int id);

        QuestionCorrectAnswers Add(QuestionCorrectAnswers questioncorrectanswers);

        QuestionCorrectAnswers Update(QuestionCorrectAnswers questioncorrectanswers);

        void Delete(QuestionCorrectAnswers questioncorrectanswers);
    }
}