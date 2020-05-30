using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Abstract
{
    public interface ISurveyQuestionOptionsTypesService
    {
        List<SurveyQuestionOptionsTypes> GetAll();

        SurveyQuestionOptionsTypes GetById(int id);

        SurveyQuestionOptionsTypes Add(SurveyQuestionOptionsTypes surveyquestionoptionstypes);

        SurveyQuestionOptionsTypes Update(SurveyQuestionOptionsTypes surveyquestionoptionstypes);

        void Delete(SurveyQuestionOptionsTypes surveyquestionoptionstypes);
    }
}