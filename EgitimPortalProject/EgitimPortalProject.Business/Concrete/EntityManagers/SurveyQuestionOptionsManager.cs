using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveyQuestionOptionsManager : ISurveyQuestionOptionsService
    {
        private ISurveyQuestionOptionsDal _surveyquestionoptionsDal;
        private readonly IMapper _mapper;

        public SurveyQuestionOptionsManager(ISurveyQuestionOptionsDal surveyquestionoptionsDal, IMapper mapper)
        {
            _surveyquestionoptionsDal = surveyquestionoptionsDal;
            _mapper = mapper;
        }

         
         
        public List<SurveyQuestionOptions> GetAll()
        {
            var model = _mapper.Map<List<SurveyQuestionOptions>>(_surveyquestionoptionsDal.GetList());
            return model;
        }

         
         
        public SurveyQuestionOptions GetById(int id)
        {
            var model = _surveyquestionoptionsDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public SurveyQuestionOptions Add(SurveyQuestionOptions surveyquestionoptions)
        {
            return _surveyquestionoptionsDal.Add(surveyquestionoptions);
        }

         
         
        public SurveyQuestionOptions Update(SurveyQuestionOptions surveyquestionoptions)
        {
            return _surveyquestionoptionsDal.Update(surveyquestionoptions);
        }

         
         
        public void Delete(SurveyQuestionOptions surveyquestionoptions)
        {
            _surveyquestionoptionsDal.Delete(surveyquestionoptions);
        }

         
         
        /// Tablosu ile olan Foreign Key Column QuestionOptionTypeId
        public List<SurveyQuestionOptions> GetListByQuestionOptionTypeID(int questionoptiontypeid)
        {
            var model = _surveyquestionoptionsDal.GetList(p => p.QuestionOptionTypeId == questionoptiontypeid);
            return model;
        }

        
    }
}