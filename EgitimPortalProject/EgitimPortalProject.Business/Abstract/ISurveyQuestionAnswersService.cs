using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveyQuestionAnswersService
    {
        List<SurveyQuestionAnswers> GetAll();

        SurveyQuestionAnswers GetById(int id);

        SurveyQuestionAnswers Add(SurveyQuestionAnswers surveyquestionanswers);

        SurveyQuestionAnswers Update(SurveyQuestionAnswers surveyquestionanswers);

        void Delete(SurveyQuestionAnswers surveyquestionanswers);

        List<SurveyQuestionAnswers> GetListByQuestionID(int questionid);

        List<SurveyQuestionAnswers> GetListByOptionID(int optionid);
    }
}