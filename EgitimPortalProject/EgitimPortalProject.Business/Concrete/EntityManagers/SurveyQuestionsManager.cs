using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveyQuestionsManager : ISurveyQuestionsService
    {
        private ISurveyQuestionsDal _surveyquestionsDal;
        private readonly IMapper _mapper;

        public SurveyQuestionsManager(ISurveyQuestionsDal surveyquestionsDal, IMapper mapper)
        {
            _surveyquestionsDal = surveyquestionsDal;
            _mapper = mapper;
        }

         
         
        public List<SurveyQuestions> GetAll()
        {
            var model = _mapper.Map<List<SurveyQuestions>>(_surveyquestionsDal.GetList());
            return model;
        }

         
         
        public SurveyQuestions GetById(int id)
        {
            var model = _surveyquestionsDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public SurveyQuestions Add(SurveyQuestions surveyquestions)
        {
            return _surveyquestionsDal.Add(surveyquestions);
        }

         
         
        public SurveyQuestions Update(SurveyQuestions surveyquestions)
        {
            return _surveyquestionsDal.Update(surveyquestions);
        }

         
         
        public void Delete(SurveyQuestions surveyquestions)
        {
            _surveyquestionsDal.Delete(surveyquestions);
        }
    }
}