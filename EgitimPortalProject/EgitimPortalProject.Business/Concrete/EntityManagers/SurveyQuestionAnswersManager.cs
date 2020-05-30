using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class SurveyQuestionAnswersManager : ISurveyQuestionAnswersService
    {
        private ISurveyQuestionAnswersDal _surveyquestionanswersDal;
        private readonly IMapper _mapper;

        public SurveyQuestionAnswersManager(ISurveyQuestionAnswersDal surveyquestionanswersDal, IMapper mapper)
        {
            _surveyquestionanswersDal = surveyquestionanswersDal;
            _mapper = mapper;
        }

        public List<SurveyQuestionAnswers> GetAll()
        {
            var model = _mapper.Map<List<SurveyQuestionAnswers>>(_surveyquestionanswersDal.GetList());
            return model;
        }

        public SurveyQuestionAnswers GetById(int id)
        {
            var model = _surveyquestionanswersDal.Get(p => p.Id == id);
            return model;
        }

        public SurveyQuestionAnswers Add(SurveyQuestionAnswers surveyquestionanswers)
        {
            return _surveyquestionanswersDal.Add(surveyquestionanswers);
        }

        public SurveyQuestionAnswers Update(SurveyQuestionAnswers surveyquestionanswers)
        {
            return _surveyquestionanswersDal.Update(surveyquestionanswers);
        }

        public void Delete(SurveyQuestionAnswers surveyquestionanswers)
        {
            _surveyquestionanswersDal.Delete(surveyquestionanswers);
        }

        /// Tablosu ile olan Foreign Key Column QuestionId
        public List<SurveyQuestionAnswers> GetListByQuestionId(int questionid)
        {
            var model = _surveyquestionanswersDal.GetList(p => p.QuestionId == questionid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column OptionId
        public List<SurveyQuestionAnswers> GetListByOptionId(int optionid)
        {
            var model = _surveyquestionanswersDal.GetList(p => p.OptionId == optionid);
            return model;
        }
    }
}