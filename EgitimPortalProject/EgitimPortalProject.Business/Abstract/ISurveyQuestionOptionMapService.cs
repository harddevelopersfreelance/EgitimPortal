using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveyQuestionOptionMapService
    {
        List<SurveyQuestionOptionMap> GetAll();

        SurveyQuestionOptionMap GetById(int id);

        SurveyQuestionOptionMap Add(SurveyQuestionOptionMap surveyquestionoptionmap);

        SurveyQuestionOptionMap Update(SurveyQuestionOptionMap surveyquestionoptionmap);

        void Delete(SurveyQuestionOptionMap surveyquestionoptionmap);

        List<SurveyQuestionOptionMap> GetListBySurveyQuestionID(int surveyquestionid);

        List<SurveyQuestionOptionMap> GetListBySurveyOptionID(int surveyoptionid);
    }
}