using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveyQuestionsService
    {
        List<SurveyQuestions> GetAll();

        SurveyQuestions GetById(int id);

        SurveyQuestions Add(SurveyQuestions surveyquestions);

        SurveyQuestions Update(SurveyQuestions surveyquestions);

        void Delete(SurveyQuestions surveyquestions);
    }
}