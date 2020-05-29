using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveyQuestionOptionsService
    {
        List<SurveyQuestionOptions> GetAll();

        SurveyQuestionOptions GetById(int id);

        SurveyQuestionOptions Add(SurveyQuestionOptions surveyquestionoptions);

        SurveyQuestionOptions Update(SurveyQuestionOptions surveyquestionoptions);

        void Delete(SurveyQuestionOptions surveyquestionoptions);

        List<SurveyQuestionOptions> GetListByQuestionOptionTypeID(int questionoptiontypeid);
    }
}