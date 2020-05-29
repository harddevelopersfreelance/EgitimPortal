using AutoMapper;
using EgitimPortal.Business.Abstract;
using EgitimPortal.DataAccess.Abstract;
using EgitimPortal.Entities.Concrete;
using System.Collections.Generic;

namespace EgitimPortal.Business.Concrete.Managers
{
    public class QuestionLevelsManager : IQuestionLevelsService
    {
        private IQuestionLevelsDal _questionlevelsDal;
        private readonly IMapper _mapper;

        public QuestionLevelsManager(IQuestionLevelsDal questionlevelsDal, IMapper mapper)
        {
            _questionlevelsDal = questionlevelsDal;
            _mapper = mapper;
        }

         
         
        public List<QuestionLevels> GetAll()
        {
            var model = _mapper.Map<List<QuestionLevels>>(_questionlevelsDal.GetList());
            return model;
        }

         
         
        public QuestionLevels GetById(int id)
        {
            var model = _questionlevelsDal.Get(p => p.Id == id);
            return model;
        }

         
         
        public QuestionLevels Add(QuestionLevels questionlevels)
        {
            return _questionlevelsDal.Add(questionlevels);
        }

         
         
        public QuestionLevels Update(QuestionLevels questionlevels)
        {
            return _questionlevelsDal.Update(questionlevels);
        }

         
         
        public void Delete(QuestionLevels questionlevels)
        {
            _questionlevelsDal.Delete(questionlevels);
        }
    }
}