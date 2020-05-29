using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionCorrectAnswersManager : IQuestionCorrectAnswersService
    {
        private IQuestionCorrectAnswersDal _questioncorrectanswersDal;
        private readonly IMapper _mapper;

        public QuestionCorrectAnswersManager(IQuestionCorrectAnswersDal questioncorrectanswersDal, IMapper mapper)
        {
            _questioncorrectanswersDal = questioncorrectanswersDal;
            _mapper = mapper;
        }

         
         
        public List<QuestionCorrectAnswers> GetAll()
        {
            var model = _mapper.Map<List<QuestionCorrectAnswers>>(_questioncorrectanswersDal.GetList());
            return model;
        }

         
         
        public QuestionCorrectAnswers GetById(int id)
        {
            var model = _questioncorrectanswersDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public QuestionCorrectAnswers Add(QuestionCorrectAnswers questioncorrectanswers)
        {
            return _questioncorrectanswersDal.Add(questioncorrectanswers);
        }

         
         
        public QuestionCorrectAnswers Update(QuestionCorrectAnswers questioncorrectanswers)
        {
            return _questioncorrectanswersDal.Update(questioncorrectanswers);
        }

         
         
        public void Delete(QuestionCorrectAnswers questioncorrectanswers)
        {
            _questioncorrectanswersDal.Delete(questioncorrectanswers);
        }
    }
}