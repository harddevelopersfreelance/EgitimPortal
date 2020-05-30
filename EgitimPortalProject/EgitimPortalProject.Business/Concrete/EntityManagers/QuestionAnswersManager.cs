using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionAnswersManager : IQuestionAnswersService
    {
        private IQuestionAnswersDal _questionanswersDal;
        private readonly IMapper _mapper;

        public QuestionAnswersManager(IQuestionAnswersDal questionanswersDal, IMapper mapper)
        {
            _questionanswersDal = questionanswersDal;
            _mapper = mapper;
        }

        public List<QuestionAnswers> GetAll()
        {
            var model = _mapper.Map<List<QuestionAnswers>>(_questionanswersDal.GetList());
            return model;
        }

        public QuestionAnswers GetById(int id)
        {
            var model = _questionanswersDal.Get(p => p.Id == id);
            return model;
        }

        public QuestionAnswers Add(QuestionAnswers questionanswers)
        {
            return _questionanswersDal.Add(questionanswers);
        }

        public QuestionAnswers Update(QuestionAnswers questionanswers)
        {
            return _questionanswersDal.Update(questionanswers);
        }

        public void Delete(QuestionAnswers questionanswers)
        {
            _questionanswersDal.Delete(questionanswers);
        }

        /// Tablosu ile olan Foreign Key Column QuestionId
        public List<QuestionAnswers> GetListByQuestionId(int questionid)
        {
            var model = _questionanswersDal.GetList(p => p.QuestionId == questionid);
            return model;
        }

        /// Tablosu ile olan Foreign Key Column OptionId
        public List<QuestionAnswers> GetListByOptionId(int optionid)
        {
            var model = _questionanswersDal.GetList(p => p.OptionId == optionid);
            return model;
        }
    }
}